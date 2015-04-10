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

        public void SetStatoSistema(int statoSistema)
        {
            toggleButtonSistema.SetStatoSistema(statoSistema);
        }

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

        public class CambioStatoSistemaArgs : EventArgs
        {
            public int Stato
            {
                set;
                get;
            }
        }
    }
}
