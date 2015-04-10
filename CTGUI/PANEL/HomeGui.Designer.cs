using System.Windows.Forms;
namespace CTGUI.PANEL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeGui));
            this.panelA = new System.Windows.Forms.Panel();
            this.lblHtmlTemperatura = new TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel();
            this.imgStatoCaldaia = new System.Windows.Forms.PictureBox();
            this.imgStateWeather = new System.Windows.Forms.PictureBox();
            this.lblValueTemperatura = new System.Windows.Forms.Label();
            this.panelC = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTypeSystem = new System.Windows.Forms.Label();
            this.imgSystem = new System.Windows.Forms.PictureBox();
            this.lblValueUmidity = new System.Windows.Forms.Label();
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblScalaHumidity = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.panelB = new System.Windows.Forms.Panel();
            this.panelA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatoCaldaia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStateWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSystem)).BeginInit();
            this.panelB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelA
            // 
            this.panelA.BackColor = System.Drawing.Color.Transparent;
            this.panelA.Controls.Add(this.lblHtmlTemperatura);
            this.panelA.Controls.Add(this.imgStatoCaldaia);
            this.panelA.Controls.Add(this.imgStateWeather);
            this.panelA.Controls.Add(this.lblValueTemperatura);
            this.panelA.Location = new System.Drawing.Point(0, 35);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(750, 287);
            this.panelA.TabIndex = 0;
            this.panelA.Paint += new System.Windows.Forms.PaintEventHandler(this.panelA_Paint);
            // 
            // lblHtmlTemperatura
            // 
            this.lblHtmlTemperatura.BackColor = System.Drawing.Color.Transparent;
            this.lblHtmlTemperatura.BaseStylesheet = null;
            this.lblHtmlTemperatura.Location = new System.Drawing.Point(13, 2);
            this.lblHtmlTemperatura.Name = "lblHtmlTemperatura";
            this.lblHtmlTemperatura.Size = new System.Drawing.Size(517, 272);
            this.lblHtmlTemperatura.TabIndex = 8;
            this.lblHtmlTemperatura.Text = "<span style=\"color: white; font-family: Montserrat; font-size: 170pt\">88,8</span>" +
    "<span style=\"color: white; font-family: Montserrat; font-size: 30pt\" >°C</span>";
            // 
            // imgStatoCaldaia
            // 
            this.imgStatoCaldaia.BackColor = System.Drawing.Color.Transparent;
            this.imgStatoCaldaia.Image = global::CTGUI.Properties.Resources.fuoco_animato;
            this.imgStatoCaldaia.Location = new System.Drawing.Point(571, 125);
            this.imgStatoCaldaia.Name = "imgStatoCaldaia";
            this.imgStatoCaldaia.Size = new System.Drawing.Size(110, 155);
            this.imgStatoCaldaia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStatoCaldaia.TabIndex = 7;
            this.imgStatoCaldaia.TabStop = false;
            // 
            // imgStateWeather
            // 
            this.imgStateWeather.BackColor = System.Drawing.Color.Transparent;
            this.imgStateWeather.Location = new System.Drawing.Point(549, 0);
            this.imgStateWeather.Name = "imgStateWeather";
            this.imgStateWeather.Size = new System.Drawing.Size(250, 180);
            this.imgStateWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStateWeather.TabIndex = 6;
            this.imgStateWeather.TabStop = false;
            this.imgStateWeather.Click += new System.EventHandler(this.imgStateWeather_Click);
            // 
            // lblValueTemperatura
            // 
            this.lblValueTemperatura.Font = new System.Drawing.Font("Montserrat", 170.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueTemperatura.ForeColor = System.Drawing.Color.White;
            this.lblValueTemperatura.Location = new System.Drawing.Point(557, 17);
            this.lblValueTemperatura.Name = "lblValueTemperatura";
            this.lblValueTemperatura.Size = new System.Drawing.Size(182, 64);
            this.lblValueTemperatura.TabIndex = 0;
            this.lblValueTemperatura.Text = "88,8";
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
            // lblTypeSystem
            // 
            this.lblTypeSystem.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeSystem.ForeColor = System.Drawing.Color.White;
            this.lblTypeSystem.Location = new System.Drawing.Point(214, 25);
            this.lblTypeSystem.Name = "lblTypeSystem";
            this.lblTypeSystem.Size = new System.Drawing.Size(145, 33);
            this.lblTypeSystem.TabIndex = 4;
            this.lblTypeSystem.Text = "MANUAL";
            // 
            // imgSystem
            // 
            this.imgSystem.Image = ((System.Drawing.Image)(resources.GetObject("imgSystem.Image")));
            this.imgSystem.Location = new System.Drawing.Point(5, 1);
            this.imgSystem.Name = "imgSystem";
            this.imgSystem.Size = new System.Drawing.Size(100, 78);
            this.imgSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSystem.TabIndex = 2;
            this.imgSystem.TabStop = false;
            this.imgSystem.Click += new System.EventHandler(this.imgSystem_Click);
            // 
            // lblValueUmidity
            // 
            this.lblValueUmidity.Font = new System.Drawing.Font("Montserrat", 62.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueUmidity.ForeColor = System.Drawing.Color.White;
            this.lblValueUmidity.Location = new System.Drawing.Point(361, -9);
            this.lblValueUmidity.Name = "lblValueUmidity";
            this.lblValueUmidity.Size = new System.Drawing.Size(149, 93);
            this.lblValueUmidity.TabIndex = 5;
            this.lblValueUmidity.Text = "88";
            this.lblValueUmidity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSystem
            // 
            this.lblSystem.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(39)))));
            this.lblSystem.Location = new System.Drawing.Point(111, 25);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(115, 33);
            this.lblSystem.TabIndex = 3;
            this.lblSystem.Text = "System:";
            this.lblSystem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblScalaHumidity
            // 
            this.lblScalaHumidity.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScalaHumidity.ForeColor = System.Drawing.Color.White;
            this.lblScalaHumidity.Location = new System.Drawing.Point(488, -2);
            this.lblScalaHumidity.Name = "lblScalaHumidity";
            this.lblScalaHumidity.Size = new System.Drawing.Size(43, 37);
            this.lblScalaHumidity.TabIndex = 5;
            this.lblScalaHumidity.Text = "%";
            // 
            // lblHumidity
            // 
            this.lblHumidity.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(39)))));
            this.lblHumidity.Location = new System.Drawing.Point(518, 4);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(150, 80);
            this.lblHumidity.TabIndex = 5;
            this.lblHumidity.Text = "Humidity";
            this.lblHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelB
            // 
            this.panelB.BackColor = System.Drawing.Color.Transparent;
            this.panelB.Controls.Add(this.lblTypeSystem);
            this.panelB.Controls.Add(this.lblScalaHumidity);
            this.panelB.Controls.Add(this.lblSystem);
            this.panelB.Controls.Add(this.imgSystem);
            this.panelB.Controls.Add(this.lblValueUmidity);
            this.panelB.Controls.Add(this.lblHumidity);
            this.panelB.Location = new System.Drawing.Point(79, 321);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(671, 81);
            this.panelB.TabIndex = 1;
            this.panelB.Paint += new System.Windows.Forms.PaintEventHandler(this.panelB_Paint);
            // 
            // HomeGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelA);
            this.Controls.Add(this.panelC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelB);
            this.Name = "HomeGui";
            this.Size = new System.Drawing.Size(752, 520);
            this.panelA.ResumeLayout(false);
            this.panelA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatoCaldaia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStateWeather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSystem)).EndInit();
            this.panelB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Panel panelC;
        private System.Windows.Forms.Label label1;
        private Label lblValueTemperatura;
        private System.Windows.Forms.PictureBox imgStateWeather;
        private System.Windows.Forms.Label lblTypeSystem;
        private System.Windows.Forms.PictureBox imgSystem;
        private System.Windows.Forms.Label lblValueUmidity;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Label lblScalaHumidity;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.PictureBox imgStatoCaldaia;
        private TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel lblHtmlTemperatura;
    }
}
