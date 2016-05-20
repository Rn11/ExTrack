using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExTrack
{
    public partial class PictureBox : Form
    {
        public PictureBox()
        {
            InitializeComponent();
        }

        public PictureBox(int choice)
        {
            InitializeComponent();
            switch (choice)
            {
                case 0:
                    pictureBox1.Image = ExTrack.Properties.Resources.JohnCenaPicture;
                    break;
                case 1:
                    pictureBox1.Image = ExTrack.Properties.Resources.TripleHPicture;
                    break;
                case 2:
                    pictureBox1.Image = ExTrack.Properties.Resources.BatmanPicture;
                    break;
                default:
                    break;
            }
        }

        private void PictureBox_Load(object sender, EventArgs e)
        {

        }
    }
}
