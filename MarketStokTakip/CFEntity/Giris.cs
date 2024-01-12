using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStokTakip.CFEntity
{
    internal class Giris
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source = DESKTOP-PH0V7EJ\\SQLEXPRESS; Initial Catalog = MarketDB; Integrated Security = True");
            baglan.Open();
            return baglan;
        }
    }
}
