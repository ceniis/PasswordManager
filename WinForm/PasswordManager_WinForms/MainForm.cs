using System.Diagnostics.Metrics;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using PasswordManagerDraft;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PasswordManager_WinForms
{
    public partial class MainForm : Form
    {
        Password? pass = new Password();
        FileManager fileManager = new FileManager();
        MyEncryption decr = new MyEncryption();
        MyEncryption encr = new MyEncryption();
        private string _namePlaceholder = "Name of the password...";
        private string _passwordPlaceholder = "Password...";
        private string _loginPlaceholder = "Login...";

        public MainForm()
        {
            InitializeComponent();
            textBoxName.Text = _namePlaceholder;
            textBoxPassword.Text = _passwordPlaceholder;
            textBoxLogin.Text = _loginPlaceholder;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int size = (int)numericUpDown1.Value;
                pass.name = textBoxName.Text;
                pass.login = textBoxLogin.Text;

                if (checkBox1.Checked) pass.Create(include: true, size);
                else pass.Create(include: false, size);

                textBoxPassword.Text = pass.password;
                textBoxPassword.PasswordChar = '●';
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                pass.name = textBoxName.Text;
                pass.password = encr.Encrypt(textBoxPassword.Text);
                pass.login = textBoxLogin.Text;
                fileManager.SaveToFile(pass);
                labelCount_Click(sender, e);
                MessageBox.Show("Saved successfully\nP.S. if password with the same name has already exist, it was rewritten", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                pass = fileManager.FindEncryptedPassword(textBoxName.Text);

                if (pass != null)
                {
                    textBoxPassword.Text = decr.Decrypt(pass);
                    textBoxPassword.PasswordChar = '●';
                }
                else
                {
                    throw new Exception($"Password with name: {textBoxName.Text} does not exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = _namePlaceholder;
            textBoxPassword.Text = _passwordPlaceholder;
            textBoxLogin.Text = _loginPlaceholder;
            numericUpDown1.Value = 12;
            dataGridView1.Rows.Clear();
            checkBox1.Checked = true;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            LoginForm form = new();
            form.btnHelp_Click(sender, e);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = textBoxPassword.PasswordChar == '\0' ? '●' : '\0';
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPassword.Text))
            {
                Clipboard.SetText(textBoxPassword.Text);
                MessageBox.Show("Copied to the clipboard", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxPassword.Focus();
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnSave_Click(sender, e);
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxPassword.PasswordChar = '●';
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            TextBox_Enter(textBoxName, _namePlaceholder);
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            TextBox_Leave(textBoxName, _namePlaceholder);
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            TextBox_Enter(textBoxPassword, _passwordPlaceholder);
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            TextBox_Leave(textBoxPassword, _passwordPlaceholder);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelCount_Click(sender, e);

            // tablet settings
            dataGridView1.Columns.Add("colName", "Name");
            dataGridView1.Columns.Add("colPassword", "Password");
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 280;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Corbel", 12, FontStyle.Regular);
            dataGridView1.ReadOnly = true;

            // tips settings
            toolTip1.SetToolTip(btnSearch, "Find the password among the saved ones by its name");
            toolTip1.SetToolTip(btnSave, "Save an encrypted password");
            toolTip1.SetToolTip(btnGenerate, "Generate a password");
            toolTip1.SetToolTip(btnClear, "Clear the fields");
            toolTip1.SetToolTip(btnCopy, "Copy a password to the Clipboard");
            toolTip1.SetToolTip(btnShow, "Show passwords");
            toolTip1.SetToolTip(btnHelp, "Information");
            toolTip1.SetToolTip(btnViewAll, "Show all saved passwords");
            toolTip1.SetToolTip(labelCount, "How many passwords is saved");
            toolTip1.SetToolTip(btnDelete, "Delete the password by its name");
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            try
            {
                var entries = fileManager.AllEncryptedPasswords();

                if (entries != null)
                {
                    foreach (var entry in entries)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridView1, entry.name, "●●●●●●●●●●●●●●");
                        row.DefaultCellStyle.ForeColor = Color.MidnightBlue;
                        row.DefaultCellStyle.Font = new Font("Corbel", 12, FontStyle.Regular);
                        dataGridView1.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelCount_Click(object sender, EventArgs e)
        {
            if (FileManager.Counter() != 0 && FileManager.Counter() != 1) labelCount.Text = $"There're {FileManager.Counter().ToString()} saved passwords";
            else labelCount.Text = $"There's {FileManager.Counter().ToString()} saved passwords";
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (Char)Keys.None;
        }

        private void btnShowDataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                List<Password>? entries = fileManager.AllEncryptedPasswords();

                if (entries != null)
                {
                    for (int i = 0; i < entries.Count; i++)
                    {
                        if (i < dataGridView1.Rows.Count)
                        {
                            var decryptedPassword = decr.Decrypt(entries[i]);
                            dataGridView1.Rows[i].Cells[1].Value = decryptedPassword;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_Leave(System.Windows.Forms.TextBox textBox, string _placeholder)
        {
            if (textBox.Text == "")
            {
                textBoxPassword.Text = _placeholder;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void TextBox_Enter(System.Windows.Forms.TextBox textBox, string _placeholder)
        {
            if (textBox.Text == _placeholder)
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            TextBox_Leave(textBoxLogin, _loginPlaceholder);
        }

        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            TextBox_Enter(textBoxLogin, _loginPlaceholder);
        }
    }
}