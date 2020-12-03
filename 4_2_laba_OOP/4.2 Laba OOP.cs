using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_2_laba_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            int num = hScrollBar1.Value;
            num1.Value = num;
            maskedTextBox1.Text = num.ToString();
            ++num;
            num2.Value = num;
            maskedTextBox2.Text = num.ToString();
        }

        private void num1_ValueChanged(object sender, EventArgs e)
        {
            int num = (int)num1.Value;
            hScrollBar1.Value = num;
            maskedTextBox1.Text = num.ToString();
            ++num;
            hScrollBar2.Value = num;
            maskedTextBox2.Text = num.ToString();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                int num = Convert.ToInt32(maskedTextBox1.Text);
                if (num <= 100)
                {
                    num1.Value = num;
                    hScrollBar1.Value = num;
                    ++num;
                    num2.Value = num;
                    hScrollBar2.Value = num;
                }
            }
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
        }

        private void num2_ValueChanged(object sender, EventArgs e)
        {
            int num = (int)num2.Value;
            hScrollBar2.Value = num;
            maskedTextBox2.Text = num.ToString();
            --num;
            hScrollBar1.Value = num;
            maskedTextBox1.Text = num.ToString();
        }

        private void hScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            int num = hScrollBar2.Value;
            num2.Value = num;
            maskedTextBox2.Text = num.ToString();
            --num;
            num1.Value = num;
            maskedTextBox1.Text = num.ToString();
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                int num = Convert.ToInt32(maskedTextBox2.Text);
                if (num <= 101)
                {
                    num2.Value = num;
                    hScrollBar2.Value = num;
                    --num;
                    num1.Value = num;
                    hScrollBar1.Value = num;
                }
            }
        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            maskedTextBox2.Text = "";
        }

        private void mvc_form_Click(object sender, EventArgs e)
        {
            Form MVC = new Form_MVC();
            MVC.Show();
        }
    }
}
