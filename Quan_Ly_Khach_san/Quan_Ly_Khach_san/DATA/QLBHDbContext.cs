using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_san.DATA
{
    internal class QLBHDbContext : DbContext
    {
        public DbSet<LoaiPhong> LoaiPhong { get; set; }
        public DbSet<Phong> Phong { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<DichVu> DichVu { get; set; }
        public DbSet<DatPhong> DatPhong { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLBHConnection"].ConnectionString);
        }
    }
}
