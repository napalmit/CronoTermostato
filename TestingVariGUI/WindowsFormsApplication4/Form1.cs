﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YahooWeatherDLL;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Test();
        }

        private void Test()
        {
            YahooWeather uy = new YahooWeather("cuorgne");
            YahooWeatherCity city = uy.GetWeather();

        }
    }
}