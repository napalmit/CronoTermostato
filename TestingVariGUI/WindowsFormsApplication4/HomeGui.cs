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

namespace WindowsFormsApplication4
{
    public partial class HomeGui : UserControl
    {

        public HomeGui()
        {
            InitializeComponent();
            YahooWeatherCity city = new YahooWeather("cuorgne").GetWeather();
            Console.WriteLine(city.IMG);
            //http://l.yimg.com/us.yimg.com/i/us/nws/weather/gr/34d.png

            string time = "n";
            //var d = new Date();
            //var curr_hour = d.getHours();
            //var dn = (curr_hour < 18 && curr_hour > 4 ? 'd' : 'n');
            Console.WriteLine(city.SUNRISE + "|" + city.SUNSET);
            DateTime ALBA = DateTime.ParseExact(city.SUNRISE, "h:mm tt",
                                       System.Globalization.CultureInfo.InvariantCulture);
            DateTime TRAMONTO = DateTime.ParseExact(city.SUNSET, "h:mm tt",
                                       System.Globalization.CultureInfo.InvariantCulture);
            if ((DateTime.Now > ALBA) && (DateTime.Now < TRAMONTO))
            {
                time = "d";
            }else
                time = "n";
            //if( è notte)
            //time = "d"; //giorno
            //time = "n"; //notte
            //time = "s"; //small
            //
            imgStateWeather.Load("http://l.yimg.com/a/i/us/nws/weather/gr/" + city.CODE + time+".png");
            //imgStateWeather.Load("http://l.yimg.com/a/i/us/nws/weather/gr/46d.png");
        }

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

        Point[] PUNTO = new Point[] { new Point(0, 0), new Point(80, 0), new Point(80, 80) };
        private void panelC_Paint(object sender, PaintEventArgs e)
        {
            panelC.BackColor = Color.Transparent;
            panelC.BorderStyle = BorderStyle.None;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(100, 0, 0, 93)))
            {
                e.Graphics.FillPolygon(brush, PUNTO);
            }
        }
    }
}
