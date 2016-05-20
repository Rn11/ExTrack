namespace ExTrack
{
    partial class WorkoutFixed
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkoutFixed));
            this.txtRep = new System.Windows.Forms.TextBox();
            this.lblReps = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvPlan = new System.Windows.Forms.ListView();
            this.planHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.planHeaderRep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.planHeaderWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnConf = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.planLadenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRep
            // 
            this.txtRep.Location = new System.Drawing.Point(88, 64);
            this.txtRep.Name = "txtRep";
            this.txtRep.Size = new System.Drawing.Size(42, 20);
            this.txtRep.TabIndex = 0;
            this.txtRep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRep_KeyDown);
            // 
            // lblReps
            // 
            this.lblReps.AutoSize = true;
            this.lblReps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReps.Location = new System.Drawing.Point(61, 37);
            this.lblReps.Name = "lblReps";
            this.lblReps.Size = new System.Drawing.Size(98, 15);
            this.lblReps.TabIndex = 1;
            this.lblReps.Text = "Wiederholungen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvPlan);
            this.groupBox2.Location = new System.Drawing.Point(12, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 313);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trainingsplan";
            // 
            // lvPlan
            // 
            this.lvPlan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.planHeaderName,
            this.planHeaderRep,
            this.planHeaderWeight});
            this.lvPlan.FullRowSelect = true;
            this.lvPlan.GridLines = true;
            this.lvPlan.HideSelection = false;
            this.lvPlan.Location = new System.Drawing.Point(6, 19);
            this.lvPlan.Name = "lvPlan";
            this.lvPlan.ShowItemToolTips = true;
            this.lvPlan.Size = new System.Drawing.Size(340, 286);
            this.lvPlan.TabIndex = 0;
            this.lvPlan.UseCompatibleStateImageBehavior = false;
            this.lvPlan.View = System.Windows.Forms.View.Details;
            // 
            // planHeaderName
            // 
            this.planHeaderName.Text = "Name";
            this.planHeaderName.Width = 152;
            // 
            // planHeaderRep
            // 
            this.planHeaderRep.Text = "Wiederholungen";
            this.planHeaderRep.Width = 101;
            // 
            // planHeaderWeight
            // 
            this.planHeaderWeight.Text = "Gewicht";
            this.planHeaderWeight.Width = 69;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.btnConf);
            this.groupBox1.Controls.Add(this.txtRep);
            this.groupBox1.Controls.Add(this.lblReps);
            this.groupBox1.Location = new System.Drawing.Point(370, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 313);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(67, 218);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(82, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Plan laden";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnConf
            // 
            this.btnConf.Enabled = false;
            this.btnConf.Location = new System.Drawing.Point(67, 166);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(82, 45);
            this.btnConf.TabIndex = 2;
            this.btnConf.Text = "Eingeben";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planLadenToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // planLadenToolStripMenuItem
            // 
            this.planLadenToolStripMenuItem.Name = "planLadenToolStripMenuItem";
            this.planLadenToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.planLadenToolStripMenuItem.Text = "Plan laden";
            this.planLadenToolStripMenuItem.Click += new System.EventHandler(this.planLadenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            this.hilfeToolStripMenuItem.Click += new System.EventHandler(this.hilfeToolStripMenuItem_Click);
            // 
            // WorkoutFixed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 341);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WorkoutFixed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Workout";
            this.Load += new System.EventHandler(this.Workout_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRep;
        private System.Windows.Forms.Label lblReps;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvPlan;
        private System.Windows.Forms.ColumnHeader planHeaderName;
        private System.Windows.Forms.ColumnHeader planHeaderRep;
        private System.Windows.Forms.ColumnHeader planHeaderWeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem planLadenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
    }
}