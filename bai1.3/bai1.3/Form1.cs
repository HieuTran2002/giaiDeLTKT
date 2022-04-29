using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            label1.Text = giaiThua(a).ToString();

        }
        private int giaiThua(int a)
        {
            int result = 1;
            for (int i = 1; i <= a; i++)
            {
                result *= i;
            }
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int64 a = Convert.ToInt64(textBox1.Text);
            double result = 0;
            for (int i = 1; i <= a; i++)
            {
                if (i <= 3)
                {
                    result += Math.Pow(i + a, (double)a) / giaiThua(i);
                }
                else if (i > 3)
                {
                    result += Math.Pow(4 + a, (double)a) / giaiThua(i);

                }
            }
            label1.Text = result.ToString();

        }
    }
}
