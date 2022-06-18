using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTKT30
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

            int o = 0;
            if (a  <= 50)
            {
                o = 1300 * a;
            }  
            else if (a  > 50 && a <= 100)
            {
                o = 1300 * 50 + 1400 * (a - 50);
            } 
            else if (a  > 100)
            {
                o = 1300 * 50 + 1400 * 50 + 1600 * (a - 100);
            }
            label3.Text = o.ToString();

        }
    }
}
