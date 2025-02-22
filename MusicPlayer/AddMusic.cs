using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using TagLib;

namespace MusicPlayer
{
    public partial class AddMusic : Form
    {
        public AddMusic()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddMusic_FormClosing);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void AddMusic_Load(object sender, EventArgs e)
        {
            
        }

        private void AddMusic_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 Files|*.mp3|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePathTextbox.Text = openFileDialog.FileName;

                var file = TagLib.File.Create(openFileDialog.FileName);
                TitleTextbox.Text = file.Tag.Title;
                ArtistTextbox.Text = file.Tag.FirstPerformer;
                AlbumTextbox.Text = file.Tag.Album;
                GenreTextbox.Text = file.Tag.FirstGenre;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FilePathTextbox.Text) ||
                string.IsNullOrWhiteSpace(TitleTextbox.Text) ||
                string.IsNullOrWhiteSpace(ArtistTextbox.Text) ||
                string.IsNullOrWhiteSpace(AlbumTextbox.Text) ||
                string.IsNullOrWhiteSpace(GenreTextbox.Text))
            {
                MessageBox.Show("This Music does not contain any tag or a Music was not selected. \nPlease select a Music with a tag.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filePath = FilePathTextbox.Text;
            string title = TitleTextbox.Text;
            string artist = ArtistTextbox.Text;
            string album = AlbumTextbox.Text;
            string genre = GenreTextbox.Text;

            string connectionString = "Data Source=CANAT;Initial Catalog=MusicPlayer;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Music (Title, Artist, Album, Genre, FilePath, Duration) VALUES (@Title, @Artist, @Album, @Genre, @FilePath, @Duration)";

                    var file = TagLib.File.Create(filePath);
                    int durationInSeconds = (int)file.Properties.Duration.TotalSeconds;

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Artist", artist);
                        command.Parameters.AddWithValue("@Album", album);
                        command.Parameters.AddWithValue("@Genre", genre);
                        command.Parameters.AddWithValue("@FilePath", filePath);
                        command.Parameters.AddWithValue("@Duration", durationInSeconds);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Music added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            FilePathTextbox.Text = "";
            TitleTextbox.Text = "";
            ArtistTextbox.Text = "";
            AlbumTextbox.Text = "";
            GenreTextbox.Text = "";
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully logged out. Redirecting to Login...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
