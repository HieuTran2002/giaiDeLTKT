﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void X_CheckedChanged(object sender, EventArgs e)
        {
            notA.Checked = !a.Checked;
            and.Checked = a.Checked & b.Checked & c.Checked;
            Y.Checked = !(notA.Checked & c.Checked);
            X.Checked = Y.Checked | and.Checked | a.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "a    |   b   |   c   |   X   |   Y   \n";
            bool a, b, c, not_a, and, x, y;
            for (int i = 0; i < 8; i++)
            {
                bool[] bits = Enumerable.Range(0, 3)
                                        .Select(bitIndex => 1 << bitIndex)
                                        .Select(bitMask => (i & bitMask) == bitMask)
                                        .ToArray();
                a = bits[2];
                b = bits[1];
                c = bits[0];

                not_a = !a;
                and = (a & b & c);
                y = !(not_a & c);
                x = y | and | a;

                label1.Text += Convert.ToInt16(a) + "    |   " + Convert.ToInt16(b) + "   |   " + Convert.ToInt16(c) + "  |    " + Convert.ToInt16(x) + "   |   " + Convert.ToInt16(y) + "   \n";
            }
        }
    }
}
