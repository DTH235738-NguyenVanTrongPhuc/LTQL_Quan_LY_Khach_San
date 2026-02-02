using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_san.DATA
{
    internal class DatPhong
    {
        public int ID { get; set; }
        public int PhongID { get; set; }
        public int KhachHangID { get; set; }

        public int NhanVienID { get; set; }
        public DateTime NgayDatPhong { get; set; }
        public DateTime NgayNhanPhong { get; set; }
        public DateTime NgayTraPhong {  get; set; }


        public virtual Phong Phong { get; set; } = null!;
        public virtual KhachHang KhachHang { get; set; } = null!;
        public virtual NhanVien NhanVien{ get; set; } = null!;


    }

}
