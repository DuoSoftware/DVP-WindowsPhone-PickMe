namespace DuoSoftware.DuoSoftPhone.Ui
{
    partial class frmPreviewMessage
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
            this.txtPreviewMessage = new System.Windows.Forms.TextBox();
            this.vGroupBox1 = new VIBlend.WinForms.Controls.vGroupBox();
            this.btnAccepted = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.phoner8ClickMenu = new VIBlend.WinForms.Controls.vContextMenu();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItemAnswerCall = new System.Windows.Forms.MenuItem();
            this.menuItemRejectCall = new System.Windows.Forms.MenuItem();
            this.Countdown_timer = new System.Windows.Forms.Timer(this.components);
            this.txtTimer = new System.Windows.Forms.Label();
            this.vGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPreviewMessage
            // 
            this.txtPreviewMessage.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtPreviewMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreviewMessage.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreviewMessage.ForeColor = System.Drawing.Color.Gray;
            this.txtPreviewMessage.Location = new System.Drawing.Point(11, 85);
            this.txtPreviewMessage.Margin = new System.Windows.Forms.Padding(5);
            this.txtPreviewMessage.Multiline = true;
            this.txtPreviewMessage.Name = "txtPreviewMessage";
            this.txtPreviewMessage.Size = new System.Drawing.Size(272, 20);
            this.txtPreviewMessage.TabIndex = 24;
            this.txtPreviewMessage.Text = "Name : Duo ";
            this.txtPreviewMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPreviewMessage.TextChanged += new System.EventHandler(this.txtPreviewMessage_TextChanged);
            // 
            // vGroupBox1
            // 
            this.vGroupBox1.BackColor = System.Drawing.Color.Black;
            this.vGroupBox1.Controls.Add(this.txtTimer);
            this.vGroupBox1.Controls.Add(this.btnAccepted);
            this.vGroupBox1.Controls.Add(this.btnReject);
            this.vGroupBox1.Controls.Add(this.txtPreviewMessage);
            this.vGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGroupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vGroupBox1.ForeColor = System.Drawing.Color.Red;
            this.vGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.vGroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.vGroupBox1.Name = "vGroupBox1";
            this.vGroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.vGroupBox1.Size = new System.Drawing.Size(296, 153);
            this.vGroupBox1.TabIndex = 1;
            this.vGroupBox1.TabStop = false;
            this.vGroupBox1.Text = "You Are Allocated To Campaign Call";
            this.vGroupBox1.TitleBackColor = System.Drawing.Color.Black;
            this.vGroupBox1.UseThemeBorderColor = true;
            this.vGroupBox1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // btnAccepted
            // 
            this.btnAccepted.ForeColor = System.Drawing.Color.Black;
            this.btnAccepted.Location = new System.Drawing.Point(159, 110);
            this.btnAccepted.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccepted.Name = "btnAccepted";
            this.btnAccepted.Size = new System.Drawing.Size(121, 28);
            this.btnAccepted.TabIndex = 47;
            this.btnAccepted.Text = "Accepted";
            this.btnAccepted.UseVisualStyleBackColor = true;
            this.btnAccepted.Click += new System.EventHandler(this.btnAccepted_Click);
            // 
            // btnReject
            // 
            this.btnReject.ForeColor = System.Drawing.Color.Black;
            this.btnReject.Location = new System.Drawing.Point(13, 110);
            this.btnReject.Margin = new System.Windows.Forms.Padding(4);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(121, 28);
            this.btnReject.TabIndex = 46;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
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
            this.menuItemAnswerCall.Shortcut = System.Windows.Forms.Shortcut.F12;
            this.menuItemAnswerCall.Text = "Reject";
            // 
            // menuItemRejectCall
            // 
            this.menuItemRejectCall.Index = 1;
            this.menuItemRejectCall.Shortcut = System.Windows.Forms.Shortcut.F2;
            this.menuItemRejectCall.Text = "Accept";
            // 
            // txtTimer
            // 
            this.txtTimer.AutoSize = true;
            this.txtTimer.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.ForeColor = System.Drawing.Color.Green;
            this.txtTimer.Location = new System.Drawing.Point(82, 22);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(150, 63);
            this.txtTimer.TabIndex = 48;
            this.txtTimer.Text = "00:00";
            this.txtTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPreviewMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 153);
            this.Controls.Add(this.vGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPreviewMessage";
            this.Text = "frmPreviewMessage";
            this.Load += new System.EventHandler(this.frmIncomingCall_Load);
            this.vGroupBox1.ResumeLayout(false);
            this.vGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPreviewMessage;
        private VIBlend.WinForms.Controls.vGroupBox vGroupBox1;
        private System.Windows.Forms.Button btnAccepted;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Timer timer1;
        private VIBlend.WinForms.Controls.vContextMenu phoner8ClickMenu;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItemAnswerCall;
        private System.Windows.Forms.MenuItem menuItemRejectCall;
        private System.Windows.Forms.Timer Countdown_timer;
        private System.Windows.Forms.Label txtTimer;
    }
}