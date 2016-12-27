using System;
using System.Drawing;
using System.Net.WebSockets;
using System.Threading;
using System.Windows.Forms;
using DuoSoftware.DuoSoftPhone.Controllers;
using DuoSoftware.DuoSoftPhone.Controllers.AgentStatus;
using DuoSoftware.DuoSoftPhone.Controllers.Service;
using DuoSoftware.DuoTools.DuoLogger;
using VIBlend.Utilities;

namespace DuoSoftware.DuoSoftPhone.Ui
{
    
    public partial class Login : Form
    {
        

        private static Mutex mutex;
        
        public Login()
        {
            InitializeComponent();
            
        }

        private void button_login_Click(object sender, EventArgs e)
        {
           UserLogin();
        }

        
        
        private void UserLogin()
        {
            try
            {
               
                if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Login Fail", "Duo Dialer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                button_login.Enabled = false;
                ProgressBar.Start();
                ProgressBar.Show();
                var isSuccess = AgentProfile.Instance.Login(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                if (isSuccess)
                {
                    new Thread(MonitorRestApiHandler.MapResourceToVeery).Start();
                    Hide();
                    new FormDialPad().ShowDialog(this);
                    this.Close();
                    Environment.Exit(0);
                }
                else
                {
                    Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "Login Fail", Logger.LogLevel.Error);
                    MessageBox.Show("Login Fail", "Duo Dialer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                button_login.Enabled = true;
                txtPassword.Text=string.Empty;
                ProgressBar.Stop();
                ProgressBar.Hide();
            }
            catch (Exception exception)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    button_login.Enabled = true;
                    //ProgressBar.Stop();
                    //ProgressBar.Hide();
                    txtPassword.Text = string.Empty;
                }));
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "Login fail", exception, Logger.LogLevel.Error);
                MessageBox.Show("Login Fail", "Duo Dialer", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            UserLogin();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            FillStyleGradientEx highlightGradient = new FillStyleGradientEx(Color.LightGreen, Color.GreenYellow, Color.Green, Color.DarkGreen, 90f, 0.2f, 0.3f);
            FillStyleGradientEx defaultGradient = new FillStyleGradientEx(Color.Black, Color.Black, Color.Black, Color.Black, 90f, 0.3f, 0.5f);
            FillStyleGradientEx pressedGradient = new FillStyleGradientEx(Color.Black, Color.Black, Color.Black, Color.Black, 90f, 0.4f, 0.5f);
            FillStyleGradientEx disabledGradient = new FillStyleGradientEx(Color.Silver, Color.Silver, Color.Silver, Color.Silver, 90f, 0.4f, 0.5f);
            ControlTheme theme = ControlTheme.GetDefaultTheme(VIBLEND_THEME.STEEL);
            theme.StyleHighlight.FillStyle = highlightGradient;
            theme.StyleDisabled.FillStyle = disabledGradient;
            theme.StylePressed.FillStyle = pressedGradient;
            theme.StyleNormal.FillStyle = defaultGradient;
            this.button_login.StyleKey = "loginStyle";
            this.button_login.Theme = theme;
            this.button_login.UseThemeTextColor = false;
            this.button_login.HighlightTextColor = Color.White;
            this.button_login.ForeColor = Color.White;
            this.button_login.PressedTextColor = Color.White;
            ActiveControl = txtUserName;
            txtUserName.Select();

            bool ok;

            //The name used when creating the mutex can be any string you want
            mutex = new Mutex(true, "DuoSoftPhone", out ok);

            if (!ok)
            {
                MessageBox.Show("Application Already Running", "Duo Soft Phone", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification, false);
                Environment.Exit(100);
            }
            button_login.Enabled = true;
            ProgressBar.Hide();
        }

        
    }
}
