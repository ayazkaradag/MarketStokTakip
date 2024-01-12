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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 gida = new Form3();
            gida.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form5 icecek = new Form5();
            icecek.Show();
            
        }

        private void btnHijyen_Click(object sender, EventArgs e)
        {
            Form4 hijyen = new Form4();
            hijyen.Show();
            
        }

        private void btnSorgu_Click(object sender, EventArgs e)
        {
            Form6 sorgu = new Form6();
            sorgu.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
