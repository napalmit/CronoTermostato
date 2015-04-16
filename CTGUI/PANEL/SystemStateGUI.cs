using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using Plasmoid.Extensions;
using YahooWeatherDLL;
using CTGUI.UTILS;
using CTGUI.Properties;
namespace CTGUI.PANEL
{
    public partial class SystemStateGUI : UserControl
    {
        public MainForm MAINFORM { get; set; }
        public event EventHandler<CambioStatoSistemaArgs> CambioStatoSistema;
        public event EventHandler<ModificaTemperaturaArgs> ModificaTemperatura;
        private double TEMPERATURA;
        private double TEMPERATURA_SWAP = 0.1;
        private double TEMPERATURA_MAX = 30;
        private double TEMPERATURA_MIN = 10;

        public SystemStateGUI()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            toggleButtonSistema.ToggleClick += toggleButtonSistema_ToggleClick;
        }

        private void toggleButtonSistema_ToggleClick(object sender, UTILS.GUI.ToggleButtonState.ToggleEventArgs e)
        {
            try
            {
                CambioStatoSistemaArgs cambioStatoSistemaEvent = new CambioStatoSistemaArgs();
                cambioStatoSistemaEvent.Stato = e.Stato;
                toggleButtonSistema.SetStatoSistema(e.Stato);
                if (this.CambioStatoSistema != null)
                {
                    this.CambioStatoSistema(this, cambioStatoSistemaEvent);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        private void panelUp_Click(object sender, EventArgs e)
        {
            try
            {
                double valore = 0;
                double.TryParse(lblManualTemperature.Text, out valore);
                valore = valore + TEMPERATURA_SWAP;
                if (valore != 0 && valore < TEMPERATURA_MAX)
                {
                    ModificaTemperaturaArgs modificaTemperatura = new ModificaTemperaturaArgs();
                    modificaTemperatura.Temperatura = valore;
                    if (modificaTemperatura != null)
                    {
                        lblManualTemperature.Text = string.Format("{0:0.0}", Math.Truncate(valore * 10) / 10);
                        this.ModificaTemperatura(this, modificaTemperatura);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        private void panelDown_Click(object sender, EventArgs e)
        {
            try
            {
                double valore = 0;
                double.TryParse(lblManualTemperature.Text, out valore);
                valore = valore - TEMPERATURA_SWAP;
                if (valore != 0 && valore > TEMPERATURA_MIN)
                {
                    ModificaTemperaturaArgs modificaTemperatura = new ModificaTemperaturaArgs();
                    modificaTemperatura.Temperatura = valore;
                    if (modificaTemperatura != null)
                    {
                        lblManualTemperature.Text = string.Format("{0:0.0}", Math.Truncate(valore * 10) / 10);
                        this.ModificaTemperatura(this, modificaTemperatura);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void SetStatoSistema(int statoSistema)
        {
            toggleButtonSistema.SetStatoSistema(statoSistema);
        }

        #region eventi gui
        #region paint panel
        private void panelA_Paint(object sender, PaintEventArgs e)
        {
            panelA.BackColor = Color.Transparent;
            panelA.BorderStyle = BorderStyle.None;
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleEdgeFilter none = RectangleEdgeFilter.TopLeft | RectangleEdgeFilter.TopRight;
            graphics.FillRoundedRectangle(new SolidBrush(Color.FromArgb(100, 0, 0, 93)), float.Parse("0" + 0), float.Parse("0" + 0), float.Parse("0" + panelA.Width), float.Parse("0" + panelA.Height), 10, none);

        }
        private void panelB_Paint(object sender, PaintEventArgs e)
        {
            panelB.BackColor = Color.Transparent;
            panelB.BorderStyle = BorderStyle.None;
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleEdgeFilter none = RectangleEdgeFilter.BottomRight;
            graphics.FillRoundedRectangle(new SolidBrush(Color.FromArgb(100, 0, 0, 93)), float.Parse("0" + 0), float.Parse("0" + 0), float.Parse("0" + panelB.Width), float.Parse("0" + panelB.Height), 10, none);

        }        
        private void panelC_Paint(object sender, PaintEventArgs e)
        {
            Point[] PUNTO = new Point[] { new Point(0, 0), new Point(80, 0), new Point(80, 80) };
            panelC.BackColor = Color.Transparent;
            panelC.BorderStyle = BorderStyle.None;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(100, 0, 0, 93)))
            {
                e.Graphics.FillPolygon(brush, PUNTO);
            }
        }
        private void panelUp_Paint(object sender, PaintEventArgs e)
        {
            Point[] PUNTO = new Point[] { new Point(0, 90), new Point(90, 90), new Point(45, 0) };
            panelUp.BackColor = Color.Transparent;
            panelUp.BorderStyle = BorderStyle.None;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(253, 199, 77)))
            {
                e.Graphics.FillPolygon(brush, PUNTO);
            }
        }
        private void panelDown_Paint(object sender, PaintEventArgs e)
        {
            Point[] PUNTO = new Point[] { new Point(0, 0), new Point(90, 0), new Point(45, 90) };
            panelDown.BackColor = Color.Transparent;
            panelDown.BorderStyle = BorderStyle.None;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(90, 136, 180)))
            {
                e.Graphics.FillPolygon(brush, PUNTO);
            }
        }
        private void panelModifica_Paint(object sender, PaintEventArgs e)
        {
            panelModifica.BackColor = Color.Transparent;
            panelModifica.BorderStyle = BorderStyle.None;
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleEdgeFilter none = RectangleEdgeFilter.All;
            graphics.FillRoundedRectangle(new SolidBrush(Color.FromArgb(100, 0, 0, 93)), float.Parse("0" + 0), float.Parse("0" + 0), float.Parse("0" + panelModifica.Width), float.Parse("0" + panelModifica.Height), 10, none);

        }
        #endregion

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }
        #endregion

        public class CambioStatoSistemaArgs : EventArgs
        {
            public int Stato
            {
                set;
                get;
            }
        }

        public class ModificaTemperaturaArgs : EventArgs
        {
            public double Temperatura
            {
                set;
                get;
            }
        }  
    }
}
