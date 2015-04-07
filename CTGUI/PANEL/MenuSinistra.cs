using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTGUI.UTILS;
using System.Threading;
using System.Runtime.InteropServices;

namespace CTGUI.PANEL
{
    public partial class MenuSinistra : UserControl
    {
        public MainForm MAINFORM { get; set; }
        public delegate void DelegateNormale();

        private bool APERTO = false;
        private Point LOCATION_OPEN = new Point(0, 0);
        private Point LOCATION_CLOSE = new Point(-140, 0);
        private System.Timers.Timer TIMER;

        public MenuSinistra()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            panelA.BackColor = Color.FromArgb(100, 0,0,93);
            panelB.BackColor = Color.FromArgb(100, 0, 0, 93);
        }

        public void SettingGUI()
        {
            try
            {
                MAINFORM.DATA_SISTEMA = DateTime.Now;
                TIMER = new System.Timers.Timer(10);
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
            try
            {
                TIMER.Enabled = true;
                TIMER.Start();
                //GUI.AnimateTwo(this, GUI.Effect.Slide, 300, 0);
                //int flags = 0x00020000 | 0x00040000 | 0x00000001 | 0x00000008;
                //AnimateWindow(this.Handle, 500, flags);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        enum Test
        {
            HorPos = 0x00000001,
            HorNeg = 0x00000002,
            VerPos = 0x00000004,
            VerNeg = 0x00000008,
            Center = 0x00000010,
            Hide = 0x00010000,
            Activate = 0x00020000,
            Slide = 0x00040000,
            Blend = 0x00080000
        }


        private void ActionClick()
        {
            try
            {
                if (APERTO)
                {
                    Console.WriteLine("this.Location.X:" + this.Location.X);
                    if (this.Location.X > -140)
                        this.Location = new Point(this.Location.X - 5, 0);
                    else
                    {
                        Console.WriteLine("FINITO this.Location.X:" + this.Location.X);
                        TIMER.Enabled = false;
                        TIMER.Stop();
                        APERTO = false;
                    }
                }
                else
                {
                    Console.WriteLine("AAAAAAAAAA:" + APERTO);
                    if (this.Location.X < 0)
                        this.Location = new Point(this.Location.X + 5, 0);
                    else
                    {
                        TIMER.Enabled = false;
                        TIMER.Stop();
                        APERTO = true;
                    }
                }
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


        public void MuoviMenu(bool apri, int pixel) 
        {
            try
            {
                if(apri)
                    this.Location = new Point(this.Location.X + pixel, 0);
                else
                    this.Location = new Point(this.Location.X - pixel, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

    }
}
