using DuoSoftware.DuoSoftPhone.Controllers;
using DuoSoftware.DuoTools.DuoLogger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuoSoftware.DuoSoftPhone.Ui
{
    public partial class AgentProductivity : Form
    {
        public AgentProductivity()
        {
            InitializeComponent();
        }

        private void AgentProductivity_Load(object sender, EventArgs e)
        {
            fillChart();
        }

        //fillChart method  
        private void fillChart()
        {
            try
            {
               

                var data = AgentProductivityHandler.GetAgentProductivity();
                if (data.IsSuccess)
                {
                    chart1.Series["PRODUCTIVITY"].Points.AddXY("ACW",TimeSpan.FromSeconds(data.Result.AcwTime).TotalHours);
                    chart1.Series["PRODUCTIVITY"].Points.AddXY("Break", TimeSpan.FromSeconds(data.Result.BreakTime).TotalHours);
                    chart1.Series["PRODUCTIVITY"].Points.AddXY("InCall", TimeSpan.FromSeconds(data.Result.OnCallTime).TotalHours);
                    chart1.Series["PRODUCTIVITY"].Points.AddXY("OutCall", TimeSpan.FromSeconds(data.Result.OutboundCallTime).TotalHours);
                    chart1.Series["PRODUCTIVITY"].Points.AddXY("Idle", TimeSpan.FromSeconds(data.Result.IdleTime).TotalHours);
                    chart1.Series["PRODUCTIVITY"].Points.AddXY("Hold", TimeSpan.FromSeconds(data.Result.HoldTime).TotalHours);

                    TimeSpan time = TimeSpan.FromSeconds(data.Result.StaffedTime);
                    lblstaffedtime.Text = time.ToString(@"hh\:mm\:ss");

                    time = TimeSpan.FromSeconds(data.Result.OnCallTime);
                    lbloutcalltime.Text = time.ToString(@"hh\:mm\:ss");

                    time = TimeSpan.FromSeconds(data.Result.BreakTime);
                    lblbreaktime.Text = time.ToString(@"hh\:mm\:ss");

                    time = TimeSpan.FromSeconds(data.Result.OutboundCallTime);
                    lbloutcalltime.Text = time.ToString(@"hh\:mm\:ss");

                    time = TimeSpan.FromSeconds(data.Result.OnCallTime);
                    lblincalltime.Text = time.ToString(@"hh\:mm\:ss");

                    lbloutcallcount.Text = data.Result.OutgoingCallCount.ToString();

                    lblmissedcall.Text = data.Result.MissCallCount.ToString();

                    lblinboundcallcount.Text = data.Result.IncomingCallCount.ToString();
                }
                else
                {
                    chart1.Series["PRODUCTIVITY"].Points.AddXY("ACW", 0);
                    chart1.Series["PRODUCTIVITY"].Points.AddXY("Break", 0);
                    chart1.Series["PRODUCTIVITY"].Points.AddXY("InCall", 0);
                    chart1.Series["PRODUCTIVITY"].Points.AddXY("OutCall", 0);
                    chart1.Series["PRODUCTIVITY"].Points.AddXY("Idle", 0);
                    chart1.Series["PRODUCTIVITY"].Points.AddXY("Hold", 0);
                }
                //chart title  
                chart1.Titles.Add("PRODUCTIVITY - HOURS");
                
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "fillChart", exception, Logger.LogLevel.Error);
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void AgentProductivity_MouseDown(object sender, MouseEventArgs e)
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
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "AgentProductivity_MouseDown", exception, Logger.LogLevel.Error);
            }
            
        }

        
    }
}
