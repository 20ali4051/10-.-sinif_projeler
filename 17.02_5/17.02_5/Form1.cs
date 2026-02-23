using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17._02_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                txtBilgi.Text = "";
                txtBilgi.Text += txtAdSoyad.Text + "\r\n";
                txtBilgi.Text += txtTelefon.Text + "\r\n";
                txtBilgi.Text += txtAdres.Text + "\r\n";
                decimal hesap = 0;
                if (nCorba.Value > 0)
                {
                    hesap += nCorba.Value * 12;
                    txtBilgi.Text += ("Çorba { 0:C}", Convert.ToString(nCorba.Value * 12) + "\r\n");
                }
                txtBilgi.Text += "-----------------";
                txtBilgi.Text += ("Toplam { 0:C}", Convert.ToString(hesap));
            }
        }
    }
}
