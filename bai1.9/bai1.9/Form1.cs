using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cost;
            int day = Convert.ToInt32(textBox1.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                if (day == 1)
                {
                    label3.Text = (day*200000).ToString() + " VND"; 
                }
                else
                {
                    label3.Text = (200000 + (day - 1)*180000).ToString() + " VND"; 
                }

            }

            if (comboBox1.SelectedIndex == 1)
            {
                if (day == 1)
                {
                    label3.Text = (day*180000).ToString() + " VND"; 
                }
                else
                {
                    label3.Text = (180000 + (day - 1)*150000).ToString() + " VND"; 
                }

            }
            

        }
    }
}
