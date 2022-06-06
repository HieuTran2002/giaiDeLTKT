﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3._5
{
    public partial class Form1 : Form
    {
        int[,] myArray = new int[6,6];
        int col = 0;
        int row = 0;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(textBox1.Text);
            string output = "";
            if (count < 36)
            {

                myArray[row, col] = input;
                count++;
                col++;
            
                if (count % 6 == 0)
                {
                    row++;
                    col = 0;

                }
                //MessageBox.Show(col.ToString() + "\n" + row.ToString() + "\n" + count.ToString());
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    output += myArray[i, j].ToString() + "  ";
                }
                output += "\n";
            }

            label2.Text = getArray();
        }

        // Hàm để lấy tất cả giá trị của mảng 6x6
        public string getArray()
        {
            string output = "";
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    output += myArray[i, j].ToString() + "  ";
                }
                output += "\n";
            }

            return output;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myArray = new int[6,6];
            col = 0;
            row = 0;
            count = 0;

            label2.Text = getArray();
        }
    }
}
