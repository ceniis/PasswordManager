﻿namespace PasswordManager_WinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            btnShowDataGridView = new Button();
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
            btnGenerate.Location = new Point(408, 155);
            btnGenerate.Margin = new Padding(0);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(107, 36);
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
            textBoxName.Location = new Point(11, 41);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(265, 26);
            textBoxName.TabIndex = 1;
            textBoxName.Enter += textBoxName_Enter;
            textBoxName.KeyDown += textBoxName_KeyDown;
            textBoxName.Leave += textBoxName_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(209, 24);
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
            btnSearch.Location = new Point(408, 205);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(107, 36);
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
            btnSave.Location = new Point(408, 253);
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 36);
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
            btnClear.Location = new Point(408, 109);
            btnClear.Margin = new Padding(0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 36);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(470, 73);
            numericUpDown1.Margin = new Padding(2, 3, 2, 3);
            numericUpDown1.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(46, 27);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 9.5F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(309, 76);
            label2.Name = "label2";
            label2.Size = new Size(156, 19);
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
            checkBox1.Location = new Point(309, 44);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(166, 23);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Add special symbols";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Cursor = Cursors.IBeam;
            textBoxPassword.Font = new Font("Corbel Light", 9F);
            textBoxPassword.ForeColor = SystemColors.WindowFrame;
            textBoxPassword.Location = new Point(11, 109);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(233, 26);
            textBoxPassword.TabIndex = 6;
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
            label3.Location = new Point(11, 80);
            label3.Name = "label3";
            label3.Size = new Size(95, 24);
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
            btnHelp.Location = new Point(491, -1);
            btnHelp.Margin = new Padding(0);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(25, 45);
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
            label4.Location = new Point(309, 15);
            label4.Name = "label4";
            label4.Size = new Size(141, 21);
            label4.TabIndex = 10;
            label4.Text = "Password settings:";
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.Gainsboro;
            btnShow.BackgroundImage = Properties.Resources.showeye;
            btnShow.BackgroundImageLayout = ImageLayout.Stretch;
            btnShow.Cursor = Cursors.Hand;
            btnShow.FlatAppearance.BorderColor = Color.Navy;
            btnShow.FlatAppearance.BorderSize = 0;
            btnShow.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.Font = new Font("Corbel", 12F);
            btnShow.ForeColor = Color.Black;
            btnShow.Location = new Point(246, 109);
            btnShow.Margin = new Padding(0);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(24, 24);
            btnShow.TabIndex = 11;
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.Gainsboro;
            btnCopy.BackgroundImage = Properties.Resources.copy;
            btnCopy.BackgroundImageLayout = ImageLayout.Zoom;
            btnCopy.Cursor = Cursors.Hand;
            btnCopy.FlatAppearance.BorderColor = Color.Navy;
            btnCopy.FlatAppearance.BorderSize = 0;
            btnCopy.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnCopy.FlatStyle = FlatStyle.Flat;
            btnCopy.Font = new Font("Corbel", 12F);
            btnCopy.ForeColor = Color.Black;
            btnCopy.Location = new Point(278, 109);
            btnCopy.Margin = new Padding(0);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(24, 24);
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
            btnViewAll.Location = new Point(408, 299);
            btnViewAll.Margin = new Padding(0, 21, 0, 0);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(107, 36);
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
            labelCount.Location = new Point(11, 157);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(218, 24);
            labelCount.TabIndex = 14;
            labelCount.Text = "There's 0 saved passwords";
            labelCount.Click += labelCount_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 187);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(379, 176);
            dataGridView1.TabIndex = 15;
            dataGridView1.KeyPress += dataGridView1_KeyPress;
            // 
            // btnShowDataGridView
            // 
            btnShowDataGridView.BackColor = Color.Gainsboro;
            btnShowDataGridView.BackgroundImage = Properties.Resources.showeye;
            btnShowDataGridView.BackgroundImageLayout = ImageLayout.Zoom;
            btnShowDataGridView.Cursor = Cursors.Hand;
            btnShowDataGridView.FlatAppearance.BorderColor = Color.Navy;
            btnShowDataGridView.FlatAppearance.BorderSize = 0;
            btnShowDataGridView.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnShowDataGridView.FlatStyle = FlatStyle.Flat;
            btnShowDataGridView.Font = new Font("Corbel", 12F);
            btnShowDataGridView.ForeColor = Color.Black;
            btnShowDataGridView.Location = new Point(408, 335);
            btnShowDataGridView.Margin = new Padding(0);
            btnShowDataGridView.Name = "btnShowDataGridView";
            btnShowDataGridView.Size = new Size(24, 24);
            btnShowDataGridView.TabIndex = 16;
            btnShowDataGridView.UseVisualStyleBackColor = false;
            btnShowDataGridView.Click += btnShowDataGridView_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(523, 375);
            Controls.Add(btnShowDataGridView);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnShowDataGridView;
    }
}
