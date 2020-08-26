using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                total = total + 5000;
            }
            else
            {
                total = total - 5000;
            }
            textBox3.Text = total.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                if (checkBox2.Checked == true)
                {
                    total = total + 9000;
                }
                else
                {
                    total = total - 9000;
                }
                textBox3.Text = total.ToString();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                if (checkBox3.Checked == true)
                {
                    total = total + 12000;
                }
                else
                {
                    total = total - 12000;
                }
                textBox3.Text = total.ToString();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                if (checkBox4.Checked == true)
                {
                    total = total + 2000;
                }
                else
                {
                    total = total - 2000;
                }
                textBox3.Text = total.ToString();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                if (checkBox5.Checked == true)
                {
                    total = total + 150;
                }
                else
                {
                    total = total - 150;
                }
                textBox3.Text = total.ToString();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                if (checkBox6.Checked == true)
                {
                    total = total + 100;
                }
                else
                {
                    total = total - 100;
                }
                textBox3.Text = total.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mr/Ms " + textBox1.Text + " your bill is " + textBox3.Text + " " + DateTime.Now);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
