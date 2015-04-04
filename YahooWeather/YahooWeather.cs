﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using YahooWeather;
using YahooWeather.Properties;

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

        public void GetWeather()
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

                yahooWeatherCity.TEMPERATURE_UNIT = channel.SelectSingleNode("yweather:units", man).Attributes["temperature"].Value;

                yahooWeatherCity.CHILL = channel.SelectSingleNode("yweather:wind", man).Attributes["chill"].Value;

                yahooWeatherCity.HUMIDITY = channel.SelectSingleNode("yweather:atmosphere", man).Attributes["humidity"].Value;

                yahooWeatherCity.SUNRISE = channel.SelectSingleNode("yweather:astronomy", man).Attributes["sunrise"].Value;

                yahooWeatherCity.SUNSET = channel.SelectSingleNode("yweather:astronomy", man).Attributes["sunset"].Value;

                yahooWeatherCity.CODE = channel.SelectSingleNode("yweather:condition", man).Attributes["code"].Value;

                yahooWeatherCity.TEMPERATURE = channel.SelectSingleNode("yweather:condition", man).Attributes["temp"].Value;

                yahooWeatherCity.IMG = "http://l.yimg.com/a/i/us/we/52/" + yahooWeatherCity.CODE + ".gif";

                yahooWeatherCity.LISTA_PREVISIONI = new List<Previsione>();
                XmlNodeList previsioni = channel.SelectSingleNode("item").SelectNodes("yweather:forecast", man);
                foreach (XmlNode previsioneGiorno in previsioni)
                {
                    Previsione previsione = new Previsione();
                    previsione.GIORNO = previsioneGiorno.Attributes["day"].Value;
                    previsione.DATA = previsioneGiorno.Attributes["date"].Value;
                    previsione.CODE = previsioneGiorno.Attributes["code"].Value;
                    previsione.IMG = "http://l.yimg.com/a/i/us/we/52/" + previsione.CODE + ".gif";
                    yahooWeatherCity.LISTA_PREVISIONI.Add(previsione);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }       
    }
}
