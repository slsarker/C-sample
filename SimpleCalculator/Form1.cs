using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBoxAns.Clear();

            textBox1.Focus();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            int sum = num1 + num2;
            textBoxAns.Text = sum.ToString();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            int sub = num1-num2;
            textBoxAns.Text = sub.ToString();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            long mul = num1 * num2;
            textBoxAns.Text = mul.ToString();
        }

        private void buttonDib_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            if (num2 == 0)
            {
                MessageBox.Show("Any number can not divided by 0");
            }
            else
            {
                double div = num1 / num2;
                textBoxAns.Text = div.ToString();
            }
        }
    }
}
