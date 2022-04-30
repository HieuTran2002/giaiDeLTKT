using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1._12
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
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            label7.Text = (0.1 * a + 0.3 * b + c * 0.6).ToString();

            if ((0.1 *a + 0.3*b + c*0.6) > 5 && b >= 3)
            {
                label6.Text = "Good";
            }
            else
            {
                label6.Text = "Bad";
            }

        }
    }
}
