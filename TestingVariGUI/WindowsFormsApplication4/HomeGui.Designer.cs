namespace WindowsFormsApplication4
{
    partial class HomeGui
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
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.panelB = new System.Windows.Forms.Panel();
            this.panelC = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScalaTemperatura = new System.Windows.Forms.Label();
            this.imgSystem = new System.Windows.Forms.PictureBox();
            this.panelA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSystem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelA
            // 
            this.panelA.BackColor = System.Drawing.Color.Transparent;
            this.panelA.Controls.Add(this.imgSystem);
            this.panelA.Controls.Add(this.lblScalaTemperatura);
            this.panelA.Controls.Add(this.lblTemperatura);
            this.panelA.Location = new System.Drawing.Point(0, 35);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(750, 287);
            this.panelA.TabIndex = 0;
            this.panelA.Paint += new System.Windows.Forms.PaintEventHandler(this.panelA_Paint);
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.Font = new System.Drawing.Font("Montserrat", 180F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.ForeColor = System.Drawing.Color.White;
            this.lblTemperatura.Location = new System.Drawing.Point(-21, -24);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(629, 273);
            this.lblTemperatura.TabIndex = 0;
            this.lblTemperatura.Text = "88,8";
            // 
            // panelB
            // 
            this.panelB.BackColor = System.Drawing.Color.Transparent;
            this.panelB.Location = new System.Drawing.Point(79, 321);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(671, 80);
            this.panelB.TabIndex = 1;
            this.panelB.Paint += new System.Windows.Forms.PaintEventHandler(this.panelB_Paint);
            // 
            // panelC
            // 
            this.panelC.Location = new System.Drawing.Point(0, 322);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(80, 80);
            this.panelC.TabIndex = 2;
            this.panelC.Paint += new System.Windows.Forms.PaintEventHandler(this.panelC_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "INDOOR";
            // 
            // lblScalaTemperatura
            // 
            this.lblScalaTemperatura.Font = new System.Drawing.Font("Montserrat", 41.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScalaTemperatura.ForeColor = System.Drawing.Color.White;
            this.lblScalaTemperatura.Location = new System.Drawing.Point(520, 15);
            this.lblScalaTemperatura.Name = "lblScalaTemperatura";
            this.lblScalaTemperatura.Size = new System.Drawing.Size(88, 61);
            this.lblScalaTemperatura.TabIndex = 1;
            this.lblScalaTemperatura.Text = "°C";
            // 
            // imgSystem
            // 
            this.imgSystem.Image = global::WindowsFormsApplication4.Properties.Resources.system1;
            this.imgSystem.Location = new System.Drawing.Point(626, 43);
            this.imgSystem.Name = "imgSystem";
            this.imgSystem.Size = new System.Drawing.Size(100, 78);
            this.imgSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSystem.TabIndex = 2;
            this.imgSystem.TabStop = false;
            // 
            // HomeGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelA);
            this.Controls.Add(this.panelC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelB);
            this.Name = "HomeGui";
            this.Size = new System.Drawing.Size(750, 518);
            this.panelA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSystem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.Panel panelC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblScalaTemperatura;
        private System.Windows.Forms.PictureBox imgSystem;
    }
}
