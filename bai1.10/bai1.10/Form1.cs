using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s = Convert.ToInt32(textBox1.Text);
            if (s <= 1)
            {
                label3.Text = (s * 13000).ToString();
            }
            if (s > 1 && s <= 30)
            {
                label3.Text = (13000 + (s - 1)*12000).ToString();
            }
            if (s > 30)
            {
                label3.Text = (13000 + (29)*12000 + (s - 30)*11000).ToString();
            }

        }
    }
}
