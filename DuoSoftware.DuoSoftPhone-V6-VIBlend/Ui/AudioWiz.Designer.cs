namespace DuoSoftware.DuoSoftPhone.Ui
{
    partial class AudioWiz
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
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.chkboxMuteSpeaker = new System.Windows.Forms.CheckBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.CheckBoxMute = new System.Windows.Forms.CheckBox();
            this.ButtonTestAudio = new System.Windows.Forms.Button();
            this.TrackBarMicrophone = new System.Windows.Forms.TrackBar();
            this.Label11 = new System.Windows.Forms.Label();
            this.TrackBarSpeaker = new System.Windows.Forms.TrackBar();
            this.Label10 = new System.Windows.Forms.Label();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarMicrophone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSpeaker)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.Color.Black;
            this.GroupBox3.Controls.Add(this.chkboxMuteSpeaker);
            this.GroupBox3.Controls.Add(this.Label12);
            this.GroupBox3.Controls.Add(this.Label13);
            this.GroupBox3.Controls.Add(this.CheckBoxMute);
            this.GroupBox3.Controls.Add(this.ButtonTestAudio);
            this.GroupBox3.Controls.Add(this.TrackBarMicrophone);
            this.GroupBox3.Controls.Add(this.Label11);
            this.GroupBox3.Controls.Add(this.TrackBarSpeaker);
            this.GroupBox3.Controls.Add(this.Label10);
            this.GroupBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.ForeColor = System.Drawing.Color.White;
            this.GroupBox3.Location = new System.Drawing.Point(10, 9);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(423, 146);
            this.GroupBox3.TabIndex = 47;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Volume";
            // 
            // chkboxMuteSpeaker
            // 
            this.chkboxMuteSpeaker.AutoSize = true;
            this.chkboxMuteSpeaker.Location = new System.Drawing.Point(296, 73);
            this.chkboxMuteSpeaker.Name = "chkboxMuteSpeaker";
            this.chkboxMuteSpeaker.Size = new System.Drawing.Size(100, 19);
            this.chkboxMuteSpeaker.TabIndex = 50;
            this.chkboxMuteSpeaker.Text = "Mute Speaker";
            this.chkboxMuteSpeaker.UseVisualStyleBackColor = true;
            this.chkboxMuteSpeaker.CheckedChanged += new System.EventHandler(this.chkboxMuteSpeaker_CheckedChanged);
            
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(12, 46);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(74, 15);
            this.Label12.TabIndex = 47;
            this.Label12.Text = "Microphone";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(12, 20);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(50, 15);
            this.Label13.TabIndex = 46;
            this.Label13.Text = "Speaker";
            // 
            // CheckBoxMute
            // 
            this.CheckBoxMute.AutoSize = true;
            this.CheckBoxMute.Location = new System.Drawing.Point(296, 98);
            this.CheckBoxMute.Name = "CheckBoxMute";
            this.CheckBoxMute.Size = new System.Drawing.Size(123, 19);
            this.CheckBoxMute.TabIndex = 45;
            this.CheckBoxMute.Text = "Mute microphone";
            this.CheckBoxMute.UseVisualStyleBackColor = true;
            this.CheckBoxMute.CheckedChanged += new System.EventHandler(this.CheckBoxMute_CheckedChanged);
            // 
            // ButtonTestAudio
            // 
            this.ButtonTestAudio.BackColor = System.Drawing.Color.Gray;
            this.ButtonTestAudio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTestAudio.ForeColor = System.Drawing.Color.Navy;
            this.ButtonTestAudio.Location = new System.Drawing.Point(308, 118);
            this.ButtonTestAudio.Name = "ButtonTestAudio";
            this.ButtonTestAudio.Size = new System.Drawing.Size(107, 23);
            this.ButtonTestAudio.TabIndex = 41;
            this.ButtonTestAudio.Text = "Test Audio";
            this.ButtonTestAudio.UseVisualStyleBackColor = false;
            this.ButtonTestAudio.Click += new System.EventHandler(this.ButtonTestAudio_Click);
            // 
            // TrackBarMicrophone
            // 
            this.TrackBarMicrophone.Location = new System.Drawing.Point(81, 99);
            this.TrackBarMicrophone.Maximum = 65535;
            this.TrackBarMicrophone.Name = "TrackBarMicrophone";
            this.TrackBarMicrophone.Size = new System.Drawing.Size(214, 45);
            this.TrackBarMicrophone.TabIndex = 3;
            this.TrackBarMicrophone.TickFrequency = 1000;
            this.TrackBarMicrophone.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBarMicrophone.ValueChanged += new System.EventHandler(this.TrackBarMicrophone_ValueChanged);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(12, 98);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(74, 15);
            this.Label11.TabIndex = 2;
            this.Label11.Text = "Microphone";
            // 
            // TrackBarSpeaker
            // 
            this.TrackBarSpeaker.Location = new System.Drawing.Point(81, 71);
            this.TrackBarSpeaker.Maximum = 65535;
            this.TrackBarSpeaker.Name = "TrackBarSpeaker";
            this.TrackBarSpeaker.Size = new System.Drawing.Size(214, 45);
            this.TrackBarSpeaker.TabIndex = 1;
            this.TrackBarSpeaker.TickFrequency = 1000;
            this.TrackBarSpeaker.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBarSpeaker.ValueChanged += new System.EventHandler(this.TrackBarSpeaker_ValueChanged);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(12, 72);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(50, 15);
            this.Label10.TabIndex = 0;
            this.Label10.Text = "Speaker";
            // 
            // AudioWiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(442, 165);
            this.Controls.Add(this.GroupBox3);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AudioWiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AudioWiz";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AudioWiz_FormClosed);
            this.Load += new System.EventHandler(this.AudioWiz_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarMicrophone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSpeaker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.CheckBox CheckBoxMute;
        internal System.Windows.Forms.Button ButtonTestAudio;
        internal System.Windows.Forms.TrackBar TrackBarMicrophone;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TrackBar TrackBarSpeaker;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.CheckBox chkboxMuteSpeaker;
    }
}