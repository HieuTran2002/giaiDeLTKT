using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1._13
{
    public partial class Form1 : Form
    {
        double[] ring4Value = { 0, 1, 2, 3, 4, 0.5, 0.25, 0.1, 0.05, 5, 10 };
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.BackColor = System.Drawing.ColorTranslator.FromHtml(comboBox1.Text);
            calculate();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox2.BackColor = System.Drawing.ColorTranslator.FromHtml(comboBox2.Text);
            calculate();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox3.BackColor = System.Drawing.ColorTranslator.FromHtml(comboBox3.Text);
            calculate();

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox4.BackColor = System.Drawing.ColorTranslator.FromHtml(comboBox4.Text);
            calculate();

        }


        private void calculate()
        {
            double ring1 = comboBox1.SelectedIndex;
            double ring2 = comboBox2.SelectedIndex;
            double ring3 = 0;
            double ring4 = 0;
            double result1 = 0;

            //Kiểm tra giá trị cho vòng 4
            if (comboBox4.SelectedIndex < 0)
            {
                ring4 = 0;
            }
            else
            {
                ring4 = ring4Value[comboBox4.SelectedIndex];
            }

            //Gán giá trị cho vòng 3
            if (comboBox3.Text == "gold")
            {
                ring3 = -1;
            }
            else if (comboBox3.Text == "silver")
            {
                ring3 = -2;
            }
            else
            {
                ring3 = comboBox3.SelectedIndex;

            }

            //tính giá trị 3 vòng đầu
            if (ring1 != 0)
            {
                result1 = (ring1 * 10 + ring2) * (Math.Pow(10, ring3));
            }
            else
            {
                result1 = 0;
            }

            label1.Text = ring1.ToString();
            label2.Text = ring2.ToString();
            label3.Text = ring3.ToString();
            label4.Text = "+-" + ring4.ToString() + " %";
            label6.Text = result1.ToString() + "    " + label4.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
