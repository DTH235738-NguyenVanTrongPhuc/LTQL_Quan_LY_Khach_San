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

namespace Quan_Ly_Khach_san.form
{
    public partial class frmDichVu : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        bool xulythem = false;
        int id;
        public frmDichVu()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {

            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtDonGia.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            txtTenDichVu.Enabled = giaTri;
            cboTrangThai.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;
            List<NhanVien> nv = new List<NhanVien>();
            nv = context.NhanVien.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;
            txtTenDichVu.DataBindings.Clear();
            txtTenDichVu.DataBindings.Add("Text", bindingSource, "TenDichVu", false, DataSourceUpdateMode.Never);
            // Tương tự đối với txtDienThoai
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", bindingSource, "DonGia", false, DataSourceUpdateMode.Never);

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);

            cboTrangThai.DataBindings.Clear();
            cboTrangThai.DataBindings.Add("SelectedItem", bindingSource, "", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulythem = true;
            BatTatChucNang(true);
            txtTenDichVu.Clear();
            txtDonGia.Clear();
            txtMoTa.Clear();
            cboTrangThai.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulythem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDichVu.Text))
                MessageBox.Show("Vui lòng nhập tên dịch vụ?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtDonGia.Text))
                MessageBox.Show("Vui lòng nhập đơn giá?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboTrangThai.Text))
                MessageBox.Show("Vui lòng chọn trạng thái cho dịch vụ?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xulythem)
                {

                    DichVu dv = new DichVu();
                    dv.TenDichVu = txtTenDichVu.Text;
                    dv.DonGia = int.Parse(txtDonGia.Text);
                    dv.MoTa = txtMoTa.Text;

                    dv.TrangThai = cboTrangThai.SelectedItem?.ToString();

                    context.DichVu.Add(dv);
                    context.SaveChanges();

                }
                else
                {
                    DichVu? dv = context.DichVu.Find(id);
                    if (dv != null)
                    {
                        dv.TenDichVu = txtTenDichVu.Text;
                        dv.DonGia = int.Parse(txtDonGia.Text);
                        dv.MoTa = txtMoTa.Text;
                        dv.TrangThai = cboTrangThai.SelectedItem?.ToString();
                        context.DichVu.Update(dv);


                    }
                    context.SaveChanges();
                }

            }
            frmDichVu_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa dich vu " + txtTenDichVu.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                DichVu? dv = context.DichVu.Find(id);
                if (dv != null)
                {
                    context.DichVu.Remove(dv);
                }
                context.SaveChanges();
                frmDichVu_Load(sender, e);
            }

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmDichVu_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
