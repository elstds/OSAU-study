using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR6
{
    public partial class Form1 : Form
    {
        double x_min, x_max, step;
        double x, y1,y2;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_build_Click(object sender, EventArgs e)
        {
            if(textBox_xmin.Text == "" || textBox_xmax.Text == "" || textBox_step.Text == "")
            {
                MessageBox.Show("Применяются значения по умолчанию");
                DefaultParams();
            }
            else
            {
                x_min = Convert.ToDouble(textBox_xmin.Text);
                x_max = Convert.ToDouble(textBox_xmax.Text);
                step = Convert.ToDouble(textBox_step.Text);
            }
            x = x_min;

            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            while(x <= x_max)
            {
                y1 = Math.Cos(x);
                this.chart1.Series[0].Points.AddXY(x, y1);
                y2 = Math.Sin(x);
                this.chart1.Series[1].Points.AddXY(x, y2);
                x += step;
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void DefaultParams()
        {
            x_min = -10;
            x_max = 10;
            step = 0.1;
        }
    }
}
