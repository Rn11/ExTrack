using System;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace ExTrack
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }

        static void displayAudioPicture()
        {
            StreamReader srChoice = new StreamReader(Environment.ExpandEnvironmentVariables(@"%AppData%\\ExTrack\options"));
            string choice = Convert.ToString(srChoice.ReadToEnd());
            srChoice.Close();

            PictureBox createform = new PictureBox(Convert.ToInt32(choice));
            createform.Show();

            switch (Convert.ToInt32(choice))
            {
                case 0:
                    SoundPlayer snd0 = new SoundPlayer(Properties.Resources.JohnCenaAudio);
                    snd0.Play();
                    break;
                case 1:
                    SoundPlayer snd1 = new SoundPlayer(Properties.Resources.TripleHAudio);
                    snd1.Play();
                    break;
                case 2:
                    SoundPlayer snd2 = new SoundPlayer(Properties.Resources.BatmanAudio);
                    snd2.Play();
                    break;
                default:
                    break;
            }
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            try
            {
                Func.setOpenFileName("score");
                string fileName = Func.getOpenFileName();

                if (fileName != null)
                {
                    StreamReader sr = new StreamReader(Environment.ExpandEnvironmentVariables(@"%AppData%\\ExTrack\") + Func.getOpenFileName());
                    //add axis desc
                    chart1.ChartAreas[0].AxisX.Title = "Trainings";
                    chart1.ChartAreas[0].AxisY.Title = "Score";
                    //correct x-axis minimum
                    chart1.ChartAreas[0].AxisX.Minimum = 1;
                    //show point value
                    this.chart1.Series["Score"].IsValueShownAsLabel = true;

                    //count lines of score-document
                    int lineCount = Func.countLines(Environment.ExpandEnvironmentVariables(@"%AppData%\\ExTrack\") + Func.getOpenFileName());

                    if (lineCount != 0 && lineCount != 1)
                    {
                        for (int lines = 0; lineCount >= lines; lines++)
                        {
                            //splitString
                            string[] tmp = sr.ReadLine().Split('\t');

                            //write cell
                            for (int i = 0; (tmp.Count() - 1) >= i && tmp.Count() != 1; i++)
                            {
                                //add point and add date to x-axis
                                this.chart1.Series["Score"].Points.Add(Convert.ToDouble(tmp[i]));
                                this.chart1.Series["Score"].Points[chart1.Series["Score"].Points.Count - 1].AxisLabel = Convert.ToString(tmp[i + 1]).Substring(0, 10);
                                i = i + 2;
                            }
                        }
                        sr.Close();
                        //correct x-axis maximum
                        chart1.ChartAreas[0].AxisX.Maximum = this.chart1.Series["Score"].Points.Count;
                        if (30 < (Convert.ToInt32(this.chart1.Series["Score"].Points[chart1.Series["Score"].Points.Count - 1].YValues[0]) - Convert.ToInt32(this.chart1.Series["Score"].Points[chart1.Series["Score"].Points.Count - 2].YValues[0])))
                        {

                            if (File.Exists(Environment.ExpandEnvironmentVariables(@"%AppData%\\ExTrack\options")))
                            {
                                displayAudioPicture();
                            }
                            else
                            {
                                StreamWriter srOption = new StreamWriter(Environment.ExpandEnvironmentVariables(@"%AppData%\\ExTrack\options"), false);
                                srOption.Write("2");
                                srOption.Close();
                                displayAudioPicture();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
        }
    }
}

