using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuoSoftware.DuoTools.DuoLogger;
using DuoSoftware.DuoSoftPhone.Controllers;
using PortSIP;

namespace DuoSoftware.DuoSoftPhone.Ui
{
    public partial class AudioWiz : Form
    {
        public delegate void AudioPlayLoopbackTest(bool value);
        public event AudioPlayLoopbackTest OnAudioPlayTest;
        
        public delegate void Volume(int value);
        public event Volume OnSpeakerVolumeChanged;
        public event Volume OnMicVolumeChanged;

        public delegate void Mute(bool value);
        public event Mute OnSpeakerMute;
        public event Mute OnMicMute;

        
        
        public AudioWiz( ComboBox  comboBoxMicrophones, ComboBox comboBoxSpeakers, int micVolume, int speakerVolume,int micIndex,int sepkIndex)
        {
            InitializeComponent();
            this.GroupBox3.Controls.Add(comboBoxMicrophones);
            this.GroupBox3.Controls.Add(comboBoxSpeakers);

            if (comboBoxMicrophones.Items.Count >= micIndex)
            {
                comboBoxMicrophones.SelectedIndex = micIndex;
            }

            if (comboBoxSpeakers.Items.Count >= sepkIndex)
            {
                comboBoxSpeakers.SelectedIndex = sepkIndex;
            }

            TrackBarSpeaker.SetRange(0, 255);
            TrackBarSpeaker.Value = speakerVolume;

            TrackBarMicrophone.SetRange(0, 255);
            TrackBarMicrophone.Value = micVolume;
        }
        
        

        private void AudioWiz_Load(object sender, EventArgs e)
        {
            try
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "AudioWiz Open", Logger.LogLevel.Info);

            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "AudioWiz_Load", exception, Logger.LogLevel.Error);
            }
        }
        
        private void ButtonTestAudio_Click(object sender, EventArgs e)
        {
            try
            {
                if (ButtonTestAudio.Text == "Test Audio")
                {
                    if (OnAudioPlayTest == null) return;
                    ButtonTestAudio.Text = "Stop Test";
                    OnAudioPlayTest(true);
                }
                else
                {
                    if (OnAudioPlayTest == null) return;
                    ButtonTestAudio.Text = "Test Audio";
                    OnAudioPlayTest(false);
                }
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "ButtonTestAudio_Click", exception, Logger.LogLevel.Error);
            }
        }

        private void TrackBarSpeaker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (OnSpeakerVolumeChanged == null) return;
                chkboxMuteSpeaker.Checked = false;
                OnSpeakerVolumeChanged(TrackBarSpeaker.Value);
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "ButtonTestAudio_Click", exception, Logger.LogLevel.Error);
            }
        }

        private void TrackBarMicrophone_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (OnMicVolumeChanged == null) return;
                CheckBoxMute.Checked = false;
                OnMicVolumeChanged(TrackBarMicrophone.Value);
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "TrackBarMicrophone_ValueChanged", exception, Logger.LogLevel.Error);
            }
        }


        private void CheckBoxMute_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (OnMicMute != null)
                {
                    OnMicMute(CheckBoxMute.Checked);
                }
                
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "AudioWiz MuteMicrophone - " + CheckBoxMute.Checked, Logger.LogLevel.Info);
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "CheckBoxMute_CheckedChanged", exception, Logger.LogLevel.Error);
            }
        }

        private void chkboxMuteSpeaker_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (OnSpeakerMute != null)
                {
                    OnSpeakerMute(chkboxMuteSpeaker.Checked);
                }
                
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "AudioWiz MuteSpeaker - " + chkboxMuteSpeaker.Checked, Logger.LogLevel.Info);
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "chkboxMuteSpeaker_CheckedChanged", exception, Logger.LogLevel.Error);
            }
        }

        private void AudioWiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "AudioWiz Close", Logger.LogLevel.Info);
        }


    }
}
