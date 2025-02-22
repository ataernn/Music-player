using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            PasswordTextbox.PasswordChar = '*';
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTextbox.Text) || string.IsNullOrWhiteSpace(PasswordTextbox.Text))
            {
                MessageBox.Show("Please fill all blank fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=CANAT;Initial Catalog=MusicPlayer;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Role, Password, Salt FROM Accounts WHERE Username = @Username";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", UsernameTextbox.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["Role"].ToString();
                                string storedHash = reader["Password"].ToString();
                                string storedSalt = reader["Salt"].ToString();

                                if (SaltedHash.VerifyPassword(PasswordTextbox.Text, storedHash, storedSalt))
                                {
                                    MessageBox.Show("Succesfully logged in!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (role == "Admin")
                                    {
                                        AddMusic addMusicForm = new AddMusic();
                                        addMusicForm.Show();
                                    }
                                    else
                                    {
                                        MusicPlayer musicplayerForm = new MusicPlayer();
                                        musicplayerForm.Show();
                                    }
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Cannot connect to server, please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }
    }
}
