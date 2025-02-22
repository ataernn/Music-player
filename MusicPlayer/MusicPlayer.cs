using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using NAudio.Wave;
using System.Timers;
using WMPLib;

namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;
        private System.Timers.Timer timer;

        public MusicPlayer()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.MusicPlayer_FormClosing);
            LoadMusicList();
            musicListView.SelectedIndexChanged += musicListView_SelectedIndexChanged;
            this.StartPosition = FormStartPosition.CenterScreen;

            timer = new System.Timers.Timer();
            timer.Interval = 500;
            timer.Elapsed += Timer_Elapsed;
        }

        private void MusicPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (audioFileReader != null)
            {
                Invoke(new Action(() =>
                {
                    label1.Text = $"{audioFileReader.CurrentTime:mm\\:ss} / {audioFileReader.TotalTime:mm\\:ss}";
                    DurationTrackbar.Value = (int)audioFileReader.CurrentTime.TotalSeconds;
                }));
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (musicListView.SelectedItems.Count > 0)
            {
                string filePath = musicListView.SelectedItems[0].Tag.ToString();
                PlayAudio(filePath);
                UpdateButtonStatus(false, true, true, true, true);
            }
            else
            {
                MessageBox.Show("No Music selected. Please select a Music.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            PauseAudio();
            UpdateButtonStatus(false, true, true, true, true);
        }
        
        private void StopButton_Click(object sender, EventArgs e)
        {
            StopAudio();
            UpdateButtonStatus(false, false, false, false, false);
        }

        private void DurationTrackbar_Scroll(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                TimeSpan currentTime = TimeSpan.FromSeconds(DurationTrackbar.Value);
                audioFileReader.CurrentTime = currentTime;
                label1.Text = $"{currentTime:mm\\:ss} / {audioFileReader.TotalTime:mm\\:ss}";
            }
        }

        private void PlayAudio(string filePath)
        {
            StopAudio();

            waveOutDevice = new WaveOut();
            audioFileReader = new AudioFileReader(filePath);
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
            DurationTrackbar.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;
            VolumeTrackbar.Value = VolumeTrackbar.Maximum;
            timer.Start();
            PauseButton.Text = "Pause";
        }

        private void PauseAudio()
        {
            if (waveOutDevice != null)
            {
                if (waveOutDevice.PlaybackState == PlaybackState.Playing)
                {
                    waveOutDevice.Pause();
                    timer.Stop();
                    PauseButton.Text = "Play";
                }
                else if (waveOutDevice.PlaybackState == PlaybackState.Paused)
                {
                    waveOutDevice.Play();
                    timer.Start();
                    PauseButton.Text = "Pause";
                }
            }
        }

        private void StopAudio()
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
                waveOutDevice.Dispose();
                waveOutDevice = null;
                audioFileReader.Dispose();
                audioFileReader = null;
                timer.Stop();
                label1.Text = "00:00 / 00:00";
                DurationTrackbar.Value = 0;
            }
        }

        private void LoadMusicList()
        {
            string connectionString = "Data Source=CANAT;Initial Catalog=MusicPlayer;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Title, Artist, Album, Genre, Duration, FilePath FROM Music";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["Title"].ToString());
                            item.SubItems.Add(reader["Artist"].ToString());
                            item.SubItems.Add(reader["Album"].ToString());
                            item.SubItems.Add(reader["Genre"].ToString());
                            item.SubItems.Add(TimeSpan.FromSeconds(Convert.ToInt32(reader["Duration"])).ToString(@"mm\:ss"));
                            item.Tag = reader["FilePath"].ToString();
                            musicListView.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void VolumeTrackbar_Scroll(object sender, EventArgs e)
        {
            int volume = VolumeTrackbar.Value;

            if (waveOutDevice != null)
            {
                waveOutDevice.Volume = (float)volume / 100f;
            }
        }

        private void UpdateButtonStatus(bool playEnabled, bool pauseEnabled, bool stopEnabled, bool durationEnabled, bool volumeEnabled)
        {
            PlayButton.Enabled = playEnabled;
            PauseButton.Enabled = pauseEnabled;
            StopButton.Enabled = stopEnabled;
            DurationTrackbar.Enabled = durationEnabled;
            VolumeTrackbar.Enabled = volumeEnabled;
        }

        private void musicListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayButton.Enabled = (musicListView.SelectedItems.Count > 0);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully logged out. Redirecting to Login...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}