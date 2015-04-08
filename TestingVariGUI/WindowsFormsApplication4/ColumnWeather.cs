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

namespace WindowsFormsApplication4
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
    }
}
