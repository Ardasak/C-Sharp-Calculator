using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        char islem;
        bool ekran_temizlenecekmi;
        int ilk_sayi;
        int ikinci_sayi;
        float sonuc;
        public Form1()
        {
            InitializeComponent();
        }

        private void carpma_button_Click(object sender, EventArgs e)
        {
            islem = '*';
            ekran_temizlenecekmi = true;

            ilk_sayi = Convert.ToInt32(label1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ekran_temizlenecekmi)
            {
                label1.Text = "";
                ekran_temizlenecekmi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
           
            
            label1.Text += "1";
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ekran_temizlenecekmi)
            {
                label1.Text = "";
                ekran_temizlenecekmi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }


            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ekran_temizlenecekmi)
            {
                label1.Text = "";
                ekran_temizlenecekmi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }


            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ekran_temizlenecekmi)
            {
                label1.Text = "";
                ekran_temizlenecekmi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }


            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ekran_temizlenecekmi)
            {
                label1.Text = "";
                ekran_temizlenecekmi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }


            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ekran_temizlenecekmi)
            {
                label1.Text = "";
                ekran_temizlenecekmi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }


            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ekran_temizlenecekmi)
            {
                label1.Text = "";
                ekran_temizlenecekmi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }


            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ekran_temizlenecekmi)
            {
                label1.Text = "";
                ekran_temizlenecekmi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }


            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ekran_temizlenecekmi)
            {
                label1.Text = "";
                ekran_temizlenecekmi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }


            label1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (ekran_temizlenecekmi)
            {
                label1.Text = "";
                ekran_temizlenecekmi = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }


            label1.Text += "0";
        }

        private void silme_button_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            ekran_temizlenecekmi = false;
        }

        private void toplama_button_Click(object sender, EventArgs e)
        {
            islem = '+';
            ekran_temizlenecekmi = true;
            
            ilk_sayi = Convert.ToInt32(label1.Text);
            
        }

        private void cikartma_button_Click(object sender, EventArgs e)
        {
            islem = '-';
            ekran_temizlenecekmi = true;

            ilk_sayi = Convert.ToInt32(label1.Text);
        }

        private void bolme_button_Click(object sender, EventArgs e)
        {
            islem = '/';
            ekran_temizlenecekmi = true;

            ilk_sayi = Convert.ToInt32(label1.Text);
        }

        private void esittir_button_Click(object sender, EventArgs e)
        {
            ikinci_sayi = Convert.ToInt32(label1.Text);
            if(islem == '+')
            {
                sonuc = ilk_sayi + ikinci_sayi;
            }
            else if(islem == '-')
            {
                sonuc = ilk_sayi - ikinci_sayi;
            }
            else if(islem == '*')
            {
                sonuc = ilk_sayi * ikinci_sayi;
            }
            else if(islem=='/')
            {
                sonuc = ilk_sayi / ikinci_sayi;

            }
            label1.Text=Convert.ToString(sonuc);
        }
    }
}
