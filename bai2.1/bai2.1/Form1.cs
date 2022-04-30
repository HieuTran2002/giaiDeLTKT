using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Y_CheckedChanged(object sender, EventArgs e)
        {
            notA.Checked = !a.Checked;
            nand.Checked = !(notA.Checked & b.Checked & c.Checked);
            Y.Checked = (b.Checked | c.Checked);
            X.Checked = Y.Checked & nand.Checked & notA.Checked;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, a, b, c, not_a, NAND, x, y;
            label1.Text = "a    |   b   |   c   |   X   |   Y   \n";
            for (int i = 0; i < 8; i++)
            {
                n = i;
                c = n % 2;
                n = n / 2;
                b = n % 2;
                n = n / 2;
                a = n % 2;

                not_a = ~a;
                NAND = ~(not_a & b & c);
                y = b | c;
                x = not_a & NAND & y;
                label1.Text += a + "    |   " + b + "   |   " + c + "  |    " + x + "   |   " + y + "   \n";
            }
        }
    }
}
