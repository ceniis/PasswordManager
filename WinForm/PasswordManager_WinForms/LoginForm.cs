using System;
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
using System.Security.Cryptography;

namespace PasswordManager_WinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Compare or create hashed login passwords
        /// </summary>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = FilePaths.LoginPasswordFile; // file
                string password = textBox1.Text; // login password

                // hash the input
                string hashString;
                using (SHA256 sha = SHA256.Create())
                {
                    byte[] tmpHash = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                    hashString = Convert.ToBase64String(tmpHash);
                }

                if (File.Exists(fileName))
                {
                    string jsonString = File.ReadAllText(fileName);
                    var jsonData = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);

                    if (jsonData == null || !jsonData.ContainsKey("loginPassword"))
                    {
                        MessageBox.Show("Invalid password file format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string storedHash = jsonData["loginPassword"];

                    // compare the hash
                    if (storedHash == hashString)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else // if file doesn't exist
                {
                    DialogResult result = MessageBox.Show(
                        "Keep current password as an entry password?",
                        "Create a password",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        var data = new Dictionary<string, string> { { "loginPassword", hashString } };
                        string jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
                        File.WriteAllText(fileName, jsonString);

                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Password is written successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        textBox1.Focus();
                    }
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            textBox1.PasswordChar = textBox1.PasswordChar == '\0' ? '●' : '\0';
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.PasswordChar = '●';
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Password...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                textBox1.Text = "Password...";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // toolTips settings
            toolTip1.SetToolTip(btnShow, "Show the password");
            toolTip1.SetToolTip(btnHelp, "Information");
            toolTip1.SetToolTip(btnConfirm, "Confirm");
        }
    }
}