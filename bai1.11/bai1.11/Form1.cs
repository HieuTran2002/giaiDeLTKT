﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double toan = Convert.ToDouble(textBox1.Text);
            double ly = Convert.ToDouble(textBox2.Text);
            double hoa = Convert.ToDouble(textBox3.Text);

            double sum = toan + ly + hoa;

            label5.Text = sum.ToString();
            if (sum >= 15 && toan >= 5 && ly >= 5 && hoa >= 5)
            {
                label6.Text = "Đạt";
            }
            else
            {
                label6.Text = "Rớt";

            }
        }
    }
}
