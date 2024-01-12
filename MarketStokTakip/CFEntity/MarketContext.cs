using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStokTakip.CFEntity
{
    public class MarketContext:DbContext
    {
        public DbSet<Icecek> Icecekler { get; set; }
        public DbSet<Hijyen> Hijyen { get; set; }
        public DbSet<Gida> Gidas { get; set; }
    }
}
