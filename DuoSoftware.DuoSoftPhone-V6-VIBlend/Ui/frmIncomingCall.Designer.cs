namespace DuoSoftware.DuoSoftPhone.Ui
{
    partial class frmIncomingCall
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.vGroupBox1 = new VIBlend.WinForms.Controls.vGroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.phoner8ClickMenu = new VIBlend.WinForms.Controls.vContextMenu();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItemAnswerCall = new System.Windows.Forms.MenuItem();
            this.menuItemRejectCall = new System.Windows.Forms.MenuItem();
            this.buttonReject = new VIBlend.WinForms.Controls.vButton();
            this.buttonAnswer = new VIBlend.WinForms.Controls.vButton();
            this.vGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vGroupBox1
            // 
            this.vGroupBox1.BackColor = System.Drawing.Color.Black;
            this.vGroupBox1.Controls.Add(this.buttonReject);
            this.vGroupBox1.Controls.Add(this.buttonAnswer);
            this.vGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGroupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vGroupBox1.ForeColor = System.Drawing.Color.White;
            this.vGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.vGroupBox1.Name = "vGroupBox1";
            this.vGroupBox1.Size = new System.Drawing.Size(209, 74);
            this.vGroupBox1.TabIndex = 0;
            this.vGroupBox1.TabStop = false;
            this.vGroupBox1.Text = "Incoming Call";
            this.vGroupBox1.TitleBackColor = System.Drawing.Color.Black;
            this.vGroupBox1.UseThemeBorderColor = true;
            this.vGroupBox1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // phoner8ClickMenu
            // 
            this.phoner8ClickMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2});
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemAnswerCall,
            this.menuItemRejectCall});
            this.menuItem2.Text = "Call";
            this.menuItem2.Visible = false;
            // 
            // menuItemAnswerCall
            // 
            this.menuItemAnswerCall.Index = 0;
            this.menuItemAnswerCall.Shortcut = System.Windows.Forms.Shortcut.F2;
            this.menuItemAnswerCall.Text = "AnswerCall";
            this.menuItemAnswerCall.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // menuItemRejectCall
            // 
            this.menuItemRejectCall.Index = 1;
            this.menuItemRejectCall.Shortcut = System.Windows.Forms.Shortcut.F12;
            this.menuItemRejectCall.Text = "RejectCall";
            this.menuItemRejectCall.Click += new System.EventHandler(this.buttonReject_Click);
            // 
            // buttonReject
            // 
            this.buttonReject.AllowAnimations = true;
            this.buttonReject.BackColor = System.Drawing.Color.Transparent;
            this.buttonReject.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReject.Image = global::DuoSoftware.DuoSoftPhone.Properties.Resources.EndCallM;
            this.buttonReject.Location = new System.Drawing.Point(107, 17);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.RoundedCornersMask = ((byte)(15));
            this.buttonReject.Size = new System.Drawing.Size(93, 42);
            this.buttonReject.TabIndex = 23;
            this.buttonReject.UseVisualStyleBackColor = false;
            this.buttonReject.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.buttonReject.Click += new System.EventHandler(this.buttonReject_Click);
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.AllowAnimations = true;
            this.buttonAnswer.BackColor = System.Drawing.Color.Transparent;
            this.buttonAnswer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnswer.Image = global::DuoSoftware.DuoSoftPhone.Properties.Resources.AnswerM;
            this.buttonAnswer.Location = new System.Drawing.Point(8, 17);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.RoundedCornersMask = ((byte)(15));
            this.buttonAnswer.Size = new System.Drawing.Size(93, 42);
            this.buttonAnswer.TabIndex = 22;
            this.buttonAnswer.UseVisualStyleBackColor = false;
            this.buttonAnswer.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // frmIncomingCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(209, 74);
            this.ControlBox = false;
            this.Controls.Add(this.vGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIncomingCall";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incoming Call";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmIncomingCall_Load);
            this.vGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private VIBlend.WinForms.Controls.vGroupBox vGroupBox1;
        private VIBlend.WinForms.Controls.vButton buttonAnswer;
        private VIBlend.WinForms.Controls.vButton buttonReject;
        private System.Windows.Forms.Timer timer1;
        private VIBlend.WinForms.Controls.vContextMenu phoner8ClickMenu;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItemAnswerCall;
        private System.Windows.Forms.MenuItem menuItemRejectCall;


    }
}