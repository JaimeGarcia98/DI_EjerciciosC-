using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaMaquinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            double precioagua;
            precioagua = 1.01;
            textBox2.Text = "Agua";
            textBox4.Text = Convert.ToString(precioagua);

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            double preciocola;
            preciocola = 1.85;
            textBox2.Text = "Coca Cola";
            textBox4.Text = Convert.ToString(preciocola);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            double preciofanta;
            preciofanta = 1.55;
            textBox2.Text = "Fanta";
            textBox4.Text = Convert.ToString(preciofanta);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            double preciopow;
            preciopow = 2.55;
            textBox2.Text = "Powerade";
            textBox4.Text = Convert.ToString(preciopow);
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            double preciomons;
            preciomons = 2.15;
            textBox2.Text = "Monster";
            textBox4.Text = Convert.ToString(preciomons);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            double precionest;
            precionest = 1.60;
            textBox2.Text = "Nestea";
            textBox4.Text = Convert.ToString(precionest);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total;
            double saldo;
            saldo = 0;
            total = 0;
            if (checkBox1.Checked)
            {
                total += 1.01;
            }
            if (checkBox2.Checked)
            {
                total += 1.85;
            }
            if (checkBox3.Checked)
            {
                total += 2.55;
            }
            if (checkBox4.Checked)
            {
                total += 1.60;
            }
            if (checkBox5.Checked)
            {
                total += 2.15;
            }
            if (checkBox6.Checked)
            {
                total += 1.55;
            }
            saldo = Convert.ToDouble(textBox1.Text);
            if(saldo >= total)
            {
                double vuelta = 0;
                vuelta = saldo - total;
                textBox3.Text = Convert.ToString(vuelta);
            }
            if (saldo < total)
            {
                label5.Text = "No tiene suficiente dinero";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
