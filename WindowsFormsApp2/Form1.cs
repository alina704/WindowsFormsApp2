using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Flag;
        public double a,b;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void minus_Click(object sender, EventArgs e)
        {
            Flag = 1;
            label1.Text = "-";
            a = Convert.ToDouble(tb.Text);
            tb.Text = "-";

        }

        private void umnogenie_Click(object sender, EventArgs e)
        {
            Flag = 2;
            label1.Text = "*";
            a = Convert.ToDouble(tb.Text);
            tb.Text = "*";

        }

        private void delenie_Click(object sender, EventArgs e)
        {
            Flag = 3;
            label1.Text = "/";
            a = Convert.ToDouble(tb.Text);
            tb.Text = "/";

        }

        private void ochstit_Click(object sender, EventArgs e)
        {
            tb.Text = " ";
            a = 0;
            b = 0;

        }

        private void one_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "2";
        }

        private void chree_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "9";
        }

        private void ravno_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(tb.Text);


            if (Flag == 0)
            {
                tb.Text = Convert.ToString(a + b);
            }
            if (Flag == 1)
            {
                tb.Text = Convert.ToString(a - b);
            }
            if (Flag == 2)
            {
               tb.Text = Convert.ToString(a * b);
            }
            if (Flag == 3)
            {
                tb.Text = Convert.ToString(a / b);
            }


        }

        private void nul_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Flag = 0;
            label1.Text = "+";
            a = Convert.ToDouble(tb.Text);
            tb.Text = "+";

        }
    }
}