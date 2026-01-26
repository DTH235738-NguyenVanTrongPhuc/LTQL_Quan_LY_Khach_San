using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_san.DATA
{
    internal class Phong
    {
        public int ID { get; set; }
        public int LoaiPhongID { get; set; }
       //public int DichVUID { get; set; }
        public string? TenPhong { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public string? TrangThaiPhong { get; set; }
        public virtual ObservableCollectionListSource<DatPhong> DatPhong { get; } = new();
        public virtual LoaiPhong LoaiPhong { get; set; } = null!;
        public virtual DichVu Dichvu { get; set; } = null!;
    }
}
