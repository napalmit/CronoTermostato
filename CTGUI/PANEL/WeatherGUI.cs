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
using System.Globalization;

namespace CTGUI.PANEL
{
    public partial class WeatherGUI : UserControl
    {

        public WeatherGUI()
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
            RectangleEdgeFilter none = RectangleEdgeFilter.BottomLeft | RectangleEdgeFilter.BottomRight;
            graphics.FillRoundedRectangle(new SolidBrush(Color.FromArgb(100, 0, 0, 93)), float.Parse("0" + 0), float.Parse("0" + 0), float.Parse("0" + panelA.Width), float.Parse("0" + panelA.Height), 10, none);

        }

        private void panelB_Paint(object sender, PaintEventArgs e)
        {
            panelB.BackColor = Color.Transparent;
            panelB.BorderStyle = BorderStyle.None;
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleEdgeFilter none = RectangleEdgeFilter.TopLeft;
            graphics.FillRoundedRectangle(new SolidBrush(Color.FromArgb(100, 0, 0, 93)), float.Parse("0" + 0), float.Parse("0" + 0), float.Parse("0" + panelB.Width), float.Parse("0" + panelB.Height), 10, none);

        }
        
        private void panelC_Paint(object sender, PaintEventArgs e)
        {
            Point[] PUNTO = new Point[] { new Point(0, 0), new Point(0, 80), new Point(80, 80) };
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
        public void SettingGUI(YahooWeatherCity city)
        {
            try
            {
                lblTodayDate.Text = DateTime.Now.ToString(" dddd, d MMM", new CultureInfo("it-IT")).ToUpper();
                imgStateWeatherToday.Load(city.IMG_D);
                lblValueTemperaturaToday.Text = city.TEMPERATURE + city.TEMPERATURE_UNIT;
                //lblScalaTemperaturaToday.Text = city.TEMPERATURE_UNIT;
                lblValueUmidityToday.Text = city.HUMIDITY;
                //lblScalaTemperaturaToday.Text = "%";
                lblHIToday.Text = city.LISTA_PREVISIONI[0].HIGH + "°";
                lblLowToday.Text = city.LISTA_PREVISIONI[0].LOW + "°";

                columnWeather1.SettingGUI(city.LISTA_PREVISIONI[1]);
                columnWeather2.SettingGUI(city.LISTA_PREVISIONI[2]);
                columnWeather3.SettingGUI(city.LISTA_PREVISIONI[3]);
                columnWeather4.SettingGUI(city.LISTA_PREVISIONI[4]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        #endregion

        public MainForm MAINFORM { get; set; }

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
