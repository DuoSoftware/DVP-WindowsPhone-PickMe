namespace DuoSoftware.DuoSoftPhone.Ui
{
    partial class AgentList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Reload = new VIBlend.WinForms.Controls.vButton();
            this.grdAgentList = new System.Windows.Forms.DataGridView();
            this.vPanel1 = new VIBlend.WinForms.Controls.vPanel();
            this.SipUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgentList)).BeginInit();
            this.vPanel1.Content.SuspendLayout();
            this.vPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reload
            // 
            this.Reload.AllowAnimations = true;
            this.Reload.BackColor = System.Drawing.Color.Transparent;
            this.Reload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Reload.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reload.Location = new System.Drawing.Point(0, 331);
            this.Reload.Name = "Reload";
            this.Reload.RoundedCornersMask = ((byte)(15));
            this.Reload.Size = new System.Drawing.Size(189, 25);
            this.Reload.TabIndex = 34;
            this.Reload.Text = "Reload";
            this.Reload.UseVisualStyleBackColor = false;
            this.Reload.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.Reload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // grdAgentList
            // 
            this.grdAgentList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAgentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAgentList.ColumnHeadersHeight = 30;
            this.grdAgentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdAgentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SipUsername,
            this.Extension});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAgentList.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdAgentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAgentList.Location = new System.Drawing.Point(0, 0);
            this.grdAgentList.MultiSelect = false;
            this.grdAgentList.Name = "grdAgentList";
            this.grdAgentList.ReadOnly = true;
            this.grdAgentList.RowHeadersVisible = false;
            this.grdAgentList.Size = new System.Drawing.Size(189, 331);
            this.grdAgentList.TabIndex = 35;
            this.grdAgentList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAgentList_CellDoubleClick);
            // 
            // vPanel1
            // 
            this.vPanel1.AllowAnimations = true;
            this.vPanel1.BorderRadius = 0;
            // 
            // vPanel1.Content
            // 
            this.vPanel1.Content.AutoScroll = true;
            this.vPanel1.Content.BackColor = System.Drawing.SystemColors.Control;
            this.vPanel1.Content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vPanel1.Content.Controls.Add(this.grdAgentList);
            this.vPanel1.Content.Controls.Add(this.Reload);
            this.vPanel1.Content.Location = new System.Drawing.Point(1, 1);
            this.vPanel1.Content.Name = "Content";
            this.vPanel1.Content.Size = new System.Drawing.Size(191, 358);
            this.vPanel1.Content.TabIndex = 3;
            this.vPanel1.CustomScrollersIntersectionColor = System.Drawing.Color.Empty;
            this.vPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vPanel1.Location = new System.Drawing.Point(0, 0);
            this.vPanel1.Name = "vPanel1";
            this.vPanel1.Opacity = 1F;
            this.vPanel1.PanelBorderColor = System.Drawing.Color.Transparent;
            this.vPanel1.Size = new System.Drawing.Size(193, 360);
            this.vPanel1.TabIndex = 37;
            this.vPanel1.Text = "vPanel1";
            this.vPanel1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.OFFICE2003BLUE;
            // 
            // SipUsername
            // 
            this.SipUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SipUsername.DataPropertyName = "SipUsername";
            this.SipUsername.HeaderText = "Name";
            this.SipUsername.Name = "SipUsername";
            this.SipUsername.ReadOnly = true;
            this.SipUsername.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Extension
            // 
            this.Extension.DataPropertyName = "Extension";
            this.Extension.HeaderText = "Extension";
            this.Extension.Name = "Extension";
            this.Extension.ReadOnly = true;
            this.Extension.Visible = false;
            // 
            // AgentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 360);
            this.Controls.Add(this.vPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AgentList";
            this.Text = "Agent List";
            this.Load += new System.EventHandler(this.agentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAgentList)).EndInit();
            this.vPanel1.Content.ResumeLayout(false);
            this.vPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private VIBlend.WinForms.Controls.vButton Reload;
        private System.Windows.Forms.DataGridView grdAgentList;
        private VIBlend.WinForms.Controls.vPanel vPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SipUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension;

    }
}