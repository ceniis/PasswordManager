using System.Drawing;
using System.Windows.Forms;
using PasswordManagerDraft;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PasswordManager_WinForms
{
    public partial class MainForm : Form
    {
        Password pass = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int size = (int)numericUpDown1.Value;
                pass.name = textBoxName.Text;
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
            MyEncryption encr = new();
            pass.name = textBoxName.Text;
            pass.password = textBoxPassword.Text;

            try
            {
                encr.Encrypt(pass.name, pass.password);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MyEncryption decr = new();
            pass.name = textBoxName.Text;

            try
            {
                textBoxPassword.Text = decr.Decrypt(pass.name);
                textBoxPassword.PasswordChar = '●';
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxPassword.Text = "";
            numericUpDown1.Value = 12;
            checkBox1.Checked = true;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            LoginForm form = new();
            form.btnHelp_Click(sender, e);
        }

        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxPassword.Focus();
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnGenerate_Click(sender, e);
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxPassword.PasswordChar = '●';
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '\0';
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPassword.Text))
            {
                Clipboard.SetText(textBoxPassword.Text);
            }
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Meow-meow...")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                textBoxName.Text = "Meow-meow...";
                textBoxName.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "123abc...")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            textBoxName.Text = "123abc...";
            textBoxName.ForeColor = Color.Gray;
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxName.Text = "";
            textBoxPassword.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // tips settings
            toolTip1.SetToolTip(btnSearch, "Find the password among the saved ones");
            toolTip1.SetToolTip(btnSave, "Save an encrypted password");
            toolTip1.SetToolTip(btnGenerate, "Generate a password");
            toolTip1.SetToolTip(btnClear, "Clear the fields");
            toolTip1.SetToolTip(btnCopy, "Copy a password to the Clipboard");
            toolTip1.SetToolTip(btnShow, "Show the password");
            toolTip1.SetToolTip(btnHelp, "Information");
        }
    }
}