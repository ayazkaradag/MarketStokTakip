using MarketStokTakip.CFEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketStokTakip
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        MarketContext context=new MarketContext();
        public void HijyenListele()
        {
            dgvHijyen.DataSource = context.Hijyen.ToList();
        }
        public void Temizle()
        {
            txtAd.Text = txtAdet.Text = txtFiyat.Text = txtMarka.Text = string.Empty;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            HijyenListele();
        }
        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Hijyen hijyen = new Hijyen();
            hijyen.UrunAdi=txtAd.Text;
            hijyen.UrunMarka=txtMarka.Text;
            hijyen.UrunAdet=int.Parse(txtAdet.Text);
            hijyen.UrunFiyat=double.Parse(txtFiyat.Text);
            context.Hijyen.Add(hijyen);
            context.SaveChanges();
            MessageBox.Show("Ürünler Eklendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            HijyenListele();
            Temizle();
        }
        
        

        private void dgvHijyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl0.Text= dgvHijyen.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dgvHijyen.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMarka.Text = dgvHijyen.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAdet.Text = dgvHijyen.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtFiyat.Text = dgvHijyen.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lbl0.Text);
            var hijyen_guncel=context.Hijyen.FirstOrDefault(x => x.UrunID == id);
            hijyen_guncel.UrunAdi=txtAd.Text;
            hijyen_guncel.UrunMarka=txtMarka.Text;
            hijyen_guncel.UrunAdet=int.Parse(txtAdet.Text);
            hijyen_guncel.UrunFiyat=double.Parse(txtFiyat.Text);
            context.SaveChanges();
            MessageBox.Show("Bilgiler Güncellendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            HijyenListele();
            Temizle();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lbl0.Text);
            var hijyen_sil=context.Hijyen.FirstOrDefault( x => x.UrunID == id);
            context.Hijyen.Remove(hijyen_sil);
            context.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HijyenListele();
            Temizle();

        }

        private void btnListele_Click(object sender, EventArgs e)
        {

        }
    }
}
