namespace DuoSoftware.DuoSoftPhone.Ui
{
    partial class frmCallLogs
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem ultraExplorerBarItem1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.EBarCallInfo = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EBarCallInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // EBarCallInfo
            // 
            this.EBarCallInfo.AcceptsFocus = Infragistics.Win.DefaultableBoolean.True;
            appearance1.BackColor = System.Drawing.Color.Black;
            appearance1.BackColor2 = System.Drawing.Color.Gray;
            appearance1.ForeColor = System.Drawing.Color.White;
            this.EBarCallInfo.Appearance = appearance1;
            this.EBarCallInfo.AutoScrollStyle = Infragistics.Win.UltraWinExplorerBar.AutoScrollStyle.BringActiveControlIntoView;
            this.EBarCallInfo.BorderStyle = Infragistics.Win.UIElementBorderStyle.TwoColor;
            this.EBarCallInfo.ColumnSpacing = 0;
            this.EBarCallInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EBarCallInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EBarCallInfo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ultraExplorerBarItem1.Key = "0000000000";
            appearance2.Image = global::DuoSoftware.DuoSoftPhone.Properties.Resources.info;
            appearance2.TextHAlignAsString = "Left";
            appearance2.TextTrimming = Infragistics.Win.TextTrimming.Word;
            appearance2.TextVAlignAsString = "Middle";
            ultraExplorerBarItem1.Settings.AppearancesSmall.Appearance = appearance2;
            ultraExplorerBarItem1.Text = "     Number    -   Duration[s]    -   Time   -    Skill";
            ultraExplorerBarGroup1.Items.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem[] {
            ultraExplorerBarItem1});
            ultraExplorerBarGroup1.ItemSettings.AllowDragCopy = Infragistics.Win.UltraWinExplorerBar.ItemDragStyle.None;
            ultraExplorerBarGroup1.ItemSettings.AllowDragMove = Infragistics.Win.UltraWinExplorerBar.ItemDragStyle.None;
            ultraExplorerBarGroup1.ItemSettings.AllowEdit = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.ItemSettings.SeparatorStyle = Infragistics.Win.UltraWinExplorerBar.SeparatorStyle.Vertical;
            ultraExplorerBarGroup1.ItemSettings.ShowInkButton = Infragistics.Win.ShowInkButton.Never;
            ultraExplorerBarGroup1.ItemSettings.ShowToolTips = Infragistics.Win.DefaultableBoolean.True;
            ultraExplorerBarGroup1.ItemSettings.Style = Infragistics.Win.UltraWinExplorerBar.ItemStyle.Button;
            ultraExplorerBarGroup1.Key = "CallLogs";
            ultraExplorerBarGroup1.Settings.AllowDrag = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.AllowEdit = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.AllowItemDrop = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.AllowItemUncheck = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.ItemSort = Infragistics.Win.UltraWinExplorerBar.ItemSortType.None;
            ultraExplorerBarGroup1.Text = "Call Logs";
            this.EBarCallInfo.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1});
            this.EBarCallInfo.GroupSettings.AllowDrag = Infragistics.Win.DefaultableBoolean.False;
            this.EBarCallInfo.GroupSettings.AllowEdit = Infragistics.Win.DefaultableBoolean.False;
            this.EBarCallInfo.GroupSettings.AllowItemDrop = Infragistics.Win.DefaultableBoolean.False;
            this.EBarCallInfo.GroupSettings.AllowItemUncheck = Infragistics.Win.DefaultableBoolean.False;
            this.EBarCallInfo.GroupSettings.BorderStyleItemArea = Infragistics.Win.UIElementBorderStyle.Inset;
            this.EBarCallInfo.GroupSettings.ShowToolTips = Infragistics.Win.DefaultableBoolean.True;
            this.EBarCallInfo.GroupSettings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.SmallImagesWithText;
            this.EBarCallInfo.GroupSpacing = 0;
            this.EBarCallInfo.ItemSettings.AllowDragCopy = Infragistics.Win.UltraWinExplorerBar.ItemDragStyle.None;
            this.EBarCallInfo.ItemSettings.AllowDragMove = Infragistics.Win.UltraWinExplorerBar.ItemDragStyle.None;
            this.EBarCallInfo.ItemSettings.AllowEdit = Infragistics.Win.DefaultableBoolean.False;
            this.EBarCallInfo.ItemSettings.Height = 18;
            this.EBarCallInfo.ItemSettings.Indent = 0;
            this.EBarCallInfo.ItemSettings.MaxLines = 1;
            this.EBarCallInfo.Location = new System.Drawing.Point(0, 0);
            this.EBarCallInfo.Margin = new System.Windows.Forms.Padding(2);
            this.EBarCallInfo.Margins.Bottom = 12;
            this.EBarCallInfo.Margins.Left = 12;
            this.EBarCallInfo.Margins.Right = 12;
            this.EBarCallInfo.Margins.Top = 12;
            this.EBarCallInfo.Name = "EBarCallInfo";
            this.EBarCallInfo.ShowDefaultContextMenu = false;
            this.EBarCallInfo.Size = new System.Drawing.Size(318, 379);
            this.EBarCallInfo.TabIndex = 130;
            this.EBarCallInfo.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.EBarCallInfo.ViewStyle = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarViewStyle.Office2007;
            this.EBarCallInfo.ItemClick += new Infragistics.Win.UltraWinExplorerBar.ItemClickEventHandler(this.EBarCallInfo_ItemDoubleClick);
            this.EBarCallInfo.ItemRemoving += new Infragistics.Win.UltraWinExplorerBar.ItemRemovingEventHandler(this.ExplorerBarAgent_ItemRemoving);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 131;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 133;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(21, 86);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(216, 146);
            this.ultraExplorerBarContainerControl1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::DuoSoftware.DuoSoftPhone.Properties.Resources.ico_move;
            this.pictureBox1.Location = new System.Drawing.Point(254, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 135;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnClose.Image = global::DuoSoftware.DuoSoftPhone.Properties.Resources.CloseLog;
            this.btnClose.Location = new System.Drawing.Point(276, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 19);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 134;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCallLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(318, 379);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.EBarCallInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCallLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.EBarCallInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar EBarCallInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox btnClose;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}