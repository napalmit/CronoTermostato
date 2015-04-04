using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooWeatherDLL
{
    public class YahooWeatherCity
    {
        public YahooWeatherCity() { }

        public string CITY { get; set; }

        public string REGION { get; set; }

        public string COUNTRY { get; set; }

        public string TEMPERATURE { get; set; }

        public string CHILL { get; set; }

        public string HUMIDITY { get; set; }

        public string SUNRISE { get; set; }

        public string SUNSET { get; set; }

        public List<Previsione> LISTA_PREVISIONI { get; set; }

        public string CODE { get; set; }

        public string TEMPERATURE_UNIT { get; set; }

        public string IMG { get; set; }
    }

    public class Previsione
    {
        public Previsione() { }

        public string GIORNO { get; set; }

        public string CODE { get; set; }

        public string IMG { get; set; }

        public string HIGH { get; set; }

        public string LOW { get; set; }

        public DateTime DATA { get; set; }
    }
}
