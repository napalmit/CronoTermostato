namespace CTGUI.PANEL
{
    partial class MenuSinistra
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelA = new System.Windows.Forms.Panel();
            this.panelRigaBianca = new System.Windows.Forms.Panel();
            this.panelB = new System.Windows.Forms.Panel();
            this.panelC = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelA.SuspendLayout();
            this.panelB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelA
            // 
            this.panelA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(93)))));
            this.panelA.Controls.Add(this.button1);
            this.panelA.Location = new System.Drawing.Point(0, 0);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(180, 600);
            this.panelA.TabIndex = 0;
            // 
            // panelRigaBianca
            // 
            this.panelRigaBianca.BackColor = System.Drawing.Color.White;
            this.panelRigaBianca.Location = new System.Drawing.Point(180, 0);
            this.panelRigaBianca.Name = "panelRigaBianca";
            this.panelRigaBianca.Size = new System.Drawing.Size(2, 600);
            this.panelRigaBianca.TabIndex = 1;
            // 
            // panelB
            // 
            this.panelB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(93)))));
            this.panelB.Controls.Add(this.panelC);
            this.panelB.Location = new System.Drawing.Point(180, 250);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(50, 100);
            this.panelB.TabIndex = 2;
            this.panelB.Click += new System.EventHandler(this.panelB_Click);
            // 
            // panelC
            // 
            this.panelC.BackColor = System.Drawing.Color.White;
            this.panelC.Location = new System.Drawing.Point(49, 0);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(2, 100);
            this.panelC.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(180, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 2);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(180, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 2);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 151);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MenuSinistra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelB);
            this.Controls.Add(this.panelRigaBianca);
            this.Controls.Add(this.panelA);
            this.Name = "MenuSinistra";
            this.Size = new System.Drawing.Size(182, 600);
            this.panelA.ResumeLayout(false);
            this.panelB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Panel panelRigaBianca;
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelC;
        private System.Windows.Forms.Button button1;
    }
}
