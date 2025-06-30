namespace PasswordManager_WinForms
{
    partial class About
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            btnMeow = new Button();
            btnBack = new Button();
            btnInst = new Button();
            btnGitHub = new Button();
            toolTip1 = new ToolTip(components);
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 10.8F);
            label1.Location = new Point(258, 51);
            label1.Name = "label1";
            label1.Size = new Size(451, 66);
            label1.TabIndex = 1;
            label1.Text = "2nd year student of the \r\nNational Aerospace University \"Kharkiv Aviation Institute\"\r\nI like dogs, cats and capybaras 💜\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 10.8F);
            label2.Location = new Point(258, 138);
            label2.Name = "label2";
            label2.Size = new Size(502, 88);
            label2.TabIndex = 2;
            label2.Text = "The app allowes you to create strong passwords and save them. \r\nYou can find them again by the login\r\nBut before you'll gain an acces, please confirm that it's you in \r\nLogin window 😉\r\n";
            // 
            // btnMeow
            // 
            btnMeow.BackColor = Color.WhiteSmoke;
            btnMeow.BackgroundImage = Properties.Resources.cat;
            btnMeow.BackgroundImageLayout = ImageLayout.Zoom;
            btnMeow.Cursor = Cursors.Hand;
            btnMeow.FlatAppearance.BorderColor = Color.DarkMagenta;
            btnMeow.FlatAppearance.BorderSize = 2;
            btnMeow.FlatAppearance.MouseOverBackColor = Color.Thistle;
            btnMeow.FlatStyle = FlatStyle.Flat;
            btnMeow.Font = new Font("Calisto MT", 10F);
            btnMeow.ForeColor = Color.White;
            btnMeow.Location = new Point(682, 236);
            btnMeow.Margin = new Padding(0);
            btnMeow.Name = "btnMeow";
            btnMeow.Size = new Size(78, 66);
            btnMeow.TabIndex = 8;
            btnMeow.UseVisualStyleBackColor = false;
            btnMeow.Click += btnMeow_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gainsboro;
            btnBack.BackgroundImage = Properties.Resources.back;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(715, 9);
            btnBack.Margin = new Padding(0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(45, 42);
            btnBack.TabIndex = 10;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnInst
            // 
            btnInst.BackColor = Color.Gainsboro;
            btnInst.BackgroundImage = Properties.Resources.instagram;
            btnInst.BackgroundImageLayout = ImageLayout.Zoom;
            btnInst.Cursor = Cursors.Hand;
            btnInst.FlatAppearance.BorderColor = Color.Gainsboro;
            btnInst.FlatAppearance.BorderSize = 0;
            btnInst.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnInst.FlatStyle = FlatStyle.Flat;
            btnInst.Font = new Font("Calisto MT", 10F);
            btnInst.ForeColor = Color.Gainsboro;
            btnInst.Location = new Point(331, 236);
            btnInst.Margin = new Padding(0);
            btnInst.Name = "btnInst";
            btnInst.Size = new Size(117, 66);
            btnInst.TabIndex = 12;
            btnInst.UseVisualStyleBackColor = false;
            btnInst.Click += btnInst_Click;
            // 
            // btnGitHub
            // 
            btnGitHub.BackColor = Color.Gainsboro;
            btnGitHub.BackgroundImage = Properties.Resources.github;
            btnGitHub.BackgroundImageLayout = ImageLayout.Zoom;
            btnGitHub.Cursor = Cursors.Hand;
            btnGitHub.FlatAppearance.BorderColor = Color.Gainsboro;
            btnGitHub.FlatAppearance.BorderSize = 0;
            btnGitHub.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnGitHub.FlatStyle = FlatStyle.Flat;
            btnGitHub.Font = new Font("Calisto MT", 10F);
            btnGitHub.ForeColor = Color.WhiteSmoke;
            btnGitHub.Location = new Point(263, 233);
            btnGitHub.Margin = new Padding(0);
            btnGitHub.Name = "btnGitHub";
            btnGitHub.Size = new Size(68, 66);
            btnGitHub.TabIndex = 13;
            btnGitHub.UseVisualStyleBackColor = false;
            btnGitHub.Click += btnGitHub_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(258, 18);
            label3.Name = "label3";
            label3.Size = new Size(200, 22);
            label3.TabIndex = 14;
            label3.Text = "Author: Akhtyrska Sofiia";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.photo_288x288;
            pictureBox1.Location = new Point(12, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(437, 282);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 16;
            label4.Text = "I love Andrii";
            // 
            // About
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(769, 311);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btnMeow);
            Controls.Add(btnGitHub);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInst);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            Load += About_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private Button btnMeow;
        private Button btnBack;
        private Button btnInst;
        private Button btnGitHub;
        private ToolTip toolTip1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
    }
}