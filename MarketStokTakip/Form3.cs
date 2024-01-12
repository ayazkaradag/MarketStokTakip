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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        MarketContext context=new MarketContext();

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-PH0V7EJ\\SQLEXPRESS;Initial Catalog=MarketDB;Integrated Security=True");
        public void GidaListele()
        {
            dgvGida.DataSource = context.Gidas.ToList();
        }
        public void Temizle()
        {
            txtAd.Clear();
            txtMarka.Clear();
            txtAdet.Clear();
            txtFiyat.Clear();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            GidaListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand ekle = new SqlCommand("insert into Gidas(UrunAdi, UrunMarka, UrunAdet, UrunFiyat) values(@adi, @marka, @adet, @fiyat)", baglan);
            ekle.Parameters.AddWithValue("@adi", txtAd.Text);
            ekle.Parameters.AddWithValue("@marka", txtMarka.Text);
            ekle.Parameters.AddWithValue("@adet", txtAdet.Text);
            ekle.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("Ürünler Kaydedildi");
            baglan.Close();
            GidaListele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dgvGida_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl0.Text = dgvGida.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dgvGida.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMarka.Text = dgvGida.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAdet.Text = dgvGida.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtFiyat.Text = dgvGida.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand sil = new SqlCommand("delete from Gidas where UrunAdi=@ad", baglan);
            sil.Parameters.AddWithValue("@ad", txtAd.Text);
            sil.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Tamamlanmıştır", "Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglan.Close();
            GidaListele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand guncelle = new SqlCommand("update Gidas set UrunAdi=@ad, UrunMarka=@marka, UrunAdet=@adet, UrunFiyat=@fiyat", baglan);
            guncelle.Parameters.AddWithValue("@ad", txtAd.Text);
            guncelle.Parameters.AddWithValue("@marka", txtMarka.Text);
            guncelle.Parameters.AddWithValue("@adet", txtAdet.Text);
            guncelle.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Güncelleme İşlemi Tamamlanmıştır", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglan.Close();
            GidaListele();
            Temizle();
        }

        private void dgvGida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvGida_DefaultCellStyleChanged(object sender, EventArgs e)
        {

        }

        private void dgvGida_CellStyleChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
