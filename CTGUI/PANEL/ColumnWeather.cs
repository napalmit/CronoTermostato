using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YahooWeatherDLL;
using System.Globalization;
using System.Drawing.Drawing2D;
using Plasmoid.Extensions;

namespace CTGUI.PANEL
{
    public partial class ColumnWeather : UserControl
    {
        public ColumnWeather()
        {
            InitializeComponent();
        }

        public void SettingGUI(Previsione aPrevisione)
        {
            try
            {
                lblDay.Text = aPrevisione.DATA.ToString("ddd", new CultureInfo("it-IT")).ToUpper();
                imgWeather.Load(aPrevisione.IMG);
                lblHI.Text = aPrevisione.HIGH + "°";
                lblLow.Text = aPrevisione.LOW + "°";
                lblMese.Text = aPrevisione.DATA.ToString("MMM").ToUpper();
                lblDayNumber.Text = aPrevisione.DATA.ToString("dd", new CultureInfo("it-IT")).ToUpper();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void panelA_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ColumnWeather_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.Transparent;
            this.BorderStyle = BorderStyle.None;
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleEdgeFilter none = RectangleEdgeFilter.All;
            graphics.FillRoundedRectangle(new SolidBrush(Color.FromArgb(100, 0, 0, 93)), float.Parse("0" + 0), float.Parse("0" + 0), float.Parse("0" + this.Width), float.Parse("0" + this.Height), 10, none);

        }
    }
}
