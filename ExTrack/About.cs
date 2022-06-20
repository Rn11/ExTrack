using System;
using System.Windows.Forms;

namespace ExTrack
{
    public partial class About : Form
    {
        string version = "";

        public About()
        {
            InitializeComponent();
        }

        public About(string ver)
        {
            InitializeComponent();
            //get newest version
            version = ver;
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.me/MaxLN/3");
        }

        private void About_Load(object sender, EventArgs e)
        {
            //update version
            lblVer.Text = version; 
        }
    }
}
