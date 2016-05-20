using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExTrack
{
    public partial class WorkoutFixed : Form
    {
        public int index = 0;
        public double points = 0;
        protected bool isLoaded = false;

        public WorkoutFixed()
        {
            InitializeComponent();
        }

        private MainForm mainForm = null;
        public WorkoutFixed(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
        }

        private void loadPlan ()
        {
            Func.setOpenFileName(true);
            string fileName = Func.getOpenFileName();
            if (fileName != null)
            {
                try
                {
                    StreamReader sr = new StreamReader(Func.getOpenFileName());

                    lvPlan.Items.Clear();
                    //write line
                    for (int lines = 0; (Func.countLines(Func.getOpenFileName())) >= lines; lines++)
                    {
                        string[] tmp = sr.ReadLine().Split('\t');
                        ListViewItem lvi = new ListViewItem(tmp[0]);
                        //write cell
                        for (int i = 0; (tmp.Count() - 1) >= i; i++)
                        {
                            lvi.SubItems.Add(tmp[1]);
                            lvi.SubItems.Add(tmp[2]);
                        }
                        lvPlan.Items.Add(lvi);
                    }
                    sr.Close();
                    index = 0;
                    lvPlan.Items[index].Selected = true;
                    lvPlan.Select();
                    isLoaded = true;
                    btnConf.Enabled = true;

                    //create dir
                    Directory.CreateDirectory(Environment.ExpandEnvironmentVariables(@"%AppData%\\ExTrack\"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler: " + ex.Message);
                }
            }
        }

        private void Workout_Load(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                btnConf.Enabled = true;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadPlan();
        }

        private void enterNext()
        {
            //sw & sb  
            StreamWriter sw = new StreamWriter(Environment.ExpandEnvironmentVariables(@"%AppData%\\ExTrack\aufzeichnungen"), true);
            StringBuilder sb = new StringBuilder();
            StringBuilder sbScore = new StringBuilder();

            //check if training is finished
            if (index+1 >= lvPlan.Items.Count)
            {
                points = Math.Round(points, 0);
                StreamWriter swScore = new StreamWriter(Environment.ExpandEnvironmentVariables(@"%AppData%\\ExTrack\score"), true);
                //messageBox user
                MessageBox.Show("Glückwunsch, Training abgeschlossen. \nIhr Score für dieses Training beträgt: " + points + ", wow!");
                
                //Write training history
                //append date
                sb.Append(string.Format("{0}\t", DateTime.Now));
                //append break
                sw.WriteLine();

                sw.WriteLine(sb.ToString());
                sw.Close();

                //Write score
                //append score
                sbScore.Append(string.Format("{0}\t", points));
                //append date
                sbScore.Append( DateTime.Now);
                //append break
                swScore.WriteLine(sbScore.ToString());
                swScore.WriteLine();
                swScore.Close();

                index = 0;

                this.mainForm.LabelText = "";

                //close form
                this.Close();
            }


            //if training is NOT finished, continue with append data & write to file
            else
            {
                //APPEND
                //append item name
                sb.Append(string.Format("{0}\t", (lvPlan.Items[index].Text)));

                //append subitem reps
                sb.Append(string.Format("{0}\t", txtRep.Text));

                //append weight subitem
                sb.Append(string.Format("{0}\t", lvPlan.Items[index].SubItems[2].Text));

                //write to file
                sw.WriteLine(sb.ToString());
                sw.Close();


                //calculate points for exercise
                //if weight is not null
                if (lvPlan.Items[index].SubItems[2].Text != "")
                {
                    points = points + Func.calcPoints(Convert.ToInt32(txtRep.Text), Convert.ToInt32(lvPlan.Items[index].SubItems[2].Text)); //( ͡⊙ ͜ʖ ͡⊙)﻿
                }
                //if weight is null
                else
                {
                    points = points + Func.calcPoints(Convert.ToInt32(txtRep.Text));
                }

                //update selected item from listview
                //if current index is not greater than itemcount
                if (index < lvPlan.Items.Count - 1)
                {
                    //select next item (active)
                    lvPlan.Items[index + 1].Selected = true;
                }
                if (index >= 0)
                {
                    //clear selection from previous item
                    lvPlan.Items[index].Selected = false;
                }
                //increment index
                index++;

                //select textbox
                txtRep.Select();
                //empty textbox for new input
                txtRep.Text = "";
            }   
        }



        //button enter data
        private void btnConf_Click(object sender, EventArgs e)
        {
            if (txtRep.Text != "")
            {
                enterNext();
            }
        }

        //button enter data alternative
        private void txtRep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && isLoaded && txtRep.Text != "")
            {
                enterNext();
            }
        }

        private void planLadenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadPlan();
        }

        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hier kann ein bestehender Trainingsplan geladen werden, um dann die Übungen der Reihe nach durchzugehen. "
                + "Für jede Übung wird die Anzahl der erreichten Wiederholungen in das entsprechende Textfeld eingetragen. " 
                + "Tipp: Die Eingabe kann auch mit 'Enter' bestätigt werden!", "Hilfe");
        }
    }
}
