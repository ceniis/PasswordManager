using System.Diagnostics;
using System.Media;
using System.Reflection;

namespace PasswordManager_WinForms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        /// <summary>
        /// Special button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnMeow_Click(object sender, EventArgs e)
        {
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                string resourceName = "PasswordManager_WinForms.Resources.meooowwww.wav";
                Stream soundStream = assembly.GetManifestResourceStream(resourceName);
                if (soundStream != null)
                {
                    SoundPlayer meow = new SoundPlayer(soundStream);
                    meow.Play();
                }
                else
                {
                    Exception ex = new();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing the sound: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/ceniis") { UseShellExecute = true });
        }

        private void btnInst_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.instagram.com/s_au_sa_ge/") { UseShellExecute = true });
        }

        private void About_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnBack, "Back");
            toolTip1.SetToolTip(btnGitHub, "See GitHub");
            toolTip1.SetToolTip(btnInst, "See Instagram");
            toolTip1.SetToolTip(btnMeow, "Meow-meow");
        }
    }
}