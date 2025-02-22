namespace MusicPlayer
{
    partial class AddMusic
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMusic));
            this.FilePathTextbox = new System.Windows.Forms.TextBox();
            this.TitleTextbox = new System.Windows.Forms.TextBox();
            this.ArtistTextbox = new System.Windows.Forms.TextBox();
            this.AlbumTextbox = new System.Windows.Forms.TextBox();
            this.GenreTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilePathTextbox
            // 
            this.FilePathTextbox.Location = new System.Drawing.Point(97, 66);
            this.FilePathTextbox.Name = "FilePathTextbox";
            this.FilePathTextbox.ReadOnly = true;
            this.FilePathTextbox.Size = new System.Drawing.Size(200, 20);
            this.FilePathTextbox.TabIndex = 0;
            // 
            // TitleTextbox
            // 
            this.TitleTextbox.Location = new System.Drawing.Point(97, 96);
            this.TitleTextbox.Name = "TitleTextbox";
            this.TitleTextbox.ReadOnly = true;
            this.TitleTextbox.Size = new System.Drawing.Size(200, 20);
            this.TitleTextbox.TabIndex = 1;
            // 
            // ArtistTextbox
            // 
            this.ArtistTextbox.Location = new System.Drawing.Point(97, 126);
            this.ArtistTextbox.Name = "ArtistTextbox";
            this.ArtistTextbox.ReadOnly = true;
            this.ArtistTextbox.Size = new System.Drawing.Size(200, 20);
            this.ArtistTextbox.TabIndex = 2;
            // 
            // AlbumTextbox
            // 
            this.AlbumTextbox.Location = new System.Drawing.Point(97, 156);
            this.AlbumTextbox.Name = "AlbumTextbox";
            this.AlbumTextbox.ReadOnly = true;
            this.AlbumTextbox.Size = new System.Drawing.Size(200, 20);
            this.AlbumTextbox.TabIndex = 3;
            // 
            // GenreTextbox
            // 
            this.GenreTextbox.Location = new System.Drawing.Point(97, 186);
            this.GenreTextbox.Name = "GenreTextbox";
            this.GenreTextbox.ReadOnly = true;
            this.GenreTextbox.Size = new System.Drawing.Size(200, 20);
            this.GenreTextbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "File Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Artist";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Album";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Genre";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(307, 66);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 10;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(97, 216);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(307, 216);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Welcome Admin!";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(226, 216);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 14;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // AddMusic
            // 
            this.ClientSize = new System.Drawing.Size(400, 251);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GenreTextbox);
            this.Controls.Add(this.AlbumTextbox);
            this.Controls.Add(this.ArtistTextbox);
            this.Controls.Add(this.TitleTextbox);
            this.Controls.Add(this.FilePathTextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMusic";
            this.Text = "Add Music";
            this.Load += new System.EventHandler(this.AddMusic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox FilePathTextbox;
        private System.Windows.Forms.TextBox TitleTextbox;
        private System.Windows.Forms.TextBox ArtistTextbox;
        private System.Windows.Forms.TextBox AlbumTextbox;
        private System.Windows.Forms.TextBox GenreTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogoutButton;
    }
}
