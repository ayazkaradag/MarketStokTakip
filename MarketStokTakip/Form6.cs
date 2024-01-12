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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        MarketContext context=new MarketContext();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PH0V7EJ\\SQLEXPRESS;Initial Catalog=MarketDB;Integrated Security=True");
        
        public void Temizle()
        {
            txtHijyenAdi.Text =  string.Empty;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("select * from Hijyens Where UrunAdi like '%" + txtHijyenAdi.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSorgu.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally { conn.Close(); }
            txtHijyenAdi.Text = string.Empty;
        }

        private void txt_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("select * from Gidas Where UrunAdi like '%" + txtGidaAdi.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSorgu.DataSource = dt;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally { conn.Close(); }
            txtGidaAdi.Text = string.Empty;
        }

        private void btnIcecekAra_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("select * from Iceceks Where UrunAdi like '%" + txtIcecekAdi.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSorgu.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally { conn.Close(); }
            txtIcecekAdi.Text = string.Empty;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
