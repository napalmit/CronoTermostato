using CTGUI.UTILS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace CTGUI.LOGICA
{
    public class LogicaSistema
    {
        //public event
        public event EventHandler<CambioStatoCaldaiaArgs> CambioStatoCaldaia;

        //private timer
        private System.Timers.Timer TIMER_LOGICA;

        //public
        public int STATO_SISTEMA { get; set; } //AUTO / MANUAL
        public int __STATO_CALDAIA { get; set; } // ON/OFF
        public double TEMPERATURA_LETTA { get; set; }
        public double TEMPERATURA_MINIMA { get; set; }

        public LogicaSistema()
        {
            TIMER_LOGICA = new System.Timers.Timer(1000); // ogni secondo
            TIMER_LOGICA.Elapsed += new ElapsedEventHandler(TIMER_LOGICA_Elapsed);
            TIMER_LOGICA.Enabled = true;
        }

        private void TIMER_LOGICA_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (STATO_SISTEMA == StatoSistema.AUTO)
                {
                    //verifica fasce
                }
                else if (STATO_SISTEMA == StatoSistema.MANUAL)
                {
                    //verifica temperatura 
                    if (TEMPERATURA_LETTA >= TEMPERATURA_MINIMA)
                    {
                        if (__STATO_CALDAIA == StatoCaldaia.ON_HEAT)
                        {
                            Console.WriteLine("SPENGO");
                            __STATO_CALDAIA = StatoCaldaia.OFF;

                            CambioStatoCaldaiaArgs cambioStatoCaldaiaArgs = new CambioStatoCaldaiaArgs();
                            cambioStatoCaldaiaArgs.StatoCaldaia = __STATO_CALDAIA;
                            if (cambioStatoCaldaiaArgs != null)
                                this.CambioStatoCaldaia(this, cambioStatoCaldaiaArgs);
                        }                            
                    }
                    else if (TEMPERATURA_LETTA < TEMPERATURA_MINIMA)
                    {
                        if (__STATO_CALDAIA == StatoCaldaia.OFF)
                        {
                            Console.WriteLine("ACCENDO");
                            __STATO_CALDAIA = StatoCaldaia.ON_HEAT;

                            CambioStatoCaldaiaArgs cambioStatoCaldaiaArgs = new CambioStatoCaldaiaArgs();
                            cambioStatoCaldaiaArgs.StatoCaldaia = __STATO_CALDAIA;
                            if (cambioStatoCaldaiaArgs != null)
                                this.CambioStatoCaldaia(this, cambioStatoCaldaiaArgs);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public class CambioStatoCaldaiaArgs : EventArgs
        {
            public int StatoCaldaia
            {
                set;
                get;
            }
        } 
    }
}
