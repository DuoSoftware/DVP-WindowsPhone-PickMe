using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuoSoftware.DuoTools.DuoLogger;
using VIBlend.Utilities;

namespace DuoSoftware.DuoSoftPhone.Ui
{
    public partial class frmIncomingCall : Form
    {
        private int Interval = 25;

        public bool IsCallAnswered;


        public frmIncomingCall(bool isNotAllowToReject, int reginTime = 60)
        {
            InitializeComponent();
            Interval = reginTime;

            FillStyleGradientEx rejecthighlightGradient = new FillStyleGradientEx(Color.OrangeRed, Color.OrangeRed, Color.DarkRed, Color.DarkRed, 90f, 0.2f, 0.3f);
            FillStyleGradientEx rejectdefaultGradient = new FillStyleGradientEx(Color.DarkRed, Color.DarkRed, Color.OrangeRed, Color.OrangeRed, 90f, 0.3f, 0.5f);
            FillStyleGradientEx rejectpressedGradient = new FillStyleGradientEx(Color.Black, Color.Black, Color.Black, Color.Black, 90f, 0.4f, 0.5f);
            FillStyleGradientEx rejectdisabledGradient = new FillStyleGradientEx(Color.Silver, Color.Silver, Color.Silver, Color.Silver, 90f, 0.4f, 0.5f);
            ControlTheme rejecttheme = ControlTheme.GetDefaultTheme(VIBLEND_THEME.STEEL);
            rejecttheme.StyleHighlight.FillStyle = rejecthighlightGradient;
            rejecttheme.StyleDisabled.FillStyle = rejectdisabledGradient;
            rejecttheme.StylePressed.FillStyle = rejectpressedGradient;
            rejecttheme.StyleNormal.FillStyle = rejectdefaultGradient;
            this.buttonReject.StyleKey = "rejectStyle1";
            this.buttonReject.Theme = rejecttheme;
            this.buttonReject.UseThemeTextColor = false;
            this.buttonReject.HighlightTextColor = Color.White;
            this.buttonReject.ForeColor = Color.White;
            this.buttonReject.PressedTextColor = Color.White;


            FillStyleGradientEx highlightGradient = new FillStyleGradientEx(Color.LightGreen, Color.GreenYellow, Color.Green, Color.DarkGreen, 90f, 0.2f, 0.3f);
            FillStyleGradientEx defaultGradient = new FillStyleGradientEx(Color.DarkGreen, Color.Green, Color.GreenYellow, Color.LightGreen, 90f, 0.3f, 0.5f);
            FillStyleGradientEx pressedGradient = new FillStyleGradientEx(Color.Black, Color.Black, Color.Black, Color.Black, 90f, 0.4f, 0.5f);
            FillStyleGradientEx disabledGradient = new FillStyleGradientEx(Color.Silver, Color.Silver, Color.Silver, Color.Silver, 90f, 0.4f, 0.5f);
            ControlTheme theme = ControlTheme.GetDefaultTheme(VIBLEND_THEME.STEEL);
            theme.StyleHighlight.FillStyle = highlightGradient;
            theme.StyleDisabled.FillStyle = disabledGradient;
            theme.StylePressed.FillStyle = pressedGradient;
            theme.StyleNormal.FillStyle = defaultGradient;

            this.buttonAnswer.StyleKey = "answerStyle1";
            this.buttonAnswer.Theme = theme;
            this.buttonAnswer.UseThemeTextColor = false;
            this.buttonAnswer.HighlightTextColor = Color.White;
            this.buttonAnswer.ForeColor = Color.White;
            this.buttonAnswer.PressedTextColor = Color.White;

            buttonReject.Enabled = !isNotAllowToReject;
            menuItemRejectCall.Enabled = !isNotAllowToReject;
        }

        private void frmIncomingCall_Load(object sender, EventArgs e)
        {
            this.ActiveControl = buttonAnswer;
            buttonAnswer.Focus();
            this.ContextMenu = phoner8ClickMenu;
           
            timer1.Interval =(int) new TimeSpan(0, 0, Interval).TotalMilliseconds;
            timer1.Tick += (s, t) =>
            {
                timer1.Stop();
                timer1.Enabled = false;
                IsCallAnswered = false;
                this.Close();
            };
            timer1.Enabled = true;
            timer1.Start();

        }


        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            IsCallAnswered = true; this.Close();
        }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            IsCallAnswered = false; this.Close();
        }
        
    }
}
