using System.Media;
using System.Windows.Forms;
using PasswordManagerDraft;

namespace PasswordManager_WinForms
{
    public partial class MainForm : Form
    {
        Password pass = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        /// <summary>
        /// Special button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnMeow_Click(object sender, EventArgs e)
        {
            SoundPlayer meow = new SoundPlayer(@"C:\Users\S\Downloads\meooowwww.wav");
            meow.Play();
        }
    }
}
