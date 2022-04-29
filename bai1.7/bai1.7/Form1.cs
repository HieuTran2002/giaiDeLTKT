using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = ( Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox3.Text)) / 3;
            if (sum >= 9)
            {
                label5.Text = sum.ToString();
                label4.Text = "gioi";
            }
            else if (sum >= 7 && sum < 9)
            {
                label5.Text = sum.ToString();
                label4.Text = "kha";
            }
            else if (sum >= 5 && sum < 7)
            {
                label5.Text = sum.ToString();
                label4.Text = "tb";
            }
            else if (sum < 5)
            {
                label5.Text = sum.ToString();
                label4.Text = "Dumbass";
            }
        }
    }
}
