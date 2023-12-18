using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_sınıfı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToSingle(txtSayi.Text);




            double mutlak=Math.Abs(sayi);
            double yuvarlamaUSt=Math.Ceiling(sayi);
            double kok=Math.Sqrt(sayi);
            double us = Math.Pow(sayi, 2);
            double asıgıYuvarlama=Math.Floor(sayi);
            double yuvarlama=Math.Round(sayi);




            lblMutlakdeger.Text = "  sayının mutlak degeri:     " + mutlak.ToString();
            lblYukarıYUvarlama.Text = "    sayının uste yuvarlama:  " + yuvarlamaUSt.ToString();
            lblKok.Text="    sayının kökunu alama    "+kok.ToString();
            lblUst.Text = " sayının ustu     " + us.ToString();
            lblAsagıYUvarlama.Text = "    sayının asagı yuvarlanması    " + asıgıYuvarlama.ToString();
            lblYuvarlama.Text = "    yuvarlama    " + yuvarlama.ToString();
         

        }
    }
}
