using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStokTakip.CFEntity
{
    public class Hijyen
    {
        [Key]
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public string UrunMarka { get; set; }
        public int UrunAdet { get; set; }
        public double UrunFiyat { get; set; }
    }
}
