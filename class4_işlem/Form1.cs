using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class4_işlem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, sonuc;
            Dortislem islem = new Dortislem();
            s1=Convert.ToDouble(textBox1.Text);
            s2=Convert.ToDouble(textBox2.Text);
            if(radioButton1.Checked ==true)
            {
                sonuc=islem.toplam(s1, s2 );
                textBox3.Text=sonuc.ToString();
                label3.Text = "+";
            }
            else if(radioButton2.Checked ==true)
            {
                textBox3.Text=islem.cıkar(s1, s2 ).ToString();
                label3.Text = "-";
            }
            else if (radioButton3.Checked ==true)
            {
                textBox3.Text = islem.carp(s1, s2).ToString();
                label3.Text = "*";

            }
            else if (radioButton4.Checked ==true)
            {
                textBox3.Text = islem.böl(s1, s2).ToString();
                label3.Text = "/";
            }
            else if (radioButton5.Checked==true)
            {
                textBox3.Text = islem.mod(s1, s2).ToString();
                label3.Text = "%";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
    }
}
