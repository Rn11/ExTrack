using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace ExTrack
{
    public partial class MainForm : Form
    {
        public string version = "v1.2.1";
        public int majorVersion = 1;
        public int minorVersion = 2;
        public int patchVersion = 1;


        public MainForm()
        {
            InitializeComponent();
        }

        public void showStats()
        {
            try
            {
                if (File.Exists(Environment.ExpandEnvironmentVariables(@"%AppData%\\ExTrack\") + @"score"))
                {
                    Stats createform = new Stats();
                    createform.Show();
                }
                else
                {
                    MessageBox.Show("Es ist keine Statistik vorhanden!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
        }

        private void btnCreateWorkout_Click(object sender, EventArgs e)
        {     
            try
            {
                if (optFixed.Checked)
                {
                    CreateWorkoutFixed createform = new CreateWorkoutFixed();
                    createform.Show();
                }
                else if (optNotFixed.Checked)
                {
                    CreateWorkoutNotFixed createform = new CreateWorkoutNotFixed();
                    createform.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (optFixed.Checked)
                {
                    WorkoutFixed createform = new WorkoutFixed(this);
                    createform.Show();
                }
                else if (optNotFixed.Checked)
                {
                    WorkoutNotFixed createform = new WorkoutNotFixed(this);
                    createform.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            showStats();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblDate.Text = Convert.ToString(DateTime.Now);

            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack") == false)
            {
                MessageBox.Show("Willkommen! Dies scheint das erste mal für dich zu sein, dass du diese Applikation ausführst. "
                  + "Ich bitte dich unbedingt die Hilfe im Hauptmenü durchzulesen bzw. die Hilfestellungen in den einzelnen Bereichen zu verwenden. "
                  + "Länger will ich dich aber nicht aufhalten - Viel Spaß! :)", "Willkommen!");
            }
            //create fixed rep plan dir
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack\VorgebeneWiederholungen");

            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack\VorgebeneWiederholungen\Vorlagen") == false)
            {
                //create subdir
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack\VorgebeneWiederholungen\Vorlagen");
                //create subdir and expand files
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack\VorgebeneWiederholungen\Vorlagen\Bauch");
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack\VorgebeneWiederholungen\Vorlagen\Bauch\BauchLeicht.txt", Properties.Resources.BauchLeicht);
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack\VorgebeneWiederholungen\Vorlagen\Bauch\BauchMittel.txt", Properties.Resources.BauchMittel);
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack\VorgebeneWiederholungen\Vorlagen\Bauch\BauchSchwer.txt", Properties.Resources.BauchSchwer);

                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack\VorgebeneWiederholungen\Vorlagen\Brust");
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack\VorgebeneWiederholungen\Vorlagen\Brust\BrustLeicht.txt", Properties.Resources.BrustLeicht);
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack\VorgebeneWiederholungen\Vorlagen\Brust\BrustMittel.txt", Properties.Resources.BrustMittel);
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack\VorgebeneWiederholungen\Vorlagen\Brust\BrustSchwer.txt", Properties.Resources.BrustSchwer);

                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack\VorgebeneWiederholungen\Vorlagen\Arme");
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack\VorgebeneWiederholungen\Vorlagen\Arme\ArmeLeicht.txt", Properties.Resources.ArmeLeicht);
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack\VorgebeneWiederholungen\Vorlagen\Arme\ArmeMittel.txt", Properties.Resources.ArmeMedium);
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack\VorgebeneWiederholungen\Vorlagen\Arme\ArmeSchwer.txt", Properties.Resources.ArmeSchwer);
            }
            //create plan without reps dir
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ExTrack\OhneWiederholungen");

            //search for updates
           // update();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
        }

        public string LabelText
        {
            get { return lblStatusTrainingCompleted.Text; }
            set
            {
                lblStatusTrainingCompleted.Text = "Yeah - Training abgeschlossen!";
                lblStatusTrainingCompleted.ForeColor = Color.Green;
            }
        }

        private void btnOpt_Click(object sender, EventArgs e)
        {
            Options createform = new Options();
            createform.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About createform = new About();
            createform.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statistikenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showStats();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About createform = new About();
            createform.Show();
        }

        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dies ist das Hauptmenü. Hier kannst du die verschiedenen Bereiche des Programms aufrufen.\n\nDer eingestellte Modus bestimmt, "
                + "welcher Trainingsmodus bei der Erstellung und Durchführung des Workouts verwendet wird.\n\n"
                +"Der Modus 'Festgelegte Wiederholungsanzahl' beinhaltet Trainingspläne und Workouts, in denen die Wiederholungen vorher von dir bestimmt werden. "
                +"Du versuchst dabei, die vorgegebene Anzahl der Wdh. einzuhalten bzw. zu erreichen.\n\n"
                + "Der Modus 'Keine festgelegten Wiederholungen' bietet dir die Möglichkeit, Pläne ohne vorgebene Wdh. zu erstellen. "
                + "Im Workout gibst du dann deine erreichten Wdh. an und wiederholst die aktive Übung so lange, bis du die nächste Übung aktivierst.", "Hilfe");
        }

        private void update()
        {
            for (int i = 1; i <= 3; i++)
            {
                string tmpVer = "";
                switch (i)
                {
                    case 1:
                        //check majVer
                         tmpVer = "v" + (majorVersion + 1).ToString() + ".0.0";
                        break;
                    case 2:
                        //check minVer
                        tmpVer = "v" + majorVersion.ToString() + "." + (minorVersion + 1).ToString() + ".0";
                        break;
                    case 3:
                        //check patchVer
                        tmpVer = "v" + majorVersion.ToString() + "." + minorVersion.ToString() + "." + (patchVersion + 1).ToString();
                        break;
                    default:
                        break;
                }

                    //check if url to newer file exists, if not update
                if (RemoteFileExists(tmpVer))
                {
                    MessageBox.Show("update verfügbar " + version);
                    i = +100;
                }
                else
                {
                }
            }
        }

        private bool RemoteFileExists(string version)
        {
            try
            { 
                    //combine git url and version
                    HttpWebRequest request = WebRequest.Create("https://github.com/Rn11/ExTrack-Release/releases/download/" + version + "/ExTrack.exe") as HttpWebRequest;
                MessageBox.Show("https://github.com/Rn11/ExTrack-Release/releases/download/" + version + "/ExTrack.exe");
                    request.Method = "HEAD";
                    HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                    //returns true if status code == 200
                    response.Close();
                    return (response.StatusCode == HttpStatusCode.OK);
            }
            catch
            {
                return false;
            }
        }
    }
}
