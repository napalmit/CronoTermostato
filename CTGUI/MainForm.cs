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
        public YahooWeatherCity WEATHER { get; set; }

        private Time PANEL_TIME;
        private MenuSinistra PANEL_MENU_SINISTRA;
        private MuoviMenu PANEL_MUOVI_MENU;
        private HomeGui PANEL_HOME_GUI;

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
                InitPanel();

                InitWeather();

                ShowPANEL_TIME();
                ShowPANEL_MENU_SINISTRA();
                ShowPANEL_MUOVI_MENU();
                Init_HOME_GUI(); //test
                ShowPANEL_HOME_GUI();

                imageSinistraAlto.Hide();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void Init_HOME_GUI()
        {
            try
            {
                PANEL_HOME_GUI.SetTemperatura("18,3", "°C");
                PANEL_HOME_GUI.SetHumidity("75","%");
                if ((DateTime.Now > WEATHER.SUNRISE) && (DateTime.Now < WEATHER.SUNSET))
                    PANEL_HOME_GUI.SetWeatherImage(WEATHER.IMG_D);
                else
                    PANEL_HOME_GUI.SetWeatherImage(WEATHER.IMG_N);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void InitWeather()
        {
            try
            {
                WEATHER = new YahooWeather("cuorgne").GetWeather();
            }
            catch (Exception ex)
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

                PANEL_HOME_GUI = new HomeGui();
                PANEL_HOME_GUI.MAINFORM = this;
                PANEL_HOME_GUI.Location = new Point(175, 93);
                this.Controls.Add(PANEL_HOME_GUI);
                PANEL_HOME_GUI.Hide();
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

        #region ShowPANEL
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

        public void ShowPANEL_HOME_GUI()
        {
            try
            {
                DATA_ULTIMA_OPERAZIONE = DateTime.Now;
                PANEL_HOME_GUI.Show();
                PANEL_HOME_GUI.BringToFront();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        #endregion

        private void imageSinistraAlto_Click(object sender, EventArgs e)
        {
            try
            {
                // show imageSinistraAlto
                GUI.Animate(imageSinistraAlto, GUI.Effect.Slide, 300, 0); 
                //hide homeGui
                GUI.Animate(PANEL_HOME_GUI, GUI.Effect.Slide, 200, 135);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI.Animate(imageSinistraAlto, GUI.Effect.Slide, 300, 0);
        }

        internal void MuoviMenuSinistra(bool p, int PIXEL)
        {
            PANEL_MENU_SINISTRA.MuoviMenu(p, PIXEL);
            PANEL_MUOVI_MENU.BringToFront();
        }


        internal void ClickHomeGuiWeather()
        {
            try
            {
                // show imageSinistraAlto
                GUI.Animate(imageSinistraAlto, GUI.Effect.Slide, 300, 0);
                //hide homeGui
                GUI.Animate(PANEL_HOME_GUI, GUI.Effect.Slide, 200, 135);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
