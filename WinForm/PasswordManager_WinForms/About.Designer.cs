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
            pictureBox1 = new PictureBox();
            btnBack = new Button();
            btnInst = new Button();
            btnGitHub = new Button();
            toolTip1 = new ToolTip(components);
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 10F);
            label1.Location = new Point(258, 42);
            label1.Name = "label1";
            label1.Size = new Size(410, 63);
            label1.TabIndex = 1;
            label1.Text = "2nd year student of the \r\nNational Aerospace University \"Kharkiv Aviation Institute\"\r\nI like cats and capybaras 💜\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 10F);
            label2.Location = new Point(258, 129);
            label2.Name = "label2";
            label2.Size = new Size(449, 84);
            label2.TabIndex = 2;
            label2.Text = "The app allowes you to create strong passwords and save them. \r\nYou can find them again by the login\r\nBut before you'll gain an acces, please confirm that it's you in \r\nLogin window 😉\r\n";
            // 
            // btnMeow
            // 
            btnMeow.BackColor = Color.WhiteSmoke;
            btnMeow.BackgroundImage = (Image)resources.GetObject("btnMeow.BackgroundImage");
            btnMeow.BackgroundImageLayout = ImageLayout.Center;
            btnMeow.Cursor = Cursors.Hand;
            btnMeow.FlatAppearance.BorderColor = Color.DarkMagenta;
            btnMeow.FlatAppearance.BorderSize = 2;
            btnMeow.FlatAppearance.MouseOverBackColor = Color.Thistle;
            btnMeow.FlatStyle = FlatStyle.Flat;
            btnMeow.Font = new Font("Calisto MT", 10F);
            btnMeow.ForeColor = Color.White;
            btnMeow.Location = new Point(598, 236);
            btnMeow.Margin = new Padding(0);
            btnMeow.Name = "btnMeow";
            btnMeow.Size = new Size(78, 66);
            btnMeow.TabIndex = 8;
            btnMeow.UseVisualStyleBackColor = false;
            btnMeow.Click += btnMeow_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.photo_2024_06_07_20_48_26_288x288;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 280);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gainsboro;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(649, 0);
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
            btnInst.BackgroundImage = (Image)resources.GetObject("btnInst.BackgroundImage");
            btnInst.BackgroundImageLayout = ImageLayout.Center;
            btnInst.Cursor = Cursors.Hand;
            btnInst.FlatAppearance.BorderColor = Color.Gainsboro;
            btnInst.FlatAppearance.BorderSize = 0;
            btnInst.FlatStyle = FlatStyle.Flat;
            btnInst.Font = new Font("Calisto MT", 10F);
            btnInst.ForeColor = Color.Gainsboro;
            btnInst.Location = new Point(341, 236);
            btnInst.Margin = new Padding(0);
            btnInst.Name = "btnInst";
            btnInst.Size = new Size(90, 66);
            btnInst.TabIndex = 12;
            btnInst.UseVisualStyleBackColor = false;
            btnInst.Click += btnInst_Click;
            // 
            // btnGitHub
            // 
            btnGitHub.BackColor = Color.Gainsboro;
            btnGitHub.BackgroundImage = (Image)resources.GetObject("btnGitHub.BackgroundImage");
            btnGitHub.BackgroundImageLayout = ImageLayout.Center;
            btnGitHub.Cursor = Cursors.Hand;
            btnGitHub.FlatAppearance.BorderColor = Color.Gainsboro;
            btnGitHub.FlatAppearance.BorderSize = 0;
            btnGitHub.FlatStyle = FlatStyle.Flat;
            btnGitHub.Font = new Font("Calisto MT", 10F);
            btnGitHub.ForeColor = Color.WhiteSmoke;
            btnGitHub.Location = new Point(263, 236);
            btnGitHub.Margin = new Padding(0);
            btnGitHub.Name = "btnGitHub";
            btnGitHub.Size = new Size(78, 66);
            btnGitHub.TabIndex = 13;
            btnGitHub.UseVisualStyleBackColor = false;
            btnGitHub.Click += btnGitHub_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(258, 18);
            label3.Name = "label3";
            label3.Size = new Size(220, 24);
            label3.TabIndex = 14;
            label3.Text = "Author: Akhtyrska Sofiia";
            // 
            // About
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(697, 311);
            Controls.Add(label3);
            Controls.Add(btnMeow);
            Controls.Add(btnGitHub);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInst);
            Controls.Add(btnBack);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private Button btnMeow;
        private PictureBox pictureBox1;
        private Button btnBack;
        private Button btnInst;
        private Button btnGitHub;
        private ToolTip toolTip1;
        private Label label3;
    }
}