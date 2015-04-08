namespace CTGUI.PANEL
{
    partial class ColumnWeather
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
            this.lblDay = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHI = new System.Windows.Forms.Label();
            this.imgWeather = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDayNumber = new System.Windows.Forms.Label();
            this.lblMese = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDay
            // 
            this.lblDay.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.Location = new System.Drawing.Point(0, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(149, 23);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "SAT";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.ForeColor = System.Drawing.Color.White;
            this.lblLow.Location = new System.Drawing.Point(74, 101);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(57, 38);
            this.lblLow.TabIndex = 12;
            this.lblLow.Text = "LO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "HI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "LO";
            // 
            // lblHI
            // 
            this.lblHI.AutoSize = true;
            this.lblHI.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHI.ForeColor = System.Drawing.Color.White;
            this.lblHI.Location = new System.Drawing.Point(74, 63);
            this.lblHI.Name = "lblHI";
            this.lblHI.Size = new System.Drawing.Size(49, 38);
            this.lblHI.TabIndex = 11;
            this.lblHI.Text = "HI";
            // 
            // imgWeather
            // 
            this.imgWeather.Location = new System.Drawing.Point(45, 26);
            this.imgWeather.Name = "imgWeather";
            this.imgWeather.Size = new System.Drawing.Size(61, 34);
            this.imgWeather.TabIndex = 1;
            this.imgWeather.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CTGUI.Properties.Resources.calendar;
            this.pictureBox1.Location = new System.Drawing.Point(45, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblDayNumber
            // 
            this.lblDayNumber.BackColor = System.Drawing.Color.White;
            this.lblDayNumber.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayNumber.Location = new System.Drawing.Point(54, 190);
            this.lblDayNumber.Name = "lblDayNumber";
            this.lblDayNumber.Size = new System.Drawing.Size(44, 29);
            this.lblDayNumber.TabIndex = 14;
            this.lblDayNumber.Text = "31";
            this.lblDayNumber.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblMese
            // 
            this.lblMese.BackColor = System.Drawing.Color.Black;
            this.lblMese.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMese.ForeColor = System.Drawing.Color.White;
            this.lblMese.Location = new System.Drawing.Point(54, 171);
            this.lblMese.Name = "lblMese";
            this.lblMese.Size = new System.Drawing.Size(33, 17);
            this.lblMese.TabIndex = 15;
            this.lblMese.Text = "APR";
            // 
            // ColumnWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblMese);
            this.Controls.Add(this.lblDayNumber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHI);
            this.Controls.Add(this.imgWeather);
            this.Controls.Add(this.lblDay);
            this.Name = "ColumnWeather";
            this.Size = new System.Drawing.Size(150, 232);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ColumnWeather_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.imgWeather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.PictureBox imgWeather;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDayNumber;
        private System.Windows.Forms.Label lblMese;
    }
}
