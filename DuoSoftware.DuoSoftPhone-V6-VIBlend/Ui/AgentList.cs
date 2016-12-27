using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using DuoSoftware.DuoSoftPhone.Controllers.AgentStatus;
using DuoSoftware.DuoSoftPhone.Controllers.Service;
using DuoSoftware.DuoTools.DuoLogger;

namespace DuoSoftware.DuoSoftPhone.Ui
{

    public delegate void AgentSelect(string extension);
    

    public partial class AgentList : Form
    {
        public event AgentSelect OnAgentSelected;
        public AgentList()
        {
            InitializeComponent();
        }

        private void vTreeOnline_AfterSelect(object sender, VIBlend.WinForms.Controls.vTreeViewEventArgs e)
        {
            try
            {
                if (OnAgentSelected != null)
                {
                    OnAgentSelected(e.Node.Value.ToString());
                }
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "grdAgentList_CellDoubleClick", exception, Logger.LogLevel.Error);
                
            }
            
        }


        private void grdAgentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex <= -1 || e.ColumnIndex <= -1) return;
                var extension = grdAgentList.Rows[e.RowIndex].Cells["Extension"].Value.ToString();
                if (OnAgentSelected != null)
                {
                    OnAgentSelected(extension);
                }
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "grdAgentList_CellDoubleClick", exception, Logger.LogLevel.Error);

            }
        }

        private void agentList_Load(object sender, EventArgs e)
        {
            try
            {
                grdAgentList.EnableHeadersVisualStyles = false;
                LoadData();
                
                //var currentAgentList = MonitorRestApiHandler.GetOnlineAgentList();
                //grdAgentList.DataSource = currentAgentList;


                //System.Timers.Timer aTimer = new System.Timers.Timer();
                //aTimer.Elapsed += (o, args) =>
                //{
                //    currentAgentList = MonitorRestApiHandler.GetOnlineAgentList();
                //    grdAgentList.Invoke(((MethodInvoker)(() =>
                //    {
                //        grdAgentList.DataSource = currentAgentList;
                //    })));
                //};
                //aTimer.Interval = 30000;
                //aTimer.Enabled = true;
                //aTimer.Start();
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "agentList_Load", exception, Logger.LogLevel.Error);
                
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                //var currentAgentList = MonitorRestApiHandler.GetOnlineAgentList();
                //grdAgentList.DataSource = currentAgentList;
                
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "btnReload_Click", exception, Logger.LogLevel.Error);

            }

        }

        private void LoadData()
        {
            try
            {
                var currentAgentList = MonitorRestApiHandler.GetOnlineAgentList();
                grdAgentList.DataSource = currentAgentList;
                grdAgentList.Columns["Extension"].Visible = false;
                //foreach (var onlineAgentList in currentAgentList)
                //{
                //    var vTreeNode = new VIBlend.WinForms.Controls.vTreeNode
                //    {
                //        ForeColor = System.Drawing.SystemColors.ControlText,
                //        HighlightForeColor = System.Drawing.SystemColors.ControlText,
                //        Parent = this.vTreeNodeOnline,
                //        RoundedCornersMask = ((byte) (15)),
                //        SelectedForeColor = System.Drawing.SystemColors.ControlText,
                //        Text = onlineAgentList.SipUsername,
                //        TooltipText = onlineAgentList.SipUsername,
                //        Value = onlineAgentList.Extension
                //    };
                //    vTreeNodeOnline.Nodes.Add(vTreeNode);
                //}
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "btnReload_Click", exception, Logger.LogLevel.Error);

            }

            
        }

        

       
        
    }

    
}
