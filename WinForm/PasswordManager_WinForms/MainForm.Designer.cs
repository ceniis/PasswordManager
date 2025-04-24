namespace PasswordManager_WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnGenerate = new Button();
            textBoxName = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            btnSave = new Button();
            btnClear = new Button();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            checkBox1 = new CheckBox();
            textBoxPassword = new TextBox();
            label3 = new Label();
            btnHelp = new Button();
            toolTip1 = new ToolTip(components);
            label4 = new Label();
            btnShow = new Button();
            btnCopy = new Button();
            btnViewAll = new Button();
            labelCount = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.WhiteSmoke;
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.FlatAppearance.BorderColor = Color.Navy;
            btnGenerate.FlatAppearance.BorderSize = 2;
            btnGenerate.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Corbel", 12F);
            btnGenerate.ForeColor = Color.Black;
            btnGenerate.Location = new Point(343, 118);
            btnGenerate.Margin = new Padding(0);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(94, 27);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // textBoxName
            // 
            textBoxName.Cursor = Cursors.IBeam;
            textBoxName.Font = new Font("Corbel Light", 9F);
            textBoxName.ForeColor = SystemColors.WindowFrame;
            textBoxName.Location = new Point(10, 31);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(232, 22);
            textBoxName.TabIndex = 1;
            textBoxName.Text = "Meow-meow...";
            textBoxName.Enter += textBoxName_Enter;
            textBoxName.KeyDown += textBoxName_KeyDown;
            textBoxName.Leave += textBoxName_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 19);
            label1.TabIndex = 2;
            label1.Text = "Enter password's name:";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.WhiteSmoke;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderColor = Color.Navy;
            btnSearch.FlatAppearance.BorderSize = 2;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(343, 155);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 27);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.WhiteSmoke;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.Navy;
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Corbel", 12F);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(343, 192);
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 27);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.WhiteSmoke;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.MediumBlue;
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Corbel", 12F);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(343, 83);
            btnClear.Margin = new Padding(0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 27);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(397, 55);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(40, 23);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 9.5F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(270, 57);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 6;
            label2.Text = "Number of characters:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 192);
            checkBox1.Font = new Font("Corbel", 9.5F);
            checkBox1.ForeColor = Color.Black;
            checkBox1.Location = new Point(270, 33);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(134, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Add special symbols";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Cursor = Cursors.IBeam;
            textBoxPassword.Font = new Font("Corbel Light", 9F);
            textBoxPassword.ForeColor = SystemColors.WindowFrame;
            textBoxPassword.Location = new Point(10, 82);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(204, 22);
            textBoxPassword.TabIndex = 6;
            textBoxPassword.Text = "123abc...";
            textBoxPassword.Enter += textBoxPassword_Enter;
            textBoxPassword.KeyDown += textBoxPassword_KeyDown;
            textBoxPassword.KeyPress += textBoxPassword_KeyPress;
            textBoxPassword.Leave += textBoxPassword_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(10, 60);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 7;
            label3.Text = "Password:";
            // 
            // btnHelp
            // 
            btnHelp.Cursor = Cursors.Help;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Segoe UI", 14F);
            btnHelp.ForeColor = Color.Navy;
            btnHelp.Location = new Point(415, -1);
            btnHelp.Margin = new Padding(0);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(22, 34);
            btnHelp.TabIndex = 8;
            btnHelp.Text = "❔";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Corbel", 10F);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(270, 11);
            label4.Name = "label4";
            label4.Size = new Size(118, 17);
            label4.TabIndex = 10;
            label4.Text = "Password settings:";
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.Gainsboro;
            btnShow.BackgroundImage = Properties.Resources.icons8_eye_30;
            btnShow.Cursor = Cursors.Hand;
            btnShow.FlatAppearance.BorderColor = Color.Navy;
            btnShow.FlatAppearance.BorderSize = 0;
            btnShow.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.Font = new Font("Corbel", 12F);
            btnShow.ForeColor = Color.Black;
            btnShow.Location = new Point(215, 82);
            btnShow.Margin = new Padding(0);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(28, 28);
            btnShow.TabIndex = 11;
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.Gainsboro;
            btnCopy.BackgroundImage = Properties.Resources.icons8_copy_30;
            btnCopy.Cursor = Cursors.Hand;
            btnCopy.FlatAppearance.BorderColor = Color.Navy;
            btnCopy.FlatAppearance.BorderSize = 0;
            btnCopy.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnCopy.FlatStyle = FlatStyle.Flat;
            btnCopy.Font = new Font("Corbel", 12F);
            btnCopy.ForeColor = Color.Black;
            btnCopy.Location = new Point(243, 82);
            btnCopy.Margin = new Padding(0);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(28, 28);
            btnCopy.TabIndex = 12;
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnViewAll
            // 
            btnViewAll.BackColor = Color.WhiteSmoke;
            btnViewAll.Cursor = Cursors.Hand;
            btnViewAll.FlatAppearance.BorderColor = Color.Navy;
            btnViewAll.FlatAppearance.BorderSize = 2;
            btnViewAll.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            btnViewAll.FlatStyle = FlatStyle.Flat;
            btnViewAll.Font = new Font("Corbel", 12F);
            btnViewAll.ForeColor = Color.Black;
            btnViewAll.Location = new Point(343, 245);
            btnViewAll.Margin = new Padding(0, 16, 0, 0);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(94, 27);
            btnViewAll.TabIndex = 13;
            btnViewAll.Text = "View all";
            btnViewAll.UseVisualStyleBackColor = false;
            btnViewAll.Click += btnViewAll_Click;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Corbel", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCount.ForeColor = Color.MidnightBlue;
            labelCount.Location = new Point(10, 118);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(172, 19);
            labelCount.TabIndex = 14;
            labelCount.Text = "There's 0 saved passwords";
            labelCount.Click += labelCount_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(319, 132);
            dataGridView1.TabIndex = 15;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(446, 284);
            Controls.Add(dataGridView1);
            Controls.Add(labelCount);
            Controls.Add(btnViewAll);
            Controls.Add(btnCopy);
            Controls.Add(btnShow);
            Controls.Add(label4);
            Controls.Add(btnHelp);
            Controls.Add(btnClear);
            Controls.Add(btnGenerate);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxPassword);
            Controls.Add(checkBox1);
            Controls.Add(btnSave);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            ForeColor = Color.Gainsboro;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Manager";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private TextBox textBoxName;
        private Label label1;
        private Button btnSearch;
        private Button btnSave;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private TextBox textBoxPassword;
        private Label label3;
        private Button btnHelp;
        private ToolTip toolTip1;
        private Button btnClear;
        private Label label4;
        private Button btnShow;
        private Button btnCopy;
        private Button btnViewAll;
        private Label labelCount;
        private DataGridView dataGridView1;
    }
}
