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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        MarketContext context=new MarketContext();
        public void IcecekListele()
        {
            dgvIcecek.DataSource=context.Icecekler.ToList();
        }
        public void Temizle()
        {
            txtAd.Text = txtAdet.Text = txtFiyat.Text = txtMarka.Text = string.Empty;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            IcecekListele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Icecek icecekEkle = new Icecek();
            icecekEkle.UrunAdi = txtAd.Text;
            icecekEkle.UrunMarka = txtMarka.Text;
            icecekEkle.UrunAdet = int.Parse(txtAdet.Text);
            icecekEkle.UrunFiyat = double.Parse(txtFiyat.Text);
            context.Icecekler.Add(icecekEkle);
            context.SaveChanges();
            MessageBox.Show("Ürünler Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            IcecekListele();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lbl0.Text);
            var icecek_guncel = context.Icecekler.FirstOrDefault(x => x.UrunID == id);
            icecek_guncel.UrunAdi = txtAd.Text;
            icecek_guncel.UrunMarka = txtMarka.Text;
            icecek_guncel.UrunAdet = int.Parse(txtAdet.Text);
            icecek_guncel.UrunFiyat = double.Parse(txtFiyat.Text);
            context.SaveChanges();
            MessageBox.Show("Bilgiler Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            IcecekListele();
            Temizle();
        }

        private void dgvIcecek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl0.Text = dgvIcecek.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dgvIcecek.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMarka.Text = dgvIcecek.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAdet.Text = dgvIcecek.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtFiyat.Text = dgvIcecek.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lbl0.Text);
            var icecek_sil = context.Icecekler.FirstOrDefault(x => x.UrunID == id);
            context.Icecekler.Remove(icecek_sil);
            context.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            IcecekListele();
            Temizle();
        }
    }
}
