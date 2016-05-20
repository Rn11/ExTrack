using System;
using System.Windows.Forms;

namespace ExTrack
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.me/MaxLN/3");
        }
    }
}
