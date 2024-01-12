using MarketStokTakip.CFEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketStokTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Giris bgl = new Giris();
        public void Temizle()
        {
            txtKullanici.Text = txtSifre.Text = string.Empty;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           /* using(MarketContext context= new MarketContext())
            {
                context.Database.Create(); */
            }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select *from Personel where KullaniciAdi=@kullanici and Sifre=@sifre", bgl.baglanti());
            komut.Parameters.AddWithValue("@Kullanici", txtKullanici.Text);
            komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 secim = new Form2();
                secim.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre, tekrar deneyiniz.");
                Temizle();
            }
            bgl.baglanti().Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKullanici.Text = txtSifre.Text  = string.Empty;
        }
    }
    }

