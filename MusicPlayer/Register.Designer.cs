namespace MusicPlayer
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.Transparent;
            this.RegisterButton.Location = new System.Drawing.Point(281, 292);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(249, 49);
            this.RegisterButton.TabIndex = 0;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(713, 415);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(281, 58);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(249, 20);
            this.EmailTextBox.TabIndex = 2;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(281, 116);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(249, 20);
            this.NameTextbox.TabIndex = 3;
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(281, 177);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(249, 20);
            this.UsernameTextbox.TabIndex = 4;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(281, 235);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(249, 20);
            this.PasswordTextbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "E-mail";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(431, 361);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(99, 23);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Already have an Account?";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::MusicPlayer.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RegisterButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

