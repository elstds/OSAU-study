using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR7
{
    public partial class Form1 : Form
    {
        Point[] Hexagon = new Point[] { new Point(50, 300-20), new Point(130, 470 - 20), new Point(300, 550 - 20), new Point(470, 470 - 20), new Point(550, 300 - 20), new Point(470, 130 - 20), new Point(300, 50 - 20), new Point(130, 130 - 20) };
        Pen b_p = new Pen(Color.Black, 6);
        Pen w_p = new Pen(Color.White, 10);
        SolidBrush w_brush = new SolidBrush(Color.White);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillPolygon(w_brush, Hexagon);
            g.DrawLine(b_p, 180, 160, 420, 160);
            g.DrawLine(b_p, 180, 160, 300, 300);
            g.DrawLine(b_p, 180, 420, 300, 300);
            g.DrawLine(b_p, 180, 420, 420, 420);

        }
    }
}
