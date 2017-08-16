using DuoSoftware.DuoSoftPhone.Controllers.AgentStatus;
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
    public partial class frmPasswordChange : Form
    {
        Agent _agent;
        public frmPasswordChange(Agent agent)
        {
            InitializeComponent();
            _agent = agent;
        }

        private bool validateInputs()
        {
            try
            {
                
                if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(txtconfime.Text))
                {
                    var boxes = Controls.OfType<TextBox>();
                    foreach (var box in boxes)
                    {
                        if (string.IsNullOrWhiteSpace(box.Text))
                        {
                            errorProvider1.SetError(box, "Please fill the required field");
                        }
                    }
                    return false;
                }
                if (txtPassword.Text == txtNewPassword.Text)
                {
                    errorProvider1.SetError(txtNewPassword, "New Password Should Not Be Same As Old Password.");
                    mynotifyicon.ShowBalloonTip(1000, "FaceTone - Phone", "New Password Should Not Be Same As Old Password.", ToolTipIcon.Error);
                    return false;
                }
                if (txtNewPassword.Text != txtconfime.Text)
                {
                    errorProvider1.SetError(txtconfime, "Password Confirmation Doesn't Match.");
                    mynotifyicon.ShowBalloonTip(1000, "FaceTone - Phone", "Password Confirmation Doesn't Match.", ToolTipIcon.Error);
                    return false;
                }
                return true;
            }
            catch (System.Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "validateInputs", exception, Logger.LogLevel.Error);
                return false;
            }
        }

        private void btnPwdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (!validateInputs())
                {
                    return;
                }
               

                var isSuccess = _agent.Profile.UpdatePassword(txtPassword.Text.Trim(), txtNewPassword.Text.Trim());
                if (isSuccess)
                {
                    mynotifyicon.ShowBalloonTip(1000, "FaceTone - Phone", "Password Updated Successfully.", ToolTipIcon.Info);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fail To Update Password.", "FaceTone - Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mynotifyicon.ShowBalloonTip(1000, "FaceTone - Phone", "Fail To Update Password.", ToolTipIcon.Error);
                }
            }
            catch (System.Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "btnPwdUpdate_Click", exception, Logger.LogLevel.Error);
            }

            
        }
    }
}
