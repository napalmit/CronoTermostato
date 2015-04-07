using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using Plasmoid.Extensions;

namespace WindowsFormsApplication4
{
    public partial class HomeGui : UserControl
    {

        public HomeGui()
        {
            //0,0,93
            InitializeComponent();
        }

        private void panelA_Paint(object sender, PaintEventArgs e)
        {
            panelA.BackColor = Color.Transparent;
            panelA.BorderStyle = BorderStyle.None;
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleEdgeFilter none = RectangleEdgeFilter.TopLeft | RectangleEdgeFilter.TopRight;
            graphics.FillRoundedRectangle(new SolidBrush(Color.FromArgb(100, 0, 0, 93)), float.Parse("0" + 0), float.Parse("0" + 0), float.Parse("0" + panelA.Width), float.Parse("0" + panelA.Height), 10, none);

        }

        private void panelB_Paint(object sender, PaintEventArgs e)
        {
            panelB.BackColor = Color.Transparent;
            panelB.BorderStyle = BorderStyle.None;
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleEdgeFilter none = RectangleEdgeFilter.BottomRight;
            graphics.FillRoundedRectangle(new SolidBrush(Color.FromArgb(100, 0, 0, 93)), float.Parse("0" + 0), float.Parse("0" + 0), float.Parse("0" + panelB.Width), float.Parse("0" + panelB.Height), 10, none);

        }

        Point[] PUNTO = new Point[] { new Point(0, 0), new Point(80, 0), new Point(80, 80) };
        private void panelC_Paint(object sender, PaintEventArgs e)
        {
            panelC.BackColor = Color.Transparent;
            panelC.BorderStyle = BorderStyle.None;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(100, 0, 0, 93)))
            {
                e.Graphics.FillPolygon(brush, PUNTO);
            }
        }
    }
}
