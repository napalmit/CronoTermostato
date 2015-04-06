using CTGUI.PANEL;
using CTGUI.Properties;
using CTGUI.UTILS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YahooWeatherDLL;

namespace CTGUI
{
    public partial class MainForm : Form
    {
        public FontFamily FONT_FAMILY { get; private set; }
        public DateTime DATA_ULTIMA_OPERAZIONE { get; set; }
        public DateTime DATA_SISTEMA { get; set; }

        private Time PANEL_TIME;
        private MenuSinistra PANEL_MENU_SINISTRA;
        private MuoviMenu PANEL_MUOVI_MENU;

        public MainForm()
        {
            this.DoubleBuffered = true;
            InitializeComponent();           
            Init();           
        }

        private void Init()
        {
            try
            {
                #region font
                var pfc = new PrivateFontCollection();
                pfc.AddFontFile(@"BreeSerif-Regular.ttf");
                FONT_FAMILY = pfc.Families[0];
                //label1.Font = new Font(FONT_FAMILY, 14, FontStyle.Regular);
                #endregion

                InitPanel();

                ShowPANEL_TIME();
                ShowPANEL_MENU_SINISTRA();
                ShowPANEL_MUOVI_MENU();

                imageSinistraAlto.Location = new Point(46, 0);
                //imageSinistraAlto.BringToFront();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void InitPanel()
        {
            try
            {
                PANEL_TIME = new Time();
                PANEL_TIME.MAINFORM = this;
                PANEL_TIME.Location = new Point(493, 12);
                this.Controls.Add(PANEL_TIME);
                PANEL_TIME.Hide();

                PANEL_MENU_SINISTRA = new MenuSinistra();
                PANEL_MENU_SINISTRA.MAINFORM = this;
                PANEL_MENU_SINISTRA.Location = new Point(-140, 0);
                this.Controls.Add(PANEL_MENU_SINISTRA);
                PANEL_MENU_SINISTRA.Hide();

                PANEL_MUOVI_MENU = new MuoviMenu();
                PANEL_MUOVI_MENU.MAINFORM = this;
                PANEL_MUOVI_MENU.Location = new Point(40, 248);
                this.Controls.Add(PANEL_MUOVI_MENU);
                PANEL_MUOVI_MENU.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void HideAll()
        {
            try
            {
                PANEL_TIME.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void ShowPANEL_TIME()
        {
            try
            {
                DATA_ULTIMA_OPERAZIONE = DateTime.Now;
                PANEL_TIME.SettingGUI();
                PANEL_TIME.Show();
                PANEL_TIME.BringToFront();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void ShowPANEL_MENU_SINISTRA()
        {
            try
            {
                DATA_ULTIMA_OPERAZIONE = DateTime.Now;
                PANEL_MENU_SINISTRA.SettingGUI();
                PANEL_MENU_SINISTRA.Show();
                PANEL_MENU_SINISTRA.BringToFront();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void ShowPANEL_MUOVI_MENU()
        {
            try
            {
                DATA_ULTIMA_OPERAZIONE = DateTime.Now;
                PANEL_MUOVI_MENU.SettingGUI();
                PANEL_MUOVI_MENU.Show();
                PANEL_MUOVI_MENU.BringToFront();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void testc()
        {
            YahooWeather uy = new YahooWeather("cuorgne");
            YahooWeatherCity city = uy.GetWeather();
        }

        private void imageSinistraAlto_Click(object sender, EventArgs e)
        {
            GUI.Animate(imageSinistraAlto, GUI.Effect.Slide, 300, 0);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI.Animate(imageSinistraAlto, GUI.Effect.Slide, 300, 0);
        }

        internal void MuoviMenuSinistra(bool p, int PIXEL)
        {
            PANEL_MENU_SINISTRA.MuoviMenu(p, PIXEL);
        }
    }
}
