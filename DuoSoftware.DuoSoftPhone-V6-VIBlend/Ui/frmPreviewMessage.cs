using DuoSoftware.DuoSoftPhone.Controllers.Service;
using DuoSoftware.DuoTools.DuoLogger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using VIBlend.Utilities;

namespace DuoSoftware.DuoSoftPhone.Ui
{
    public partial class frmPreviewMessage : Form
    {
        private int Interval = 25;

        public bool IsCallAnswered;

        private string key = "";

        private string msg = "";

        private SoundPlayer _wavPlayer;

        private int timeLeft;



        public frmPreviewMessage(string key, string msg, SoundPlayer player, int reginTime = 60)
        {
            try
            {
                this.InitializeComponent();
                this.key = key;
                this.msg = msg;
                this._wavPlayer = player;
                this.Interval = reginTime;
                FillStyleGradientEx rejecthighlightGradient = new FillStyleGradientEx(Color.OrangeRed, Color.OrangeRed, Color.DarkRed, Color.DarkRed, 90f, 0.2f, 0.3f);
                FillStyleGradientEx rejectdefaultGradient = new FillStyleGradientEx(Color.DarkRed, Color.DarkRed, Color.OrangeRed, Color.OrangeRed, 90f, 0.3f, 0.5f);
                FillStyleGradientEx rejectpressedGradient = new FillStyleGradientEx(Color.Black, Color.Black, Color.Black, Color.Black, 90f, 0.4f, 0.5f);
                FillStyleGradientEx rejectdisabledGradient = new FillStyleGradientEx(Color.Silver, Color.Silver, Color.Silver, Color.Silver, 90f, 0.4f, 0.5f);
                ControlTheme rejecttheme = ControlTheme.GetDefaultTheme(VIBLEND_THEME.STEEL);
                rejecttheme.StyleHighlight.FillStyle = rejecthighlightGradient;
                rejecttheme.StyleDisabled.FillStyle = rejectdisabledGradient;
                rejecttheme.StylePressed.FillStyle = rejectpressedGradient;
                rejecttheme.StyleNormal.FillStyle = rejectdefaultGradient;
                FillStyleGradientEx highlightGradient = new FillStyleGradientEx(Color.LightGreen, Color.GreenYellow, Color.Green, Color.DarkGreen, 90f, 0.2f, 0.3f);
                FillStyleGradientEx defaultGradient = new FillStyleGradientEx(Color.DarkGreen, Color.Green, Color.GreenYellow, Color.LightGreen, 90f, 0.3f, 0.5f);
                FillStyleGradientEx pressedGradient = new FillStyleGradientEx(Color.Black, Color.Black, Color.Black, Color.Black, 90f, 0.4f, 0.5f);
                FillStyleGradientEx disabledGradient = new FillStyleGradientEx(Color.Silver, Color.Silver, Color.Silver, Color.Silver, 90f, 0.4f, 0.5f);
                ControlTheme theme = ControlTheme.GetDefaultTheme(VIBLEND_THEME.STEEL);
                theme.StyleHighlight.FillStyle = highlightGradient;
                theme.StyleDisabled.FillStyle = disabledGradient;
                theme.StylePressed.FillStyle = pressedGradient;
                theme.StyleNormal.FillStyle = defaultGradient;
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDeviceMonitor, "frmPreviewMessage", exception, Logger.LogLevel.Error);
            }
        }

