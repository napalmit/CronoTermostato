namespace WindowsFormsApplication4
{
    partial class Form1
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.weatherGUI1 = new WindowsFormsApplication4.WeatherGUI();
            this.SuspendLayout();
            // 
            // weatherGUI1
            // 
            this.weatherGUI1.BackColor = System.Drawing.Color.Transparent;
            this.weatherGUI1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherGUI1.Location = new System.Drawing.Point(178, 44);
            this.weatherGUI1.Name = "weatherGUI1";
            this.weatherGUI1.Size = new System.Drawing.Size(750, 501);
            this.weatherGUI1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.bg_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.weatherGUI1);
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WeatherGUI weatherGUI1;



    }
}

