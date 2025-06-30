using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PasswordManager_WinForms.FileManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PasswordManager_WinForms
{
    public partial class LoginForm : Form
    {
        string enterPassword = "Please, enter the password";
        string enterCodeWord = "Please, enter the code-word";
        bool fileExists;
        bool wordMode = false;
        bool resetPasswordMode = false;

        Dictionary<string, string> saveData = new Dictionary<string, string>();
        string fileName = FilePaths.LoginPasswordFile; // file

        public LoginForm()
        {
            InitializeComponent();
            fileExists = File.Exists(fileName);

            if (!fileExists)
            {
                linkLabelForgotThePassword.Hide();
            }

            InputTitleLabel.Text = enterPassword;
            textBox1.ForeColor = Color.Gray;
            textBox1.PasswordChar = '\0';
            textBox1.Text = "Password...";
        }

        private void Logination()
        {
            string jsonString = File.ReadAllText(fileName);
            saveData = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);

            if (saveData == null || !saveData.ContainsKey("loginPassword") || !saveData.ContainsKey("codeWord"))
            {
                MessageBox.Show("Invalid file format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fileExists = false;
                return;
            }

            if (!resetPasswordMode)
            {
                string storedHash = saveData["loginPassword"];
                string hashString;

                using (SHA256 sha = SHA256.Create())
                {
                    byte[] tmpHash = sha.ComputeHash(Encoding.UTF8.GetBytes(textBox1.Text));
                    hashString = Convert.ToBase64String(tmpHash);
                }

                if (storedHash == hashString)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Incorrect password. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else // reset the password
            {
                string hashString;

                using (SHA256 sha = SHA256.Create())
                {
                    byte[] tmpHash = sha.ComputeHash(Encoding.UTF8.GetBytes(textBox1.Text));
                    hashString = Convert.ToBase64String(tmpHash);
                }

                if (wordMode)
                {
                    string storedHash = saveData["codeWord"];
                    if (storedHash == hashString)
                    {
                        wordMode = false;
                        InputTitleLabel.Text = enterPassword;
                        textBox1.Text = "Password...";
                    }
                    else
                    {
                        MessageBox.Show("Incorrect code-word. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show(
                       "Keep new password as an entry password?",
                       "Create a password",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question
                   );

                    if (result == DialogResult.Yes)
                    {
                        saveData["loginPassword"] = hashString;
                        jsonString = JsonSerializer.Serialize(saveData, new JsonSerializerOptions { WriteIndented = true });
                        File.WriteAllText(fileName, jsonString);
                        MessageBox.Show("Password was successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void Registration()
        {
            string hashString;

            using (SHA256 sha = SHA256.Create())
            {
                byte[] tmpHash = sha.ComputeHash(Encoding.UTF8.GetBytes(textBox1.Text));
                hashString = Convert.ToBase64String(tmpHash);
            }

            if (!wordMode)
            {
                DialogResult result = MessageBox.Show(
                       "Keep current password as an entry password?",
                       "Create a password",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question
                   );

                if (result == DialogResult.Yes)
                {
                    saveData.Add("loginPassword", hashString);
                    InputTitleLabel.Text = enterCodeWord;
                    textBox1.Text = "Code-word...";
                    wordMode = true;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show(
                      "Keep current code-word as an code-word for resetting password?",
                      "Create a code-word",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question
                  );

                if (result == DialogResult.Yes)
                {
                    saveData.Add("codeWord", hashString);
                }

                string jsonString = JsonSerializer.Serialize(saveData, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(fileName, jsonString);
                MessageBox.Show("Login information is saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Compare or create hashed login passwords
        /// </summary>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileExists)
                {
                    Logination();
                }
                else
                {
                    Registration();
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
            if (textBox1.Text == "Password..." || textBox1.Text == "Code-word...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                textBox1.PasswordChar = '●';
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.ForeColor = Color.Gray;
                textBox1.PasswordChar = '\0';
                textBox1.Text = wordMode ? "Code-word..." : "Password...";
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnShow, "Show the password");
            toolTip1.SetToolTip(btnHelp, "Information");
            toolTip1.SetToolTip(btnConfirm, "Confirm");
        }

        private void linkLabelForgotThePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelForgotThePassword.Hide();
            resetPasswordMode = true;
            wordMode = true;
            MessageBox.Show("Enter the code-word to confirm it's you", "Reset the password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InputTitleLabel.Text = enterCodeWord;
            textBox1.Text = "Code-word...";
            textBox1.ForeColor = Color.Gray;
            InputTitleLabel.Focus();
        }
    }
}