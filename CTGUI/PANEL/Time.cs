using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CTGUI.PANEL
{
    public partial class Time : UserControl
    {
        public MainForm MAINFORM { private get; set; }
        public delegate void DelegateNormale();

        private System.Timers.Timer TIMER;
        public Time()
        {
            InitializeComponent();
        }

        public void SettingGUI()
        {
            try
            {
                MAINFORM.DATA_SISTEMA = DateTime.Now;
                TIMER = new System.Timers.Timer(1000);
                TIMER.Elapsed += new System.Timers.ElapsedEventHandler(TIMER_Elapsed);
                TIMER.Enabled = true;
                TIMER.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void TIMER_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                MAINFORM.DATA_SISTEMA = DateTime.Now;
                this.Invoke(new DelegateNormale(MakeLabel));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void MakeLabel()
        {
            try
            {
                lblTime.Text = MAINFORM.DATA_SISTEMA.ToString("HH:mm");
                lblType.Text = MAINFORM.DATA_SISTEMA.ToString("tt", new CultureInfo("en-US")).ToUpper();
                lblData.Text = MAINFORM.DATA_SISTEMA.ToString(" ddd, d MMM").ToUpper();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }


        private void Time_Click(object sender, EventArgs e)
        {
            //478; 83
        }
    }
}
