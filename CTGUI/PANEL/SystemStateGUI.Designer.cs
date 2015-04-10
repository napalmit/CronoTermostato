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
            this.toggleButtonSistema = new CTGUI.UTILS.GUI.ToggleButtonState();
            this.panelC = new System.Windows.Forms.Panel();
            this.panelB = new System.Windows.Forms.Panel();
            this.panelA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelA
            // 
            this.panelA.BackColor = System.Drawing.Color.Transparent;
            this.panelA.Controls.Add(this.toggleButtonSistema);
            this.panelA.Location = new System.Drawing.Point(0, 35);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(750, 287);
            this.panelA.TabIndex = 0;
            this.panelA.Paint += new System.Windows.Forms.PaintEventHandler(this.panelA_Paint);
            // 
            // toggleButtonSistema
            // 
            this.toggleButtonSistema.BackColor = System.Drawing.Color.Transparent;
            this.toggleButtonSistema.Font = new System.Drawing.Font("Roboto", 15F);
            this.toggleButtonSistema.ForeColor = System.Drawing.Color.White;
            this.toggleButtonSistema.Location = new System.Drawing.Point(161, 60);
            this.toggleButtonSistema.Name = "toggleButtonSistema";
            this.toggleButtonSistema.Size = new System.Drawing.Size(449, 174);
            this.toggleButtonSistema.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Panel panelC;
        private System.Windows.Forms.Panel panelB;
        private UTILS.GUI.ToggleButtonState toggleButtonSistema;
    }
}
