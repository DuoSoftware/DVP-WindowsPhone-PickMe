using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuoSoftware.DuoTools.DuoLogger;
using DuoSoftware.DuoSoftPhone.Controllers.Common;
using Infragistics.Win.UltraWinExplorerBar;

namespace DuoSoftware.DuoSoftPhone.Ui
{
    public partial class frmCallLogs : Form
    {
        
        //Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup CallLogsGroup = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
        public delegate void NumberSelected(string phnNo);

        public event NumberSelected OnNumberSelect;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        

        public frmCallLogs(Dictionary<Guid, CallLog> callLogs)
        {
            InitializeComponent();


            if (callLogs == null) return;

            foreach (var callLog in callLogs)
            {
                switch (callLog.Value.Direction)
                {
                    case 0:
                        AddIncommingToCallLogs(callLog.Value.PhoneNo, callLog.Value.time, callLog.Value.Durations,callLog.Value.Skill);
                        break;
                    case 1:
                        AddOutgoingCallToCallLogs(callLog.Value.PhoneNo, callLog.Value.time, callLog.Value.Durations, callLog.Value.Skill);
                        break;
                    case 2:
                        AddMissCallToCallLogs(callLog.Value.PhoneNo, callLog.Value.time, callLog.Value.Durations, callLog.Value.Skill);
                        break;
                }
            }
            //AddIncommingToCallLogs("1234567890", DateTime.Now, 1236);
            //AddOutgoingCallToCallLogs("1234567890", DateTime.Now, 1236);
            //AddMissCallToCallLogs("1234567890", DateTime.Now, 1236);
        }

        public void AddIncommingToCallLogs(string no, DateTime time, double durations,string skill)
        {
            try
            {
                var appearance = new Infragistics.Win.Appearance
                {
                    Image = global::DuoSoftware.DuoSoftPhone.Properties.Resources.callLogincomming,
                    ForeColor = Color.Green,
                };


                var callLogsGroup = this.EBarCallInfo.Groups["CallLogs"];

                var ebItem = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem { Key = no, Text = string.Format("{0} - {1} - {2} - {3}", no, durations, time.ToString("d/M/yy HH:mm:ss"), skill) };
                ebItem.Settings.AppearancesSmall.Appearance = appearance;
                //callLogsGroup.Items.Add(ebItem);
                callLogsGroup.Items.Insert(1, ebItem);
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "AddIncommingToCallLogs", exception, Logger.LogLevel.Error);
            }
        }

        public void AddOutgoingCallToCallLogs(string no, DateTime time, double durations, string skill)
        {
            try
            {
                var appearance = new Infragistics.Win.Appearance
                {
                    Image = Properties.Resources.calloutgoing,
                    ForeColor = Color.DarkSlateBlue,
                };
                var callLogsGroup = this.EBarCallInfo.Groups["CallLogs"];

                var ebItem = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem { Key = no, Text = string.Format("{0} - {1} - {2} - {3}", no, durations, time.ToString("d/M/yy HH:mm:ss"), skill) };
                ebItem.Settings.AppearancesSmall.Appearance = appearance;
                //callLogsGroup.Items.Add(ebItem);
                callLogsGroup.Items.Insert(1, ebItem);
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "AddOutgoingCallToCallLogs", exception, Logger.LogLevel.Error);
            }
        }

        public void AddMissCallToCallLogs(string no, DateTime time, double durations, string skill)
        {
            try
            {
                var appearance = new Infragistics.Win.Appearance
                {
                    Image = Properties.Resources.MissCallCallLog,
                    ForeColor = Color.DarkRed,

                };
                var callLogsGroup = this.EBarCallInfo.Groups["CallLogs"];

                var ebItem = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem { Key = no, Text = string.Format("{0} - {1} - {2} - {3}", no, durations, time.ToString("d/M/yy HH:mm:ss"),skill) };
                
                ebItem.Settings.AppearancesSmall.Appearance = appearance;
                //callLogsGroup.Items.Add(ebItem);
                callLogsGroup.Items.Insert(1, ebItem);
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "AddMissCallToCallLogs", exception, Logger.LogLevel.Error);
            }
        }

       
       
        private void ExplorerBarAgent_ItemRemoving(object sender, Infragistics.Win.UltraWinExplorerBar.CancelableItemEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EBarCallInfo_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "EBarCallInfo_MouseDown", exception, Logger.LogLevel.Error);
            }
        }

        private void EBarCallInfo_ItemDoubleClick(object sender, ItemEventArgs e)
        {
            try
            {
                if (e.Item!= null)
                {
                    if (e.Item.Key.Equals("0000000000"))
                        return;
                    if (OnNumberSelect != null)
                        OnNumberSelect(e.Item.Key);
                    //textBox1.Text = ebar.ActiveItem.Key;
                }

            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "ExplorerBarAgent_MouseDoubleClick", exception, Logger.LogLevel.Error);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "EBarCallInfo_MouseDown", exception, Logger.LogLevel.Error);
            }
        }

        

        //private void ExplorerBarAgent_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    try
        //    {
        //        var ebar = ((UltraExplorerBar)(sender));
        //        if (ebar.ActiveItem != null)
        //        {
        //            if (ebar.ActiveItem.Key.Equals("0000000000"))
        //                return;
        //            if (OnNumberSelect != null)
        //                OnNumberSelect(ebar.ActiveItem.Key);
        //            //textBox1.Text = ebar.ActiveItem.Key;
        //        }

        //    }
        //    catch (Exception exception)
        //    {
        //        Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "ExplorerBarAgent_MouseDoubleClick", exception, Logger.LogLevel.Error);
        //    }
        //}

       
    }
}
