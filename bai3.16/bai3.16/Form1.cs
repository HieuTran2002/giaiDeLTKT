using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3._16
{
    public partial class Form1 : Form
    {
        double[] ring4Value = { 0, 1, 2, 3, 4, 0.5, 0.25, 0.1, 0.05, 5, 10 };
        string[] color12 = { "Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White" };
        string[] color3 = { "Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            int v1 = Convert.ToInt32(input.Substring(0, 1));
            int v2 = Convert.ToInt32(input.Substring(1, 1));
            int v3 = Convert.ToInt32(input.Substring(2, 1));
            int v4 = input.Length - 3;
            string v5 = textBox2.Text;

            pictureBox1.BackColor = Color.FromName(color12[v1]);
            pictureBox2.BackColor = Color.FromName(color12[v2]);
            pictureBox3.BackColor = Color.FromName(color12[v3]);
            pictureBox4.BackColor = Color.FromName(color12[v4]);

            if (v5 == "1") { pictureBox5.BackColor = Color.Brown; }
            if (v5 == "2") { pictureBox5.BackColor = Color.Red; }
            if (v5 == "0.5") { pictureBox5.BackColor = Color.Green; }
            if (v5 == "0.25") { pictureBox5.BackColor = Color.Blue; }
            if (v5 == "0.1") { pictureBox5.BackColor = Color.Violet; }
            if (v5 == "0.05") { pictureBox5.BackColor = Color.Gray; }
            if (v5 == "5") { pictureBox5.BackColor = Color.Gold; }
            if (v5 == "10") { pictureBox5.BackColor = Color.Silver; }

        }
    }
}
