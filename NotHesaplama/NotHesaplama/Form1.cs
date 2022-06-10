using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mgn, vko, fko, vn, fn, ortalama;
            mgn = Convert.ToDouble(textBox1.Text);
            vko = Convert.ToDouble(textBox2.Text);
            fko = Convert.ToDouble(textBox3.Text);
            vn = Convert.ToDouble(textBox4.Text);
            fn= Convert.ToDouble(textBox5.Text);
            ortalama = (vn*vko)/100+(fn*fko)/100;
            labelOrt.Text = ortalama.ToString();
            if (ortalama < mgn)
                labelSonuc.Text = "Kaldınız.";
            else
                labelSonuc.Text = "Geçtiniz.";
        }
    }
}
