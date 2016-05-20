using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Globalization;


namespace ExTrack
{
    public partial class CreateWorkoutFixed : Form
    {
        public CreateWorkoutFixed()
        {
            InitializeComponent();
        }

        public int countLines()
        {
            int count = 0;
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + @"\trainingsplan.txt");
            while (sr.ReadLine() != null) { count++; }
            sr.Close();
            //correct empty lines
            return (count - 2);
        }

        public void loadPlan()
        {
            Func.setOpenFileName(true);
            string fileName = Func.getOpenFileName();
            if (fileName != null)
            {
                try
                {
                    StreamReader sr = new StreamReader(Func.getOpenFileName());

                    //get length
                    int lineCount = Func.countLines(Func.getOpenFileName());
                    lvPlan.Items.Clear();
                    //write line
                    for (int lines = 0; lineCount >= lines; lines++)
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler: " + ex.Message);
                }
            }
        }

        public void savePlan()
        {
            Func.setSaveFileName(true);
            string fileName = Func.getSaveFileName();

            if (fileName != null)
            {
                StreamWriter sw = new StreamWriter(Func.getSaveFileName(), Func.getStateSaveAppend());
                StringBuilder sb;

                if (lvPlan.Items.Count > 0)
                {
                    foreach (ListViewItem lvi in lvPlan.Items)
                    {
                        sb = new StringBuilder();
                        foreach (ListViewItem.ListViewSubItem listViewSubItem in lvi.SubItems)
                        {
                            sb.Append(string.Format("{0}\t", listViewSubItem.Text));
                        }
                        sw.WriteLine(sb.ToString());
                    }
                    sw.WriteLine();
                    sw.Close();
                }
            }
        }


        //uebung hinzufuegen
        public void addEx(string name)
        {
            ListViewItem lvi = new ListViewItem(name);
            lvi.SubItems.Add(txtRep.Text);
            if (tcPool.SelectedIndex != 1)
            {
                if (txtWeight.Text != "")
                {
                    lvi.SubItems.Add(txtWeight.Text);
                    lvPlan.Items.Add(lvi);
                }

                else
                {
                    MessageBox.Show("Es muss ein Gewicht angegeben werden!");
                    lvPlan.SelectedIndices.Clear();
                }
            }
            else if (tcPool.SelectedIndex == 1)
            {
                lvPlan.Items.Add(lvi);
            }
        }

        private void btnAddElement_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvPoolBody.SelectedItems.Count > 0 || lvPoolDumbbell.SelectedItems.Count > 0)
                {
                    if (txtRep.Text != "" && Convert.ToInt32(txtRep.Text) != 0)
                    {
                        if (tcPool.SelectedIndex != 1)
                        {
                            addEx((Convert.ToString(lvPoolDumbbell.SelectedItems[0].Text)));
                        }
                        else if (tcPool.SelectedIndex == 1)
                        {
                            addEx((Convert.ToString(lvPoolBody.SelectedItems[0].Text)));
                        }
                    }

                    else
                    {
                        MessageBox.Show("Es muss die Anzahl der Wiederholungen angegeben werden!");
                        lvPlan.SelectedIndices.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Keine Übung ausgewählt!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvPlan.SelectedItems)
            {
                if (lvi.Index >= 0)
                {
                    int index = 0;
                    if (lvi.Index == 0)
                    {
                        index = lvi.Index;
                    }
                    else
                    {

                        index = lvi.Index - 1;
                    }
                    lvPlan.Items.RemoveAt(lvi.Index);
                    lvPlan.Items.Insert(index, lvi);
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvPlan.SelectedItems)
            {
                if (lvi.Index >= 0 && lvPlan.Items.Count - 1 >= lvi.Index + 1)
                {
                    int index = lvi.Index + 1;
                    lvPlan.Items.RemoveAt(lvi.Index);
                    lvPlan.Items.Insert(index, lvi);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                savePlan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadPlan();
            lvPlan.Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Möchten Sie ihren Trainingsplan verwerfen?", "Trainingsplan löschen?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                lvPlan.Items.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selected in lvPlan.SelectedItems)
            {
                lvPlan.Items.Remove(selected);
            }
        }

        private void planSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                savePlan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex);
            }
        }

        private void planLeerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Möchten Sie ihren Trainingsplan verwerfen?", "Trainingsplan löschen?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                lvPlan.Items.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void planLadenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadPlan();
            lvPlan.Refresh();
        }

        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In diesem Fenster können Übungen aus dem Übungspool (links) einem Entwurf hinzugefügt werden (rechts)."
                + "Übungen im Entwurf können über die Pfeile verschoben oder ggf. entfernt werden. Die Schaltfläche 'Plan leeren' entfernt "
                + "alle Elemente aus dem aktuellen Entwurf.\nTipp: Die Übungen können alphabetisch nach Namen bzw. Muskel sortiert werden!", "Hilfe");
        }

        private void lvPoolDumbbell_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //ich hätte einfach ein object list view benutzen sollen... jfc! -.-
            //thx @stackoverflow
            this.lvPoolDumbbell.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        class ListViewItemComparer : IComparer
        {
            private int col = 0;

            public ListViewItemComparer(int column)
            {
                col = column;
            }
            public int Compare(object x, object y)
            {
                return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }
        }
    }
}





