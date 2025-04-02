using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnMeow1_Click(object sender, EventArgs e)
        {
            MainForm main = new();
            main.btnMeow_Click(sender, e);
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            ProcessStartInfo profile = new ProcessStartInfo("https://github.com/ceniis");
            Process.Start(profile);
        }

        private void btnInst_Click(object sender, EventArgs e)
        {
            ProcessStartInfo profile = new ProcessStartInfo("https://www.instagram.com/s_au_sa_ge/");
            Process.Start(profile);
        }
    }
}
