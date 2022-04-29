using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox3.Text);

            if (comboBox1.SelectedIndex == 0)
            {
                label1.Text = (a + b).ToString();

            }
            if (comboBox1.SelectedIndex == 1)
            {
                label1.Text = (a - b).ToString();

            }
            if (comboBox1.SelectedIndex == 2)
            {
                label1.Text = (a * b).ToString();

            }
            if (comboBox1.SelectedIndex == 3)
            {
                if (b == 0)
                {
                    label1.Text = "không chia được";
                }
                else
                {
                    label1.Text = (a / b).ToString();

                }

            }
        }
    }
}
