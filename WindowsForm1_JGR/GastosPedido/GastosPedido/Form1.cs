using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GastosPedido
{
    public partial class Form1 : Form
    {
        double precio_total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            double precio2;
            precio2 = 5.89;
            textBox1.Clear();
            textBox1.Text = Convert.ToString(precio2);
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double precio1;
            precio1 = 2.25;
            textBox1.Clear();
            textBox1.Text = Convert.ToString(precio1);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            double precio3;
            precio3 = 8.99;
            textBox1.Clear();
            textBox1.Text = Convert.ToString(precio3);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            double precio4;
            precio4 = 0.75;
            textBox2.Clear();
            textBox2.Text = Convert.ToString(precio4);
            if (checkBox2.Checked)
            {
                precio_total += 0.75;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double precio5;
            precio5 = 1.99;
            textBox2.Clear();
            textBox2.Text = Convert.ToString(precio5);
            if (checkBox1.Checked)
            {
                precio_total += 1.99;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            double precio6;
            precio6 = 3.25;
            textBox2.Clear();
            textBox2.Text = Convert.ToString(precio6);
            if (checkBox3.Checked)
            {
                precio_total += 3.25;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                precio_total +=2.25;
                
            }
            if (radioButton2.Checked)
            {
                precio_total += 5.89;
                
            }
            if (radioButton3.Checked)
            {
                precio_total += 8.99;
                
            }
            textBox3.Text = Convert.ToString(precio_total);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            precio_total = 0;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
