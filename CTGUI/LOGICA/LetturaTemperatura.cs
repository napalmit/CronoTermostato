using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace CTGUI.LOGICA
{
    
    public class LetturaTemperatura
    {
        //public event
        public event EventHandler<CambioTemperaturaArgs> CambioTemperatura;

        //private timer
        private System.Timers.Timer TIMER_TEMPERATURA;

        //private
        private float TEMPERATURA = 0;

        public LetturaTemperatura()
        {
            try
            {
                TIMER_TEMPERATURA = new System.Timers.Timer(5000); // aggiorno la temperatura ogni 5 secondi
                TIMER_TEMPERATURA.Elapsed += new ElapsedEventHandler(TIMER_TEMPERATURA_Elapsed);
                TIMER_TEMPERATURA.Enabled = true;
            }
            catch (Exception ex)
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
                CambioTemperaturaArgs cambioTemperaturaArgs = new CambioTemperaturaArgs();
                cambioTemperaturaArgs.Temperatura = Single.Parse(test1 + "," + test2);
                TEMPERATURA = cambioTemperaturaArgs.Temperatura;
                if (cambioTemperaturaArgs != null)
                    this.CambioTemperatura(this, cambioTemperaturaArgs);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public class CambioTemperaturaArgs : EventArgs
        {
            public float Temperatura
            {
                set;
                get;
            }
        }  
    }
}
