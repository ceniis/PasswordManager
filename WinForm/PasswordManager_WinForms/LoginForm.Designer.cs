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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            btnConfirm = new Button();
            btnHelp = new Button();
            toolTip1 = new ToolTip(components);
            button1 = new Button();
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
            textBox1.Size = new Size(273, 22);
            textBox1.TabIndex = 2;
            textBox1.Text = "Password...";
            textBox1.KeyDown += textBox1_KeyDown;
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
            btnConfirm.Location = new Point(202, 104);
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
            btnHelp.Location = new Point(238, 0);
            btnHelp.Margin = new Padding(0);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(39, 31);
            btnHelp.TabIndex = 4;
            btnHelp.Text = "❔";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Help;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(274, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(39, 31);
            button1.TabIndex = 5;
            button1.Text = "❌";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(312, 142);
            Controls.Add(button1);
            Controls.Add(btnHelp);
            Controls.Add(btnConfirm);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "LoginForm";
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
        private Button button1;
    }
}