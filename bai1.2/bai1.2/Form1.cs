using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, delta, x1 = 0, x2 = 0;

            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);

            delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                label1.Text = delta.ToString();
                label2.Text = ((-b + Math.Sqrt(delta)) / (2 * a)).ToString();
                label3.Text = ((-b - Math.Sqrt(delta)) / (2 * a)).ToString();
            }
            else if (delta == 0)
            {
                label1.Text = delta.ToString();
                label2.Text = (-b / (2.0 * a)).ToString();
                label3.Text = (-b / (2.0 * a)).ToString();
            }
            else
            {
                label1.Text = delta.ToString();
                label2.Text = (-b / (2 * a)).ToString() + " + " + (Math.Sqrt(Math.Abs(delta)) / (2 * a)).ToString() + "i";
                label3.Text = (-b / (2 * a)).ToString() + " + " + (Math.Sqrt(Math.Abs(delta)) / (2 * a)).ToString() + "i";
            }
        }
    }
}
