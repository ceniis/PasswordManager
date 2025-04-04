﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Linq.Expressions;

namespace PasswordManager_WinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = "LoginPassword.json"; // password file
                string password = textBox1.Text;

                if (File.Exists(fileName))
                {
                    string jsonString = File.ReadAllText(fileName);
                    var jsonData = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);

                    if (jsonData == null || !jsonData.ContainsKey("loginPassword"))
                    {
                        MessageBox.Show("Invalid password file format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string actualPassword = jsonData["loginPassword"];;
                    // comparing
                    if (password == actualPassword)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Enter new login password.", "Create a password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var data = new Dictionary<string, string>  { { "loginPassword", $"{password}" } };
                    string jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(fileName, jsonString);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnHelp_Click(object sender, EventArgs e)
        {
            About about = new();
            about.ShowDialog();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnConfirm_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}