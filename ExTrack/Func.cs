using System;
using System.IO;
using System.Windows.Forms;

namespace ExTrack
{
    class Func
    {
        protected static string openFileName;
        protected static string saveFileName;
        protected static bool append = true;

        //---------------------------------------------------------------------
        //-----------------------Methods for loading---------------------------
        //---------------------------------------------------------------------
        public static int countLines(string path)
        {
            int count = 0;
            StreamReader sr = new StreamReader(path);
            while (sr.ReadLine() != null) { count++; }
            sr.Close();
            return (count - 2);
        }

        public static void setOpenFileName()
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack";
            dlgOpen.Filter = "text files|*.txt";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                openFileName = dlgOpen.FileName;
            }
        }

        public static void setOpenFileName(string filename)
        {
            //set openFileName with manual filename (needed to load statistics!)
            if (filename != null)
            {
                openFileName = filename;
            }
        }

        public static void setOpenFileName(bool isFixed)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            if (isFixed)
            {
                dlgOpen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack\VorgebeneWiederholungen";
            }
            else if (isFixed != true)
            {
                dlgOpen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack\OhneWiederholungen";
            }
            dlgOpen.Filter = "text files|*.txt";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                openFileName = dlgOpen.FileName;
            }
        }

        public static string getOpenFileName()
        {
            return openFileName;
        }

        //---------------------------------------------------------------------
        //------------------------Methods for Saving---------------------------
        //---------------------------------------------------------------------

        public static void setSaveFileName()
        {
            SaveFileDialog dlgSave = new SaveFileDialog();

            dlgSave.Filter = "text files|*.txt|All files (*.*)|*.*";
            dlgSave.FileName = "trainingsplan_01.txt";
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                append = false;
                saveFileName = dlgSave.FileName;
            }
        }

        public static void setSaveFileName(bool isFixed)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();

            dlgSave.Filter = "text files|*.txt|All files (*.*)|*.*";
            if (isFixed)
            {
                dlgSave.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack\VorgebeneWiederholungen";
            }
            else if (isFixed != true)
            {
                dlgSave.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack\OhneWiederholungen";
            }
            dlgSave.FileName = "trainingsplan_01.txt";
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                append = false;
                saveFileName = dlgSave.FileName;
            }
        }

        public static string getSaveFileName()
        {
            return saveFileName;
        }

        public static bool getStateSaveAppend()
        {
            return append;
        }


        //---------------------------------------------------------------------
        //---------------------Methods for calcPoints--------------------------
        //---------------------------------------------------------------------
        public static double calcPoints(int reps, int weight)
        {
            double points = 0;
            //if weight is given AND weight is not greater than 51, add weight and multiply by 0.9
            if (weight < 51)
            {
                points = (reps + weight) * 0.9;
            }
            //if weight is greater than 51, add weight and reps and multiply by 0.45 
            else if (weight > 51)
            {
                points = (reps + weight) * 0.45;
            }
                return points;
        }

        public static double calcPoints(int reps)
        {
            double points = 0;
            //if no weight is given, add 6 to reps (est. min. 11 - est. max. 31)
            points = reps + 6;
            return points;
        }


    }
}
