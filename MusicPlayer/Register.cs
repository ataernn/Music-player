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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            PasswordTextbox.PasswordChar = '*';
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                string.IsNullOrWhiteSpace(NameTextbox.Text) ||
                string.IsNullOrWhiteSpace(UsernameTextbox.Text) ||
                string.IsNullOrWhiteSpace(PasswordTextbox.Text))
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

                    string salt = SaltedHash.GenerateSalt();
                    string hashedPassword = SaltedHash.HashPassword(PasswordTextbox.Text, salt);

                    string query = "INSERT INTO Accounts (email, name, username, password, salt) VALUES (@Email, @Name, @Username, @Password, @Salt)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                        command.Parameters.AddWithValue("@Name", NameTextbox.Text);
                        command.Parameters.AddWithValue("@Username", UsernameTextbox.Text);
                        command.Parameters.AddWithValue("@Password", hashedPassword);
                        command.Parameters.AddWithValue("@Salt", salt);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {   
                            MessageBox.Show("Registration Successful! Redirecting to Login.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Login loginForm = new Login();
                            loginForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Cannot connect to server, please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
