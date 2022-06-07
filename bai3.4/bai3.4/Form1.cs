using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3._4
{
    public partial class Form1 : Form
    {
        int[,] myArray = new int[5, 5];
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
            if (count < 25)
            {

                myArray[row, col] = input;
                count++;
                col++;

                if (count % 5 == 0)
                {
                    row++;
                    col = 0;

                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    output += myArray[i, j].ToString() + "  ";
                }
                output += "\n";
            }

            label2.Text = getArray();

        }
        public string getArray()
        {
            string output = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    output += myArray[i, j].ToString() + "  ";
                }
                output += "\n";
            }

            return output;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myArray = new int[5, 5];
            col = 0;
            row = 0;
            count = 0;

            label2.Text = getArray();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            int result1 = 0;
            int result2 = 0;
            int result3 = 0;

            for (int i = 0; i < 5; i++)
            {
                result1 += myArray[i, i] + myArray[i, 4 - i];
                for (int j = 0; j < 5; j++)
                {
                    if ((i == 0 || i == 4) || (j == 0 || j == 4))
                    {
                        result2 += myArray[i, j];

                    }
                    result3 += myArray[i, j];
                }
            }
            result1 -= myArray[2,2];

            label3.Text = result1.ToString();
            label6.Text = result2.ToString();
            label8.Text = result3.ToString();
        }
    }
}
