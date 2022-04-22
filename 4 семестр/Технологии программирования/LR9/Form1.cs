using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double h, r;
            try
            {
                h = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                h = 0;
            }
            try
            {
                r = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                r = 0;
            }
            label7.Text = string.Format("{0,10:####.##}", Math.PI * r * r);
            label8.Text = string.Format("{0,10:####.##}", Math.PI * r * r * h);
            label9.Text = string.Format("{0,10:####.##}", 2 * Math.PI * r * h + 2 * Math.PI * r * r);
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
