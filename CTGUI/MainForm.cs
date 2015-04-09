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
using System.Timers;
using System.Windows.Forms;
using YahooWeatherDLL;

namespace CTGUI
{
    public partial class MainForm : Form
    {
        //public
        public FontFamily FONT_FAMILY { get; private set; }
        public DateTime DATA_ULTIMA_OPERAZIONE { get; set; }
        public DateTime DATA_SISTEMA { get; set; }
        public YahooWeatherCity WEATHER { get; set; }
        public int STATO_SISTEMA { get; set; }
        //public delegate
        public delegate void DelegateSimple();
        public delegate void DelegateString(string one);
        public delegate void DelegateYahooWeatherCity(YahooWeatherCity one);
        public delegate void DelegateTwoString(string one, string two);

        //private
        private Time PANEL_TIME;
        private MenuSinistra PANEL_MENU_SINISTRA;
        private MuoviMenu PANEL_MUOVI_MENU;
        private HomeGui PANEL_HOME_GUI;
        private WeatherGUI PANEL_WEATHER_GUI;
        private int STATO_VISUALIZZAZIONE;
        private System.Timers.Timer TIMER_WEATHER;
        private System.Timers.Timer TIMER_TEMPERATURA;

        public MainForm()
        {
            //this.DoubleBuffered = true;
            InitializeComponent();          
            Init();           
        }

        private void Init()
        {
            try
            {
                // istanzio i vari pannelli
                InitPanel();

                // creo l'oggetto per le previsioni
                InitWeather();

                //creo e starto i timer
                #region TIMER
                TIMER_TEMPERATURA = new System.Timers.Timer(1000); // aggiorno la temperatura ogni secondo
                TIMER_TEMPERATURA.Elapsed += new ElapsedEventHandler(TIMER_TEMPERATURA_Elapsed);
                TIMER_TEMPERATURA.Enabled = true;
                TIMER_WEATHER = new System.Timers.Timer(300000); // aggiorno il tempo ogni 300 secondi
                TIMER_WEATHER.Elapsed += new ElapsedEventHandler(TIMER_WEATHER_Elapsed);
                TIMER_WEATHER.Enabled = true;
                #endregion

                //preparo i dati da fare vedere nei pannelli
                Init_HOME_GUI();
                PANEL_WEATHER_GUI.SettingGUI(WEATHER);

                //attivo i prima pannelli che si devono vedere e altro per la GUI
                ShowPANEL_TIME();
                ShowPANEL_MENU_SINISTRA();
                ShowPANEL_MUOVI_MENU();               
                ShowPANEL_HOME_GUI();
                SetStatoSistema(StatoSistema.ON);
                imageSinistraAlto.Hide();
                
                //setto le variabili e altro
                STATO_VISUALIZZAZIONE = StatoVisualizzazione.HOME;
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void TIMER_TEMPERATURA_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                //aggiorno la temperatura
                int test1 = new Random().Next(18, 20);
                int test2 = new Random().Next(0, 9);
                this.Invoke(new DelegateTwoString(PANEL_HOME_GUI.SetTemperatura), test1 + "," + test2, "°C");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void TIMER_WEATHER_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                Console.WriteLine("AGGIORNO TEMPO");
                InitWeather();
                Console.WriteLine("AGGIORNO PANEL_WEATHER_GUI");
                this.Invoke(new DelegateYahooWeatherCity(PANEL_WEATHER_GUI.SettingGUI), WEATHER);
                Console.WriteLine("AGGIORNO IMMAGINE TEMPO HOME_GUI");
                if ((DateTime.Now > WEATHER.SUNRISE) && (DateTime.Now < WEATHER.SUNSET))
                    this.Invoke(new DelegateString(PANEL_HOME_GUI.SetWeatherImage), WEATHER.IMG_D);
                else
                    this.Invoke(new DelegateString(PANEL_HOME_GUI.SetWeatherImage), WEATHER.IMG_N);
                
            }
            catch (Exception ex)
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

                PANEL_WEATHER_GUI = new WeatherGUI();
                PANEL_WEATHER_GUI.MAINFORM = this;
                PANEL_WEATHER_GUI.Location = new Point(175, 93);
                this.Controls.Add(PANEL_WEATHER_GUI);
                PANEL_WEATHER_GUI.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void imageSinistraAlto_Click(object sender, EventArgs e)
        {
            try
            {
                DATA_ULTIMA_OPERAZIONE = DateTime.Now;
                if (STATO_VISUALIZZAZIONE == StatoVisualizzazione.WEATHER)
                {
                    // show imageSinistraAlto
                    GUI.Animate(imageSinistraAlto, GUI.Effect.Slide, 300, 0);
                    //show homeGui
                    GUI.Animate(PANEL_HOME_GUI, GUI.Effect.Slide, 200, 135);
                    //hide weather gui
                    GUI.Animate(PANEL_WEATHER_GUI, GUI.Effect.Slide, 200, 45);
                    STATO_VISUALIZZAZIONE = StatoVisualizzazione.HOME;
                }

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

        public void ShowPANEL_WEATHER_GUI()
        {
            try
            {
                DATA_ULTIMA_OPERAZIONE = DateTime.Now;
                
                PANEL_WEATHER_GUI.Show();
                PANEL_WEATHER_GUI.BringToFront();
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

        //metodi GUI
        public void MuoviMenuSinistra(bool p, int PIXEL)
        {
            DATA_ULTIMA_OPERAZIONE = DateTime.Now;
            PANEL_MENU_SINISTRA.MuoviMenu(p, PIXEL);
            PANEL_MUOVI_MENU.BringToFront();
        }

        public void ClickHomeGuiWeather()
        {
            try
            {
                DATA_ULTIMA_OPERAZIONE = DateTime.Now;
                STATO_VISUALIZZAZIONE = StatoVisualizzazione.WEATHER;
                imageSinistraAlto.Image = Resources.weather;
                // show imageSinistraAlto
                GUI.Animate(imageSinistraAlto, GUI.Effect.Slide, 300, 0);
                //hide homeGui
                GUI.Animate(PANEL_HOME_GUI, GUI.Effect.Slide, 200, 135);
                //Show weather gui
                GUI.Animate(PANEL_WEATHER_GUI, GUI.Effect.Slide, 200, 45);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        //metodi di stato
        public void SetStatoSistema(int statoSistema)
        {
            try
            {
                if (statoSistema == StatoSistema.ON)
                {                   
                    PANEL_HOME_GUI.AttivaSistema();
                }
                else if (statoSistema == StatoSistema.OFF)
                {
                    PANEL_HOME_GUI.DisattivaSistema();
                }

                STATO_SISTEMA = statoSistema;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
