namespace PasswordManager_WinForms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            btnConfirm = new Button();
            btnHelp = new Button();
            toolTip1 = new ToolTip(components);
            btnClose = new Button();
            btnShow = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Corbel", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 7);
            label1.Name = "label1";
            label1.Size = new Size(176, 39);
            label1.TabIndex = 0;
            label1.Text = "WELCOME!";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 12F);
            label2.Location = new Point(5, 56);
            label2.Name = "label2";
            label2.Size = new Size(186, 19);
            label2.TabIndex = 1;
            label2.Text = "Please, enter the password";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Corbel Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Location = new Point(5, 76);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 22);
            textBox1.TabIndex = 2;
            textBox1.Text = "Password...";
            textBox1.Enter += textBox1_Enter;
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.Leave += textBox1_Leave;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.WhiteSmoke;
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.FlatAppearance.BorderColor = Color.Navy;
            btnConfirm.FlatAppearance.BorderSize = 2;
            btnConfirm.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Corbel", 12F);
            btnConfirm.Location = new Point(174, 106);
            btnConfirm.Margin = new Padding(0);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 29);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "OK";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnHelp
            // 
            btnHelp.Cursor = Cursors.Help;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Segoe UI", 14F);
            btnHelp.ForeColor = Color.Navy;
            btnHelp.Location = new Point(242, -1);
            btnHelp.Margin = new Padding(0);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(39, 31);
            btnHelp.TabIndex = 4;
            btnHelp.Text = "❔";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(274, 0);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(39, 31);
            btnClose.TabIndex = 5;
            btnClose.Text = "❌";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button1_Click;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.Gainsboro;
            btnShow.BackgroundImage = Properties.Resources.showeye;
            btnShow.Cursor = Cursors.Hand;
            btnShow.FlatAppearance.BorderColor = Color.Navy;
            btnShow.FlatAppearance.BorderSize = 0;
            btnShow.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.Font = new Font("Corbel", 12F);
            btnShow.ForeColor = Color.Black;
            btnShow.Location = new Point(253, 70);
            btnShow.Margin = new Padding(0);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(28, 28);
            btnShow.TabIndex = 12;
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(312, 142);
            Controls.Add(btnShow);
            Controls.Add(btnClose);
            Controls.Add(btnHelp);
            Controls.Add(btnConfirm);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button btnConfirm;
        private Button btnHelp;
        private ToolTip toolTip1;
        private Button btnClose;
        private Button btnShow;
    }
}