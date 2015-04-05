namespace CTGUI
{
    partial class MainForm
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
            this.panelRigaBianca = new System.Windows.Forms.Panel();
            this.imageSinistraAlto = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageSinistraAlto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRigaBianca
            // 
            this.panelRigaBianca.BackColor = System.Drawing.Color.White;
            this.panelRigaBianca.Location = new System.Drawing.Point(990, 0);
            this.panelRigaBianca.Name = "panelRigaBianca";
            this.panelRigaBianca.Size = new System.Drawing.Size(3, 600);
            this.panelRigaBianca.TabIndex = 0;
            // 
            // imageSinistraAlto
            // 
            this.imageSinistraAlto.BackColor = System.Drawing.Color.Transparent;
            this.imageSinistraAlto.Image = global::CTGUI.Properties.Resources.home1;
            this.imageSinistraAlto.Location = new System.Drawing.Point(46, 0);
            this.imageSinistraAlto.Name = "imageSinistraAlto";
            this.imageSinistraAlto.Size = new System.Drawing.Size(147, 46);
            this.imageSinistraAlto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageSinistraAlto.TabIndex = 1;
            this.imageSinistraAlto.TabStop = false;
            this.imageSinistraAlto.Click += new System.EventHandler(this.imageSinistraAlto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CTGUI.Properties.Resources.image_116;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imageSinistraAlto);
            this.Controls.Add(this.panelRigaBianca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.imageSinistraAlto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRigaBianca;
        private System.Windows.Forms.PictureBox imageSinistraAlto;
        private System.Windows.Forms.Button button1;




    }
}