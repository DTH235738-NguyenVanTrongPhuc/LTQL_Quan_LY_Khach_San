using Quan_Ly_Khach_san.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
namespace Quan_Ly_Khach_san.form
{
    public partial class frmNhanVien : Form
    {

        QLBHDbContext context = new QLBHDbContext();
        bool xulythem = false;
        int id;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtNamSinh.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;
            List<NhanVien> nv = new List<NhanVien>();
            nv = context.NhanVien.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;
            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "TenNhanVien", false, DataSourceUpdateMode.Never);
            // Tương tự đối với txtDienThoai
            txtNamSinh.DataBindings.Clear();
            txtNamSinh.DataBindings.Add("Text", bindingSource, "NamSinh", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
                
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "SoDienThoai", false, DataSourceUpdateMode.Never);

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", bindingSource, "MatKhau", false, DataSourceUpdateMode.Never);

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);

            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("SelectedItem", bindingSource, "QuyenHang", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulythem = true;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtNamSinh.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cboQuyenHan.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulythem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
                MessageBox.Show("Vui lòng nhập tên đăng nhập?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboQuyenHan.Text))
                MessageBox.Show("Vui lòng chọn quyền hạn cho nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xulythem)
                {
                    if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                        MessageBox.Show("Vui lòng nhập mật khẩu?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        NhanVien nv = new NhanVien();
                        nv.TenNhanVien = txtHoVaTen.Text;
                        nv.SoDienThoai = txtDienThoai.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        if (!DateTime.TryParse(txtNamSinh.Text, out DateTime namSinh))
                        {
                            MessageBox.Show("Năm sinh không hợp lệ! (vd: 01/01/2000)");
                            return;
                        }

                        nv.NamSinh = namSinh;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text); // Mã hóa mật khẩu
                        nv.QuyenHang = cboQuyenHan.SelectedItem?.ToString();

                        context.NhanVien.Add(nv);
                        context.SaveChanges();
                    }
                }
                else
                {
                    NhanVien? nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.TenNhanVien = txtHoVaTen.Text;
                        nv.SoDienThoai = txtDienThoai.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        if (!DateTime.TryParse(txtNamSinh.Text, out DateTime namSinh))
                        {
                            MessageBox.Show("Năm sinh không hợp lệ! (vd: 01/01/2000)");
                            return;
                        }

                        nv.NamSinh = namSinh;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.QuyenHang = cboQuyenHan.SelectedItem?.ToString();
                        context.NhanVien.Update(nv);
                        if (string.IsNullOrEmpty(txtMatKhau.Text))
                            context.Entry(nv).Property(x => x.MatKhau).IsModified = false; // Giữ nguyên mật khẩu cũ
                        else
                            nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text); // Cập nhật mật khẩu mới

                        context.SaveChanges();
                    }
                }
                frmNhanVien_Load(sender, e);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhân viên " + txtHoVaTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                NhanVien? nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                }
                context.SaveChanges();
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboQuyenHan_SelectedIndexChanged(object sender, EventArgs e)
        {
          //
        }
    }
}
