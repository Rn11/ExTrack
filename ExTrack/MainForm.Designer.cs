namespace ExTrack
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCreateWorkout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatusTrainingCompleted = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnStats = new System.Windows.Forms.Button();
            this.timerDateUpdate = new System.Windows.Forms.Timer(this.components);
            this.btnOpt = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statistikenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.optFixed = new System.Windows.Forms.RadioButton();
            this.optNotFixed = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStart.Location = new System.Drawing.Point(82, 276);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(118, 48);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCreateWorkout
            // 
            this.btnCreateWorkout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateWorkout.Location = new System.Drawing.Point(82, 150);
            this.btnCreateWorkout.Name = "btnCreateWorkout";
            this.btnCreateWorkout.Size = new System.Drawing.Size(118, 48);
            this.btnCreateWorkout.TabIndex = 1;
            this.btnCreateWorkout.Text = "Workoutplan erstellen";
            this.btnCreateWorkout.UseVisualStyleBackColor = true;
            this.btnCreateWorkout.Click += new System.EventHandler(this.btnCreateWorkout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.optNotFixed);
            this.groupBox1.Controls.Add(this.optFixed);
            this.groupBox1.Controls.Add(this.lblMode);
            this.groupBox1.Controls.Add(this.lblStatusTrainingCompleted);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Location = new System.Drawing.Point(7, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 120);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // lblStatusTrainingCompleted
            // 
            this.lblStatusTrainingCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusTrainingCompleted.ForeColor = System.Drawing.Color.Red;
            this.lblStatusTrainingCompleted.Location = new System.Drawing.Point(19, 36);
            this.lblStatusTrainingCompleted.Name = "lblStatusTrainingCompleted";
            this.lblStatusTrainingCompleted.Size = new System.Drawing.Size(224, 31);
            this.lblStatusTrainingCompleted.TabIndex = 1;
            this.lblStatusTrainingCompleted.Text = "Training noch nicht abgeschlossen. Just do it!\r\n";
            this.lblStatusTrainingCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDate.Location = new System.Drawing.Point(40, 16);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(174, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "00.00.0000 00:00:00";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStats
            // 
            this.btnStats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStats.Location = new System.Drawing.Point(82, 204);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(118, 48);
            this.btnStats.TabIndex = 4;
            this.btnStats.Text = "Statistiken";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // timerDateUpdate
            // 
            this.timerDateUpdate.Enabled = true;
            this.timerDateUpdate.Interval = 1000;
            this.timerDateUpdate.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnOpt
            // 
            this.btnOpt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpt.Location = new System.Drawing.Point(82, 349);
            this.btnOpt.Name = "btnOpt";
            this.btnOpt.Size = new System.Drawing.Size(118, 29);
            this.btnOpt.TabIndex = 5;
            this.btnOpt.Text = "Optionen";
            this.btnOpt.UseVisualStyleBackColor = true;
            this.btnOpt.Click += new System.EventHandler(this.btnOpt_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(82, 384);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(118, 29);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(5, 87);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(42, 13);
            this.lblMode.TabIndex = 2;
            this.lblMode.Text = "Modus:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statistikenToolStripMenuItem,
            this.hilfeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(281, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statistikenToolStripMenuItem
            // 
            this.statistikenToolStripMenuItem.Name = "statistikenToolStripMenuItem";
            this.statistikenToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.statistikenToolStripMenuItem.Text = "Statistiken";
            this.statistikenToolStripMenuItem.Click += new System.EventHandler(this.statistikenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            this.hilfeToolStripMenuItem.Click += new System.EventHandler(this.hilfeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(82, 419);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 29);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Beenden";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // optFixed
            // 
            this.optFixed.AutoSize = true;
            this.optFixed.Checked = true;
            this.optFixed.Location = new System.Drawing.Point(53, 74);
            this.optFixed.Name = "optFixed";
            this.optFixed.Size = new System.Drawing.Size(161, 17);
            this.optFixed.TabIndex = 3;
            this.optFixed.TabStop = true;
            this.optFixed.Text = "Festgelegte Wiederholungen";
            this.optFixed.UseVisualStyleBackColor = true;
            // 
            // optNotFixed
            // 
            this.optNotFixed.AutoSize = true;
            this.optNotFixed.Location = new System.Drawing.Point(53, 97);
            this.optNotFixed.Name = "optNotFixed";
            this.optNotFixed.Size = new System.Drawing.Size(194, 17);
            this.optNotFixed.TabIndex = 4;
            this.optNotFixed.Text = "Keine festgelegten Wiederholungen";
            this.optNotFixed.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(281, 457);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnOpt);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreateWorkout);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExTrack";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCreateWorkout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timerDateUpdate;
        private System.Windows.Forms.Label lblStatusTrainingCompleted;
        private System.Windows.Forms.Button btnOpt;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem statistikenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton optNotFixed;
        private System.Windows.Forms.RadioButton optFixed;
    }
}

