using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace banka
{
    public partial class Form1 : Form
    {
        int sayi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi++;
            listBox1.Items.Add(sayi);
        }
        void MasaIslem(string masa, TextBox txt)
        {
            if(listBox1.Items.Count > 0)
            {
               string ilk = listBox1.Items[0].ToString();
                listBox1.Items.RemoveAt(0);
                listBox2.Items.Add(masa + " numaralı masa = " + ilk + " numaralı müşteri");
                txt.Text = ilk;
            }
            else
            {
                MessageBox.Show("Bekleyen Kişi Yok");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MasaIslem("Masa 1", textBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MasaIslem("Masa 2", textBox2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MasaIslem("Masa 3", textBox3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MasaIslem("Masa 4", textBox4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MasaIslem("Masa 5", textBox5);
        }
    }
}
