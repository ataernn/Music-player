namespace MusicPlayer
{
    partial class MusicPlayer
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.ListView musicListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar DurationTrackbar;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnArtist;
        private System.Windows.Forms.ColumnHeader columnAlbum;
        private System.Windows.Forms.ColumnHeader columnGenre;
        private System.Windows.Forms.ColumnHeader columnDuration;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.PlayButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.musicListView = new System.Windows.Forms.ListView();
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.DurationTrackbar = new System.Windows.Forms.TrackBar();
            this.VolumeTrackbar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DurationTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(15, 425);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(217, 52);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Select and Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Enabled = false;
            this.PauseButton.Location = new System.Drawing.Point(296, 425);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(217, 52);
            this.PauseButton.TabIndex = 1;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(555, 425);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(217, 52);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // musicListView
            // 
            this.musicListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTitle,
            this.columnArtist,
            this.columnAlbum,
            this.columnGenre,
            this.columnDuration});
            this.musicListView.HideSelection = false;
            this.musicListView.Location = new System.Drawing.Point(12, 12);
            this.musicListView.Name = "musicListView";
            this.musicListView.Size = new System.Drawing.Size(760, 407);
            this.musicListView.TabIndex = 3;
            this.musicListView.UseCompatibleStateImageBehavior = false;
            this.musicListView.View = System.Windows.Forms.View.Details;
            this.musicListView.SelectedIndexChanged += new System.EventHandler(this.musicListView_SelectedIndexChanged);
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Title";
            this.columnTitle.Width = 150;
            // 
            // columnArtist
            // 
            this.columnArtist.Text = "Artist";
            this.columnArtist.Width = 150;
            // 
            // columnAlbum
            // 
            this.columnAlbum.Text = "Album";
            this.columnAlbum.Width = 150;
            // 
            // columnGenre
            // 
            this.columnGenre.Text = "Genre";
            this.columnGenre.Width = 150;
            // 
            // columnDuration
            // 
            this.columnDuration.Text = "Duration";
            this.columnDuration.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "00:00 / 00:00";
            // 
            // DurationTrackbar
            // 
            this.DurationTrackbar.Enabled = false;
            this.DurationTrackbar.Location = new System.Drawing.Point(12, 506);
            this.DurationTrackbar.Name = "DurationTrackbar";
            this.DurationTrackbar.Size = new System.Drawing.Size(596, 45);
            this.DurationTrackbar.TabIndex = 5;
            this.DurationTrackbar.Scroll += new System.EventHandler(this.DurationTrackbar_Scroll);
            // 
            // VolumeTrackbar
            // 
            this.VolumeTrackbar.Enabled = false;
            this.VolumeTrackbar.Location = new System.Drawing.Point(614, 506);
            this.VolumeTrackbar.Name = "VolumeTrackbar";
            this.VolumeTrackbar.Size = new System.Drawing.Size(158, 45);
            this.VolumeTrackbar.TabIndex = 6;
            this.VolumeTrackbar.Scroll += new System.EventHandler(this.VolumeTrackbar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Volume";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(614, 548);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 8;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(697, 548);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 583);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VolumeTrackbar);
            this.Controls.Add(this.DurationTrackbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.musicListView);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PlayButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusicPlayer";
            this.Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.DurationTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TrackBar VolumeTrackbar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button ExitButton;
    }
}
