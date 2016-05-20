namespace ExTrack
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.btnDonate = new System.Windows.Forms.Button();
            this.lblThanks = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblVer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDonate
            // 
            this.btnDonate.BackColor = System.Drawing.Color.Transparent;
            this.btnDonate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDonate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDonate.FlatAppearance.BorderSize = 0;
            this.btnDonate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonate.Image = global::ExTrack.Properties.Resources.btnDonate;
            this.btnDonate.Location = new System.Drawing.Point(0, 160);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(392, 39);
            this.btnDonate.TabIndex = 7;
            this.btnDonate.UseVisualStyleBackColor = false;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Location = new System.Drawing.Point(12, 67);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(365, 78);
            this.lblThanks.TabIndex = 8;
            this.lblThanks.Text = resources.GetString("lblThanks.Text");
            this.lblThanks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(141, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 29);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "ExTrack";
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Location = new System.Drawing.Point(152, 38);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(69, 13);
            this.lblVer.TabIndex = 10;
            this.lblVer.Text = "Version 1.0.0";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 199);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblThanks);
            this.Controls.Add(this.btnDonate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblVer;
    }
}