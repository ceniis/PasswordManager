using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

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
            SoundPlayer meow = new SoundPlayer(@"C:\Users\S\Downloads\meooowwww.wav");
            meow.Play();
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
