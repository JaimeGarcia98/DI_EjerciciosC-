using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsumas
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

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int valorNum;
            int contador = 0;
            valorNum = Convert.ToInt32(numericUpDown1.Value);
            for (int i = 1; i <= valorNum; i++)
            {
                listBox1.Items.Add ( "Sumando :" + i);
                contador += i;
                if (checkBox1.Checked)
                {
                    listBox1.Items.Add ("Suma parcial: " + contador);
                }
            }
            listBox1.Items.Add("LA SUMA TOTAL ES: " + contador);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
