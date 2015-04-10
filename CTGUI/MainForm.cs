using CTGUI.LOGICA;
using CTGUI.PANEL;
using CTGUI.Properties;
using CTGUI.UTILS;
using CTGUI.UTILS.GUI;
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
        

        //public delegate
        public delegate void DelegateSimple();
        public delegate void DelegateString(string one);
        public delegate void DelegateYahooWeatherCity(YahooWeatherCity one);
        public delegate void DelegateTwoString(string one, string two);

        //private UserControl
        private Time PANEL_TIME;
        private MenuSinistra PANEL_MENU_SINISTRA;
        private MuoviMenu PANEL_MUOVI_MENU;
        private HomeGui PANEL_HOME_GUI;
        private WeatherGUI PANEL_WEATHER_GUI;
        private SystemStateGUI PANEL_SYSTEM_STATE_GUI;

        //private
        private int STATO_VISUALIZZAZIONE;
        private LogicaSistema LOGICA_SISTEMA;

        //private time
        private System.Timers.Timer TIMER_WEATHER;

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
                // logica sistema
                LOGICA_SISTEMA = new LogicaSistema();
                LOGICA_SISTEMA.CambioTemperatura += LOGICA_SISTEMA_CambioTemperatura;

                // istanzio i vari pannelli
                InitPanel();

                // creo l'oggetto per le previsioni
                InitWeather();

                //timer
                TIMER_WEATHER = new System.Timers.Timer(300000); // aggiorno il tempo ogni 300 secondi
                TIMER_WEATHER.Elapsed += new ElapsedEventHandler(TIMER_WEATHER_Elapsed);
                TIMER_WEATHER.Enabled = true;

                //preparo i dati da fare vedere nei pannelli
                Init_HOME_GUI();
                PANEL_WEATHER_GUI.SettingGUI(WEATHER);

                //attivo i prima pannelli che si devono vedere e altro per la GUI
                ShowPANEL_TIME();
                ShowPANEL_MENU_SINISTRA();
                ShowPANEL_MUOVI_MENU();               
                ShowPANEL_HOME_GUI();
                imageSinistraAlto.Hide();
                
                //setto le variabili e altro
                STATO_VISUALIZZAZIONE = StatoVisualizzazione.HOME;
                LOGICA_SISTEMA.STATO_SISTEMA = StatoSistema.AUTO;
                LOGICA_SISTEMA.STATO_CALDAIA = StatoCaldaia.ON_COLD;
                PANEL_HOME_GUI.SetStatoCaldaia(LOGICA_SISTEMA.STATO_CALDAIA);
                PANEL_HOME_GUI.SetStatoSistema(LOGICA_SISTEMA.STATO_SISTEMA);
                PANEL_SYSTEM_STATE_GUI.SetStatoSistema(LOGICA_SISTEMA.STATO_SISTEMA);

                
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void TIMER_WEATHER_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                InitWeather();
                this.Invoke(new DelegateYahooWeatherCity(PANEL_WEATHER_GUI.SettingGUI), WEATHER);
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

        private void LOGICA_SISTEMA_CambioTemperatura(object sender, LogicaSistema.CambioTemperaturaArgs e)
        {
            this.Invoke(new DelegateTwoString(PANEL_HOME_GUI.SetTemperatura), e.Temperatura.ToString("n1"), "°C");
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
                PANEL_HOME_GUI.ClickSistema += PANEL_HOME_GUI_ClickSistema;
                PANEL_HOME_GUI.ClickImgWeather += PANEL_HOME_GUI_ClickImgWeather;
                PANEL_HOME_GUI.Hide();

                PANEL_WEATHER_GUI = new WeatherGUI();
                PANEL_WEATHER_GUI.MAINFORM = this;
                PANEL_WEATHER_GUI.Location = new Point(175, 93);
                this.Controls.Add(PANEL_WEATHER_GUI);
                PANEL_WEATHER_GUI.Hide();

                PANEL_SYSTEM_STATE_GUI = new SystemStateGUI();
                PANEL_SYSTEM_STATE_GUI.MAINFORM = this;
                PANEL_SYSTEM_STATE_GUI.Location = new Point(175, 93);
                this.Controls.Add(PANEL_SYSTEM_STATE_GUI);
                PANEL_SYSTEM_STATE_GUI.CambioStatoSistema += PANEL_SYSTEM_STATE_GUI_CambioStatoSistema;
                PANEL_SYSTEM_STATE_GUI.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void PANEL_HOME_GUI_ClickImgWeather()
        {
            ApriPannelloWeatherGUI();
        }

        private void PANEL_HOME_GUI_ClickSistema()
        {
            ApriPannelloSistemaGUI();
        }

        private void PANEL_SYSTEM_STATE_GUI_CambioStatoSistema(object sender, SystemStateGUI.CambioStatoSistemaArgs e)
        {
            try
            {
                LOGICA_SISTEMA.STATO_SISTEMA = e.Stato;
                PANEL_HOME_GUI.SetStatoSistema(LOGICA_SISTEMA.STATO_SISTEMA);
                ChiudiPannelloSistemaGUI();
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
                    ChiudiPannelloWeatherGUI();
                }
                else if (STATO_VISUALIZZAZIONE == StatoVisualizzazione.SYSTEM)
                {
                    ChiudiPannelloSistemaGUI();
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

        public void ApriPannelloWeatherGUI()
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

        public void ChiudiPannelloWeatherGUI()
        {
            try
            {
                DATA_ULTIMA_OPERAZIONE = DateTime.Now;
                // show imageSinistraAlto
                GUI.Animate(imageSinistraAlto, GUI.Effect.Slide, 300, 0);
                //show homeGui
                GUI.Animate(PANEL_HOME_GUI, GUI.Effect.Slide, 200, 135);
                //hide weather gui
                GUI.Animate(PANEL_WEATHER_GUI, GUI.Effect.Slide, 200, 45);
                STATO_VISUALIZZAZIONE = StatoVisualizzazione.HOME;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void ApriPannelloSistemaGUI()
        {
            try
            {
                DATA_ULTIMA_OPERAZIONE = DateTime.Now;
                STATO_VISUALIZZAZIONE = StatoVisualizzazione.SYSTEM;
                imageSinistraAlto.Image = Resources.home;
                // show imageSinistraAlto
                GUI.Animate(imageSinistraAlto, GUI.Effect.Slide, 300, 0);
                //hide homeGui
                GUI.Animate(PANEL_HOME_GUI, GUI.Effect.Slide, 200, 135);
                //Show system gui gui
                GUI.Animate(PANEL_SYSTEM_STATE_GUI, GUI.Effect.Slide, 200, 45);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void ChiudiPannelloSistemaGUI()
        {
            try
            {
                DATA_ULTIMA_OPERAZIONE = DateTime.Now;
                // show imageSinistraAlto
                GUI.Animate(imageSinistraAlto, GUI.Effect.Slide, 300, 0);
                //show homeGui
                GUI.Animate(PANEL_HOME_GUI, GUI.Effect.Slide, 200, 135);
                //hide weather gui
                GUI.Animate(PANEL_SYSTEM_STATE_GUI, GUI.Effect.Slide, 200, 45);
                STATO_VISUALIZZAZIONE = StatoVisualizzazione.HOME;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        //metodi di stato
        
    }
}
