using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DuoSoftware.DuoSoftPhone.Controllers.AgentStatus;
using DuoSoftware.DuoSoftPhone.Controllers.Service;
using UserAuth = DuoSoftware.DuoSoftPhone.refUserAuth.UserAuth;

namespace DuoSoftware.DuoSoftPhone.Ui
{
    public partial class frmPhoneConfig : Form
    {
        
        private UserAuth Auth;
        public frmPhoneConfig(UserAuth auth)
        {
            Auth = auth;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPhoneConfig_Load(object sender, EventArgs e)
        {
            var profile = AgentProfile.Instance;
            txtuserName.Text = profile.UserName;
            txtPassword.Text = profile.Password;
            txtDisolayName.Text = profile.displayName;
            txtauthName.Text = profile.authorizationName;
            txtlocalPort.Text = profile.settingObject["localPort"];
            txtserverPort.Text = profile.settingObject["sipServerPort"];
            txtHostName.Text = profile.server.domain;

        }
    }
}
