using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_san.DATA
{
    internal class KhachHang
    {
        public int ID {  get; set; }
        public string? TenKhachHang { get; set; }
        public DateTime NamSinh { get; set; }
        public string? SoDienThoai {  get; set; }
        public string? DiaChi { get; set; }
        public virtual ObservableCollectionListSource<DatPhong> DatPhong { get; } = new();

    }
}
