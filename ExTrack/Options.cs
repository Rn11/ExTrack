using System;
using System.Windows.Forms;
using System.IO;

namespace ExTrack
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            optJohnCena.Checked = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //create dir
            Directory.CreateDirectory(Environment.ExpandEnvironmentVariables(@"%AppData%\\ExTrack\"));
            //sr
            StreamWriter srOption = new StreamWriter(Environment.ExpandEnvironmentVariables(@"%AppData%\\ExTrack\options"), false);
            //set option
            if (optJohnCena.Checked)
            {
                srOption.Write("0");
            }
            else if (optTripleH.Checked)
            {
                srOption.Write("1");
            }
            else if (optBatman.Checked)
            {
                srOption.Write("2");
            }
            srOption.Close();
            this.Close();
        }
    }
}
