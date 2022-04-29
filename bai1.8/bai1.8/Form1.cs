using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(textBox1.Text);
            double b = Convert.ToInt32(textBox2.Text);

            if (a > 20 || b > 20)
            {
                label4.Text = ((a *2500 + b*3000) * 0.95).ToString();
            }
            else
            {
                label4.Text = (a*2500 + b*3000).ToString();
            }

            

        }
    }
}
