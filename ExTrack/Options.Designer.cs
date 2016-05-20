namespace ExTrack
{
    partial class Options
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
            this.optJohnCena = new System.Windows.Forms.RadioButton();
            this.optTripleH = new System.Windows.Forms.RadioButton();
            this.optBatman = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblEE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // optJohnCena
            // 
            this.optJohnCena.AutoSize = true;
            this.optJohnCena.Location = new System.Drawing.Point(86, 49);
            this.optJohnCena.Name = "optJohnCena";
            this.optJohnCena.Size = new System.Drawing.Size(76, 17);
            this.optJohnCena.TabIndex = 0;
            this.optJohnCena.Text = "John Cena";
            this.optJohnCena.UseVisualStyleBackColor = true;
            // 
            // optTripleH
            // 
            this.optTripleH.AutoSize = true;
            this.optTripleH.Location = new System.Drawing.Point(86, 72);
            this.optTripleH.Name = "optTripleH";
            this.optTripleH.Size = new System.Drawing.Size(62, 17);
            this.optTripleH.TabIndex = 1;
            this.optTripleH.TabStop = true;
            this.optTripleH.Text = "Triple H";
            this.optTripleH.UseVisualStyleBackColor = true;
            // 
            // optBatman
            // 
            this.optBatman.AutoSize = true;
            this.optBatman.Location = new System.Drawing.Point(86, 95);
            this.optBatman.Name = "optBatman";
            this.optBatman.Size = new System.Drawing.Size(61, 17);
            this.optBatman.TabIndex = 2;
            this.optBatman.TabStop = true;
            this.optBatman.Text = "Batman";
            this.optBatman.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(67, 139);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(106, 40);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Übernehmen";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblEE
            // 
            this.lblEE.AutoSize = true;
            this.lblEE.Location = new System.Drawing.Point(46, 19);
            this.lblEE.Name = "lblEE";
            this.lblEE.Size = new System.Drawing.Size(172, 13);
            this.lblEE.TabIndex = 4;
            this.lblEE.Text = "Wähle deinen Helden (easter egg!)";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 191);
            this.Controls.Add(this.lblEE);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.optBatman);
            this.Controls.Add(this.optTripleH);
            this.Controls.Add(this.optJohnCena);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optJohnCena;
        private System.Windows.Forms.RadioButton optTripleH;
        private System.Windows.Forms.RadioButton optBatman;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblEE;
    }
}