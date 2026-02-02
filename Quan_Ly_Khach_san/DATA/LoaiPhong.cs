using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_san.DATA
{
    internal class LoaiPhong
    {
        public int ID { get; set; }
        public string? TenLoai { get; set; }
        public int SoNguoiToiDa {  get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get; set; }

        public virtual ObservableCollectionListSource<Phong> Phong { get; } = new();
    }

}
