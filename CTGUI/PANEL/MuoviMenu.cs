using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using CTGUI.UTILS;

namespace CTGUI.PANEL
{
    public partial class MuoviMenu : UserControl
    {
        public delegate void DelegateNormale();
        private System.Timers.Timer TIMER;
        private bool APERTO = false;
        int COUNT_MAX = 29;
        int COUNT = 0;
        int PIXEL = 5;
        public MuoviMenu()
        {
            this.DoubleBuffered = true;

            InitializeComponent();
            panelB.BackColor = Color.FromArgb(100, 0, 0, 93);
        }

        public MainForm MAINFORM { get; set; }

        internal void SettingGUI()
        {
            try
            {
                MAINFORM.DATA_SISTEMA = DateTime.Now;
                TIMER = new System.Timers.Timer(1);
                TIMER.AutoReset = true;
                TIMER.Elapsed += new System.Timers.ElapsedEventHandler(TIMER_Elapsed);
                TIMER.Enabled = false;
                TIMER.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void TIMER_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Invoke(new DelegateNormale(ActionClick));
        }

        private void panelB_Click(object sender, EventArgs e)
        {
            TIMER.Enabled = true;
            TIMER.Start();
            //GUI.Animate(this, GUI.Effect.Roll, 300, 0);
        }

        private void ActionClick()
        {
            try
            {
                if (COUNT < COUNT_MAX && TIMER.Enabled)
                {
                    if (APERTO)
                    {
                        COUNT++;
                        if (COUNT < COUNT_MAX)
                        {
                            //this.Location = new Point(this.Location.X - PIXEL, this.Location.Y);
                            this.Left = this.Left - PIXEL;
                            MAINFORM.MuoviMenuSinistra(false, PIXEL);
                        }
                        else
                        {
                            TIMER.Enabled = false;
                            TIMER.Stop();
                            APERTO = false;

                        }

                    }
                    else
                    {
                        COUNT++;
                        if (COUNT < COUNT_MAX)
                        {
                            //this.Location = new Point(this.Location.X + PIXEL, this.Location.Y);
                            this.Left = this.Left + PIXEL;
                            MAINFORM.MuoviMenuSinistra(true, PIXEL);
                        }
                        else
                        {
                            TIMER.Enabled = false;
                            TIMER.Stop();
                            APERTO = true;

                        }
                    }
                }
                else               
                    COUNT = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
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
