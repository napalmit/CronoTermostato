using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            testc();
        }

        private void testc()
        {
            YahooWeather uy = new YahooWeather("courgne");
        }
    }
}
