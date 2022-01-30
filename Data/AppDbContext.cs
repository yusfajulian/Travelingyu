using Microsoft.EntityFrameworkCore;
using Travelingyu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travelingyu.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options)
        {
            // Kosong
        }

        public virtual DbSet<Pelanggan> Tb_Pelanggan { get; set; }    // Tb_Blog adalah nama tabelnya
        public virtual DbSet<Pesawat> Tb_Pesawat { get; set; }
        public virtual DbSet<KelasPenerbangan> Tb_Kelas { get; set; }
        public virtual DbSet<Pemesanan> Tb_Transaksi { get; set; }
    }
}