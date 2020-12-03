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
    public partial class Form_MVC : Form
    {
        MVC model;
        public Form_MVC()
        {
            InitializeComponent();
            model = new MVC();
            model.observers += new System.EventHandler(this.updateMVC);
        }

        public class MVC
        {
            private int value;
            private int place;
            public System.EventHandler observers;
            public void setvalue(int value, int place) 
            {
                if (value > -1 && value <= 101)
                {
                    this.value = value;
                    this.place = place;
                    observers.Invoke(this, null);
                }
                return;
            }
            public int getValue()
            {
                return value;
            }

            public int getPlace()
            {
                return place;
            }
        };

        public void updateMVC(object sender, EventArgs e)
        {
            int k = model.getValue();
            if (model.getPlace() == 1)
            {
                num1.Value = k;
                hScrollBar1.Value = k;
                maskedTextBox1.Text = k.ToString();
                ++k;
                num2.Value = k;
                hScrollBar2.Value = k;
                maskedTextBox2.Text = k.ToString();
            }
            else
            {
                num2.Value = k;
                hScrollBar2.Value = k;
                maskedTextBox2.Text = k.ToString();
                --k;
                num1.Value = k;
                hScrollBar1.Value = k;
                maskedTextBox1.Text = k.ToString();
            }          
        }

        private void num1_ValueChanged(object sender, EventArgs e)
        {
            model.setvalue((int)num1.Value, 1);
        }

        private void num2_ValueChanged(object sender, EventArgs e)
        {
            model.setvalue((int)num2.Value, 2);
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            model.setvalue(hScrollBar1.Value, 1);
        }

        private void hScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            model.setvalue(hScrollBar2.Value, 2);
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            model.setvalue(Convert.ToInt32(maskedTextBox1.Text), 1);
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            model.setvalue(Convert.ToInt32(maskedTextBox2.Text), 2);
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            maskedTextBox2.Text = "";
        }
    }
}
