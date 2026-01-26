using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_san.DATA
{
    internal class NhanVien
    {
        public int ID { get; set; }
        public string? TenNhanVien { get; set; }
        public DateTime NamSinh { get; set; }
        public string? SoDienThoai { get; set; }
        public string? DiaChi { get; set; }
        public string? QuyenHang {  get; set; }

        public virtual ObservableCollectionListSource<DatPhong> DatPhong { get; } = new();
    }
}
