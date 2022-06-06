using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = "ket qua la : \n";
            int number = Convert.ToInt32(textBox1.Text);

            for (int i = 1; i <= 10; i++)
            {
                output += textBox1.Text + " x " + i.ToString() + " = " + (i * number).ToString() + "\n";
            }

            DialogResult result = MessageBox.Show(output, "Bạn có muốn tính tiếp không ?", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                textBox1.Text = "";
            }
            else
            {
                this.Close();
            }
        }
    }
}
