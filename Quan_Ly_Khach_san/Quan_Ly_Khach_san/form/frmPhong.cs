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
    public partial class frmPhong : Form
    {

        QLBHDbContext context = new QLBHDbContext();
        bool xulythem = false;
        int id;
        public frmPhong()
        {
            InitializeComponent();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView1.AutoGenerateColumns = false;
            List<NhanVien> nv = new List<NhanVien>();
            nv = context.NhanVien.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;
            txttenphong.DataBindings.Clear();
            txttenphong.DataBindings.Add("Text", bindingSource, "phong", false, DataSourceUpdateMode.Never);
            // Tương tự đối với txtDienThoai
            txtghichu.DataBindings.Clear();
            txtghichu.DataBindings.Add("Text", bindingSource, "ghichu", false, DataSourceUpdateMode.Never);

            cbTang.DataBindings.Clear();
            cbTang.DataBindings.Add("SelectedItem", bindingSource, "tang", false, DataSourceUpdateMode.Never);

            cbtrangthai.DataBindings.Clear();
            cbtrangthai.DataBindings.Add("SelectedItem", bindingSource, "trangthai", false, DataSourceUpdateMode.Never);

            cbLoaiPhong.DataBindings.Clear();
            cbLoaiPhong.DataBindings.Add("SelectedItem", bindingSource, "loaiphong", false, DataSourceUpdateMode.Never);

            dataGridViewphong.DataSource = bindingSource;
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnhuy.Enabled = giaTri;
            btnluu.Enabled = giaTri;
            txttenphong.Enabled = giaTri;
            txtghichu.Enabled = giaTri;
            txttimkiem.Enabled = giaTri;
            cbLoaiPhong.Enabled = giaTri;
            cbTang.Enabled = giaTri;
            cbtrangthai.Enabled = giaTri;
            btnthem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnxoa.Enabled = !giaTri;
            btntimkiem.Enabled = !giaTri;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            xulythem = true;
            BatTatChucNang(true);
            txttimkiem.Clear();
            txttenphong.Clear();
            txtghichu.Clear();
            cbLoaiPhong.Text = "";
            cbTang.Text = "";
            cbtrangthai.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulythem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txttenphong.Text))
                MessageBox.Show("Vui lòng nhập họ và tên Tên phòng ?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cbLoaiPhong.Text))
                MessageBox.Show("Vui lòng chọn Loại Phòng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cbtrangthai.Text))
                MessageBox.Show("Vui lòng chọn trạng thái phòng ?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cbTang.Text))
                MessageBox.Show("Vui lòng chọn Tầng của phòng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xulythem)
                {
                    if (string.IsNullOrWhiteSpace(txttenphong.Text))
                        MessageBox.Show("Vui lòng nhập mật khẩu?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        Phong p = new Phong();
                        p.TenPhong = txttenphong.Text;
                        p.GhiChu = txtghichu.Text;
                        p.TrangThaiPhong = cbtrangthai.ToString();
                        context.Phong.Add(p);
                        context.SaveChanges();
                    }
                }
                else
                {
                    Phong? p = context.Phong.Find(id);
                    if (p != null)
                    {
                        Phong p = new Phong();
                        p.TenPhong = txttenphong.Text;
                        p.GhiChu = txtghichu.Text;
                        p.TrangThaiPhong = cbtrangthai.ToString();
                        context.Phong.Add(p);
                        context.SaveChanges();
                    }
                }
                frmPhong_Load(sender, e);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhân viên " + txttenphong.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                Phong? p = context.Phong.Find(id);
                if (p != null)
                {
                    context.NhanVien.Remove(nv);
                }
                context.SaveChanges();
                frmPhong_Load(sender, e);
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            frmPhong_Load(sender.GetType(), e);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //private void btnThemPhong_Click(object sender, EventArgs e)
        //{
        //    int roomNumber = flpl.Controls.Count + 101;
        //    CreateRoom(roomNumber);
        //}
    }
}
