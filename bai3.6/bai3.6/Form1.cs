﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3._6
{
    public partial class Form1 : Form
    {
        int[,] myArray = new int[3, 3];
        int col = 0;
        int row = 0;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public string getArray()
        {
            string output = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    output += myArray[i, j].ToString() + "  ";
                }
                output += "\n";
            }

            return output;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(textBox1.Text);
            string output = "";
            if (count < 9)
            {

                myArray[row, col] = input;
                count++;
                col++;

                if (count % 3 == 0)
                {
                    row++;
                    col = 0;

                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    output += myArray[i, j].ToString() + "  ";
                }
                output += "\n";
            }

            label2.Text = getArray();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int result1 = 0;
            int result2 = 0;
            int result3 = 0;

            for (int i = 0; i < 3; i++)
            {
                result1 += myArray[i, i] + myArray[i, 2 - i];
                for (int j = 0; j < 3; j++)
                {
                    if ((i == 0 || i == 2) || (j == 0 || j == 2))
                    {
                        result2 += myArray[i, j];

                    }
                    result3 += myArray[i, j];
                }
            }
            result1 -= myArray[1, 1];

            label3.Text = result1.ToString();
            label6.Text = result2.ToString();
            label8.Text = result3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myArray = new int[6, 6];
            col = 0;
            row = 0;
            count = 0;

            label3.Text = "";
            label6.Text = "";
            label8.Text = "";

            label2.Text = getArray();
        }
    }
}