        private void frmIncomingCall_Load(object sender, EventArgs e)
        {
            try
            {

                base.ActiveControl = this.btnAccepted;
                this.btnAccepted.Focus();
                this.btnAccepted.Enabled = true;
                this.ContextMenu = this.phoner8ClickMenu;
                this.timer1.Interval = (int)new TimeSpan(0, 0, this.Interval).TotalMilliseconds;
                timeLeft = (int)new TimeSpan(0, 0, this.Interval).TotalSeconds;
                this.timer1.Tick += delegate
                {
                    this.timer1.Stop();
                    this.timer1.Enabled = false;
                    this.IsCallAnswered = false;
                    this.btnAccepted.Enabled = false;
                    ardsHandler.ReplyToDialerRequest(this.key, "PREVIEW_TIMEOUT");
                    base.Close();
                };
                this.timer1.Enabled = true;
                this.timer1.Start();
                this._wavPlayer.PlayLooping();
                this.txtPreviewMessage.Clear();
                Dictionary<string, string> msgt = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(this.msg);
                foreach (KeyValuePair<string, string> item in msgt)
                {
                    if (this.txtPreviewMessage.Text.Length == 0)
                    {
                        this.txtPreviewMessage.Text = string.Format("{0} : {1}", item.Key, item.Value);
                    }
                    else
                    {
                        this.txtPreviewMessage.AppendText("\r\n" + string.Format("{0} : {1}", item.Key, item.Value));
                    }
                }

                this.Countdown_timer.Tick += delegate
                 {
                     try
                     {
                         if (timeLeft > 0)
                         {
                             timeLeft = timeLeft - 1;
                             // Display time remaining as mm:ss
                             var timespan = TimeSpan.FromSeconds(timeLeft);
                             txtTimer.Text = timespan.ToString(@"mm\:ss");
                             // Alternate method
                             //int secondsLeft = timeLeft % 60;
                             //int minutesLeft = timeLeft / 60;
                         }
                         else
                         {
                             this.btnAccepted.Enabled = false;
                             Countdown_timer.Stop();
                             SystemSounds.Exclamation.Play();
                         }


                     }
                     catch(Exception exception)
                     {
                         Logger.Instance.LogMessage(Logger.LogAppender.DuoDeviceMonitor, "Countdown_timer", exception, Logger.LogLevel.Error);

                     }
                 };
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDeviceMonitor, "btnAccepted_Click", exception, Logger.LogLevel.Error);
            }
        }

        private void btnAccepted_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Delay(1000).ContinueWith((Task t) => ardsHandler.ReplyToDialerRequest(this.key, "ACCEPTED"));
                base.DialogResult = DialogResult.OK;
                base.Close();
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDeviceMonitor, "btnAccepted_Click", exception, Logger.LogLevel.Error);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            try
            {
                ardsHandler.ReplyToDialerRequest(this.key, "PREVIEW_REJECT");
                base.DialogResult = DialogResult.Cancel;
                base.Close();
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDeviceMonitor, "btnReject_Click", exception, Logger.LogLevel.Error);
            }
        }

        private void txtPreviewMessage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Size sz = new Size(this.txtPreviewMessage.ClientSize.Width, 2147483647);
                TextFormatFlags flags = TextFormatFlags.WordBreak;
                int padding = 3;
                int borders = this.txtPreviewMessage.Height - this.txtPreviewMessage.ClientSize.Height;
                sz = TextRenderer.MeasureText(this.txtPreviewMessage.Text, this.txtPreviewMessage.Font, sz, flags);
                int h = sz.Height + borders + padding;
                if (this.txtPreviewMessage.Top + h > base.ClientSize.Height - 10)
                {
                    h = base.ClientSize.Height - 10 - this.txtPreviewMessage.Top;
                }
                if (h > 15)
                {
                    this.txtPreviewMessage.Height = h;
                    base.Height += this.txtPreviewMessage.Height - 15;
                    this.btnAccepted.Location = new Point(this.btnAccepted.Location.X, this.btnAccepted.Location.Y + (h - 15));
                    this.btnReject.Location = new Point(this.btnReject.Location.X, this.btnReject.Location.Y + (h - 15));
                }
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDeviceMonitor, "txtPreviewMessage_TextChanged", exception, Logger.LogLevel.Error);
            }
        }

        private void frmPreviewMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this._wavPlayer.Stop();
                this._wavPlayer.Dispose();
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDeviceMonitor, "frmPreviewMessage_FormClosing", exception, Logger.LogLevel.Error);
            }
        }

    }
}
