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
namespace CTGUI.PANEL
{
    public partial class HomeGui : UserControl
    {
        public MainForm MAINFORM { get; set; }
        public HomeGui()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
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

        #region settaggio dati pannello
        public void SetTemperatura(string temperatura, string scala)
        {
            try
            {
                lblValueTemperatura.Text = temperatura;
                lblScalaTemperatura.Text = scala;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        public void SetHumidity(string humidity, string scala)
        {
            try
            {
                lblValueUmidity.Text = humidity;
                lblScalaHumidity.Text = scala;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        public void SetWeatherImage(string http)
        {
            try
            {
                imgStateWeather.Load(http);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        public void SetStatoSystem(int statoSystem)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        #endregion

        private void imgStateWeather_Click(object sender, EventArgs e)
        {
            MAINFORM.ClickHomeGuiWeather();            
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }
    }
}
