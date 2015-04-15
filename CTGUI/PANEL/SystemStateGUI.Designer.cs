using System.Windows.Forms;
namespace CTGUI.PANEL
{
    partial class SystemStateGUI
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDown = new System.Windows.Forms.Panel();
            this.panelUp = new System.Windows.Forms.Panel();
            this.lblManualTemperature = new System.Windows.Forms.Label();
            this.panelC = new System.Windows.Forms.Panel();
            this.panelB = new System.Windows.Forms.Panel();
            this.panelModifica = new System.Windows.Forms.Panel();
            this.toggleButtonSistema = new CTGUI.UTILS.GUI.ToggleButtonState();
            this.panelA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelModifica.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelA
            // 
            this.panelA.BackColor = System.Drawing.Color.Transparent;
            this.panelA.Controls.Add(this.panelModifica);
            this.panelA.Controls.Add(this.toggleButtonSistema);
            this.panelA.Location = new System.Drawing.Point(0, 35);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(750, 287);
            this.panelA.TabIndex = 0;
            this.panelA.Paint += new System.Windows.Forms.PaintEventHandler(this.panelA_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CTGUI.Properties.Resources.fuoco;
            this.pictureBox1.Location = new System.Drawing.Point(39, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panelDown
            // 
            this.panelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(136)))), ((int)(((byte)(180)))));
            this.panelDown.Location = new System.Drawing.Point(294, 154);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(90, 90);
            this.panelDown.TabIndex = 4;
            this.panelDown.Click += new System.EventHandler(this.panelDown_Click);
            this.panelDown.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDown_Paint);
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(199)))), ((int)(((byte)(77)))));
            this.panelUp.Location = new System.Drawing.Point(294, 29);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(90, 90);
            this.panelUp.TabIndex = 3;
            this.panelUp.Click += new System.EventHandler(this.panelUp_Click);
            this.panelUp.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUp_Paint);
            // 
            // lblManualTemperature
            // 
            this.lblManualTemperature.Font = new System.Drawing.Font("DIN", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManualTemperature.ForeColor = System.Drawing.Color.White;
            this.lblManualTemperature.Location = new System.Drawing.Point(107, 39);
            this.lblManualTemperature.Name = "lblManualTemperature";
            this.lblManualTemperature.Size = new System.Drawing.Size(175, 179);
            this.lblManualTemperature.TabIndex = 5;
            this.lblManualTemperature.Text = "18,5";
            this.lblManualTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelC
            // 
            this.panelC.Location = new System.Drawing.Point(0, 322);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(80, 80);
            this.panelC.TabIndex = 2;
            this.panelC.Paint += new System.Windows.Forms.PaintEventHandler(this.panelC_Paint);
            // 
            // panelB
            // 
            this.panelB.BackColor = System.Drawing.Color.Transparent;
            this.panelB.Location = new System.Drawing.Point(79, 321);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(671, 81);
            this.panelB.TabIndex = 1;
            this.panelB.Paint += new System.Windows.Forms.PaintEventHandler(this.panelB_Paint);
            // 
            // panelModifica
            // 
            this.panelModifica.BackColor = System.Drawing.Color.Transparent;
            this.panelModifica.Controls.Add(this.pictureBox1);
            this.panelModifica.Controls.Add(this.panelDown);
            this.panelModifica.Controls.Add(this.lblManualTemperature);
            this.panelModifica.Controls.Add(this.panelUp);
            this.panelModifica.Location = new System.Drawing.Point(324, 17);
            this.panelModifica.Name = "panelModifica";
            this.panelModifica.Size = new System.Drawing.Size(406, 263);
            this.panelModifica.TabIndex = 2;
            this.panelModifica.Paint += new System.Windows.Forms.PaintEventHandler(this.panelModifica_Paint);
            // 
            // toggleButtonSistema
            // 
            this.toggleButtonSistema.BackColor = System.Drawing.Color.Transparent;
            this.toggleButtonSistema.Font = new System.Drawing.Font("Roboto", 15F);
            this.toggleButtonSistema.ForeColor = System.Drawing.Color.White;
            this.toggleButtonSistema.Location = new System.Drawing.Point(54, 17);
            this.toggleButtonSistema.Name = "toggleButtonSistema";
            this.toggleButtonSistema.Size = new System.Drawing.Size(206, 263);
            this.toggleButtonSistema.TabIndex = 0;
            // 
            // SystemStateGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelA);
            this.Controls.Add(this.panelC);
            this.Controls.Add(this.panelB);
            this.Name = "SystemStateGUI";
            this.Size = new System.Drawing.Size(752, 520);
            this.panelA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelModifica.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Panel panelC;
        private System.Windows.Forms.Panel panelB;
        private UTILS.GUI.ToggleButtonState toggleButtonSistema;
        private Panel panelDown;
        private Panel panelUp;
        private Label lblManualTemperature;
        private PictureBox pictureBox1;
        private Panel panelModifica;
    }
}
