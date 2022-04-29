using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label1.Text = (
                    Convert.ToDouble(textBox1.Text) +
                    Convert.ToDouble(textBox2.Text) +
                    Convert.ToDouble(textBox3.Text)
                    ).ToString();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label1.Text = (
                    Convert.ToDouble(textBox1.Text) +
                    Convert.ToDouble(textBox2.Text) +
                    Convert.ToDouble(textBox3.Text) +
                    1
                    ).ToString();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label1.Text = (
                    Convert.ToDouble(textBox1.Text) +
                    Convert.ToDouble(textBox2.Text) +
                    Convert.ToDouble(textBox3.Text) +
                    1.5
                    ).ToString();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                label1.Text = (
                    Convert.ToDouble(textBox1.Text) +
                    Convert.ToDouble(textBox2.Text) +
                    Convert.ToDouble(textBox3.Text) + 
                    2
                    ).ToString();
            }

        }
    }
}
