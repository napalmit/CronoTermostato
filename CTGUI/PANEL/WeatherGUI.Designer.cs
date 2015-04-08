namespace CTGUI.PANEL
{
    partial class WeatherGUI
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
            this.panelC = new System.Windows.Forms.Panel();
            this.panelB = new System.Windows.Forms.Panel();
            this.lblLowToday = new System.Windows.Forms.Label();
            this.lblScalaHumidityToday = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValueUmidityToday = new System.Windows.Forms.Label();
            this.lblHIToday = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblValueTemperaturaToday = new System.Windows.Forms.Label();
            this.imgStateWeatherToday = new System.Windows.Forms.PictureBox();
            this.panelA = new System.Windows.Forms.Panel();
            this.columnWeather4 = new CTGUI.PANEL.ColumnWeather();
            this.columnWeather3 = new CTGUI.PANEL.ColumnWeather();
            this.columnWeather2 = new CTGUI.PANEL.ColumnWeather();
            this.columnWeather1 = new CTGUI.PANEL.ColumnWeather();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.panelB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStateWeatherToday)).BeginInit();
            this.panelA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelC
            // 
            this.panelC.Location = new System.Drawing.Point(671, 38);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(80, 80);
            this.panelC.TabIndex = 2;
            this.panelC.Paint += new System.Windows.Forms.PaintEventHandler(this.panelC_Paint);
            // 
            // panelB
            // 
            this.panelB.BackColor = System.Drawing.Color.Transparent;
            this.panelB.Controls.Add(this.lblLowToday);
            this.panelB.Controls.Add(this.lblScalaHumidityToday);
            this.panelB.Controls.Add(this.label1);
            this.panelB.Controls.Add(this.label2);
            this.panelB.Controls.Add(this.lblValueUmidityToday);
            this.panelB.Controls.Add(this.lblHIToday);
            this.panelB.Controls.Add(this.lblHumidity);
            this.panelB.Controls.Add(this.lblValueTemperaturaToday);
            this.panelB.Controls.Add(this.imgStateWeatherToday);
            this.panelB.Location = new System.Drawing.Point(0, 38);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(671, 195);
            this.panelB.TabIndex = 1;
            this.panelB.Paint += new System.Windows.Forms.PaintEventHandler(this.panelB_Paint);
            // 
            // lblLowToday
            // 
            this.lblLowToday.AutoSize = true;
            this.lblLowToday.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowToday.ForeColor = System.Drawing.Color.White;
            this.lblLowToday.Location = new System.Drawing.Point(573, 155);
            this.lblLowToday.Name = "lblLowToday";
            this.lblLowToday.Size = new System.Drawing.Size(57, 38);
            this.lblLowToday.TabIndex = 8;
            this.lblLowToday.Text = "LO";
            // 
            // lblScalaHumidityToday
            // 
            this.lblScalaHumidityToday.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScalaHumidityToday.ForeColor = System.Drawing.Color.White;
            this.lblScalaHumidityToday.Location = new System.Drawing.Point(598, 6);
            this.lblScalaHumidityToday.Name = "lblScalaHumidityToday";
            this.lblScalaHumidityToday.Size = new System.Drawing.Size(34, 26);
            this.lblScalaHumidityToday.TabIndex = 6;
            this.lblScalaHumidityToday.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(518, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "HI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(518, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "LO";
            // 
            // lblValueUmidityToday
            // 
            this.lblValueUmidityToday.Font = new System.Drawing.Font("Montserrat", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueUmidityToday.ForeColor = System.Drawing.Color.White;
            this.lblValueUmidityToday.Location = new System.Drawing.Point(495, -10);
            this.lblValueUmidityToday.Name = "lblValueUmidityToday";
            this.lblValueUmidityToday.Size = new System.Drawing.Size(121, 76);
            this.lblValueUmidityToday.TabIndex = 7;
            this.lblValueUmidityToday.Text = "88";
            // 
            // lblHIToday
            // 
            this.lblHIToday.AutoSize = true;
            this.lblHIToday.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHIToday.ForeColor = System.Drawing.Color.White;
            this.lblHIToday.Location = new System.Drawing.Point(573, 107);
            this.lblHIToday.Name = "lblHIToday";
            this.lblHIToday.Size = new System.Drawing.Size(49, 38);
            this.lblHIToday.TabIndex = 7;
            this.lblHIToday.Text = "HI";
            // 
            // lblHumidity
            // 
            this.lblHumidity.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(39)))));
            this.lblHumidity.Location = new System.Drawing.Point(488, 65);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(150, 32);
            this.lblHumidity.TabIndex = 10;
            this.lblHumidity.Text = "Humidity";
            this.lblHumidity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblValueTemperaturaToday
            // 
            this.lblValueTemperaturaToday.Font = new System.Drawing.Font("Montserrat", 80.24999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueTemperaturaToday.ForeColor = System.Drawing.Color.White;
            this.lblValueTemperaturaToday.Location = new System.Drawing.Point(189, 40);
            this.lblValueTemperaturaToday.Name = "lblValueTemperaturaToday";
            this.lblValueTemperaturaToday.Size = new System.Drawing.Size(323, 126);
            this.lblValueTemperaturaToday.TabIndex = 8;
            this.lblValueTemperaturaToday.Text = "88,8";
            this.lblValueTemperaturaToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgStateWeatherToday
            // 
            this.imgStateWeatherToday.BackColor = System.Drawing.Color.Transparent;
            this.imgStateWeatherToday.Location = new System.Drawing.Point(28, 29);
            this.imgStateWeatherToday.Name = "imgStateWeatherToday";
            this.imgStateWeatherToday.Size = new System.Drawing.Size(250, 160);
            this.imgStateWeatherToday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStateWeatherToday.TabIndex = 7;
            this.imgStateWeatherToday.TabStop = false;
            // 
            // panelA
            // 
            this.panelA.BackColor = System.Drawing.Color.Transparent;
            this.panelA.Controls.Add(this.columnWeather4);
            this.panelA.Controls.Add(this.columnWeather3);
            this.panelA.Controls.Add(this.columnWeather2);
            this.panelA.Controls.Add(this.columnWeather1);
            this.panelA.Location = new System.Drawing.Point(0, 118);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(750, 380);
            this.panelA.TabIndex = 0;
            this.panelA.Paint += new System.Windows.Forms.PaintEventHandler(this.panelA_Paint);
            // 
            // columnWeather4
            // 
            this.columnWeather4.BackColor = System.Drawing.Color.Transparent;
            this.columnWeather4.Location = new System.Drawing.Point(564, 146);
            this.columnWeather4.Name = "columnWeather4";
            this.columnWeather4.Size = new System.Drawing.Size(148, 230);
            this.columnWeather4.TabIndex = 3;
            // 
            // columnWeather3
            // 
            this.columnWeather3.BackColor = System.Drawing.Color.Transparent;
            this.columnWeather3.Location = new System.Drawing.Point(382, 146);
            this.columnWeather3.Name = "columnWeather3";
            this.columnWeather3.Size = new System.Drawing.Size(148, 230);
            this.columnWeather3.TabIndex = 2;
            // 
            // columnWeather2
            // 
            this.columnWeather2.BackColor = System.Drawing.Color.Transparent;
            this.columnWeather2.Location = new System.Drawing.Point(201, 146);
            this.columnWeather2.Name = "columnWeather2";
            this.columnWeather2.Size = new System.Drawing.Size(148, 230);
            this.columnWeather2.TabIndex = 1;
            // 
            // columnWeather1
            // 
            this.columnWeather1.BackColor = System.Drawing.Color.Transparent;
            this.columnWeather1.Location = new System.Drawing.Point(19, 146);
            this.columnWeather1.Name = "columnWeather1";
            this.columnWeather1.Size = new System.Drawing.Size(148, 230);
            this.columnWeather1.TabIndex = 0;
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.AutoSize = true;
            this.lblTodayDate.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDate.ForeColor = System.Drawing.Color.White;
            this.lblTodayDate.Location = new System.Drawing.Point(-1, -1);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(135, 38);
            this.lblTodayDate.TabIndex = 4;
            this.lblTodayDate.Text = "INDOOR";
            // 
            // WeatherGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelB);
            this.Controls.Add(this.panelC);
            this.Controls.Add(this.lblTodayDate);
            this.Controls.Add(this.panelA);
            this.Name = "WeatherGUI";
            this.Size = new System.Drawing.Size(752, 503);
            this.panelB.ResumeLayout(false);
            this.panelB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStateWeatherToday)).EndInit();
            this.panelA.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelC;
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Label lblTodayDate;
        private System.Windows.Forms.PictureBox imgStateWeatherToday;
        private System.Windows.Forms.Label lblValueTemperaturaToday;
        private System.Windows.Forms.Label lblScalaHumidityToday;
        private System.Windows.Forms.Label lblValueUmidityToday;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblLowToday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHIToday;
        private ColumnWeather columnWeather1;
        private ColumnWeather columnWeather4;
        private ColumnWeather columnWeather3;
        private ColumnWeather columnWeather2;
    }
}
