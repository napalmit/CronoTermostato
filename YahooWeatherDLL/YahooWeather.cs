using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using YahooWeatherDLL.Properties;

namespace YahooWeatherDLL
{
    public class YahooWeather
    {
        public YahooWeather(string city)
        {
            CITY = city;
            yahooWeatherCity = new YahooWeatherCity();
        }

        private YahooWeatherCity yahooWeatherCity { get; set; }
        private string CITY { get; set; }

        private string GetWOEID()
        {
            string WOEID = "";
            try
            {
                string query = "http://where.yahooapis.com/v1/places.q('" + CITY + "')?appid=" + Resources.appID + "&u=c";
                XmlDocument woeidData = new XmlDocument();
                woeidData.Load(query);

                XmlNodeList kk = woeidData.GetElementsByTagName("woeid");

                WOEID = kk[0].InnerText;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            return WOEID;
        }

        public YahooWeatherCity GetWeather()
        {
            try
            {
                string query = String.Format("http://weather.yahooapis.com/forecastrss?w={0}&u=c", GetWOEID().Trim());
                XmlDocument wData = new XmlDocument();
                wData.Load(query);

                XmlNamespaceManager man = new XmlNamespaceManager(wData.NameTable);
                man.AddNamespace("yweather", "http://xml.weather.yahoo.com/ns/rss/1.0");

                XmlNode channel = wData.SelectSingleNode("rss").SelectSingleNode("channel");

                yahooWeatherCity.CITY = channel.SelectSingleNode("yweather:location", man).Attributes["city"].Value;

                yahooWeatherCity.REGION = channel.SelectSingleNode("yweather:location", man).Attributes["region"].Value;

                yahooWeatherCity.COUNTRY = channel.SelectSingleNode("yweather:location", man).Attributes["country"].Value;

                yahooWeatherCity.TEMPERATURE_UNIT = "°"+channel.SelectSingleNode("yweather:units", man).Attributes["temperature"].Value;

                yahooWeatherCity.CHILL = channel.SelectSingleNode("yweather:wind", man).Attributes["chill"].Value;

                yahooWeatherCity.HUMIDITY = channel.SelectSingleNode("yweather:atmosphere", man).Attributes["humidity"].Value;

                string sunrise = channel.SelectSingleNode("yweather:astronomy", man).Attributes["sunrise"].Value;
                yahooWeatherCity.SUNRISE = DateTime.ParseExact(sunrise, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture);

                string sunset = channel.SelectSingleNode("yweather:astronomy", man).Attributes["sunset"].Value;
                yahooWeatherCity.SUNSET = DateTime.ParseExact(sunset, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture);

                yahooWeatherCity.CODE = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", man).Attributes["code"].Value;

                yahooWeatherCity.TEMPERATURE = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", man).Attributes["temp"].Value;

                yahooWeatherCity.IMG_D = "http://l.yimg.com/a/i/us/nws/weather/gr/" + yahooWeatherCity.CODE + "d.png";

                yahooWeatherCity.IMG_N = "http://l.yimg.com/a/i/us/nws/weather/gr/" + yahooWeatherCity.CODE + "n.png";

                yahooWeatherCity.IMG_S = "http://l.yimg.com/a/i/us/nws/weather/gr/" + yahooWeatherCity.CODE + "s.png";

                yahooWeatherCity.LISTA_PREVISIONI = new List<Previsione>();
                XmlNodeList previsioni = channel.SelectSingleNode("item").SelectNodes("yweather:forecast", man);
                foreach (XmlNode previsioneGiorno in previsioni)
                {
                    Previsione previsione = new Previsione();
                    previsione.GIORNO = previsioneGiorno.Attributes["day"].Value;
                    previsione.DATA = DateTime.ParseExact(previsioneGiorno.Attributes["date"].Value, "d MMM yyyy",
                                       CultureInfo.CreateSpecificCulture("en-US"));
                    previsione.CODE = previsioneGiorno.Attributes["code"].Value;
                    previsione.IMG = "http://l.yimg.com/a/i/us/nws/weather/gr/" + previsione.CODE + "s.png";
                    previsione.HIGH = previsioneGiorno.Attributes["high"].Value;
                    previsione.LOW = previsioneGiorno.Attributes["low"].Value;
                    yahooWeatherCity.LISTA_PREVISIONI.Add(previsione);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return yahooWeatherCity;
        }       
    }
}
