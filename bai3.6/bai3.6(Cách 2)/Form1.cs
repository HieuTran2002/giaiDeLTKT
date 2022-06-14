using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3._6_Cách_2_
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
            int result = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result += myArray[i, j];
                }
            }
            label3.Text = (myArray[0,0] + myArray[1,1] + myArray[2,2] + myArray[0,2] + myArray[2,0]).ToString();
            label6.Text = (result - myArray[1,1]).ToString();
            label8.Text = result.ToString();
        }
    }
}
