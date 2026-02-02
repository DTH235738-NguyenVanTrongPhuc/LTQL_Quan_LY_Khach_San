using Quan_Ly_Khach_san.DATA;

namespace Quan_Ly_Khach_san
{
    public partial class frmKhachhang : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        bool xulythem = false;
        int id;
        public frmKhachhang()
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
            txtNamSinh.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<KhachHang> kh = new List<KhachHang>();
            kh = context.KhachHang.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = kh;
            // ho va ten
            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "TenKhachHang", false, DataSourceUpdateMode.Never);
            // Tương tự cho txtDienThoai 
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "SoDienThoai", false, DataSourceUpdateMode.Never);
            //dia chi
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            txtNamSinh.DataBindings.Clear();
            txtNamSinh.DataBindings.Add("Text", bindingSource, "NamSinh", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xulythem = true;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xulythem)
                {
                    KhachHang kh = new KhachHang();
                    kh.TenKhachHang = txtHoVaTen.Text;
                    kh.SoDienThoai = txtDienThoai.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    if (!DateTime.TryParse(txtNamSinh.Text, out DateTime namSinh))
                    {
                        MessageBox.Show("Năm sinh không hợp lệ! (vd: 01/01/2000)");
                        return;
                    }

                    kh.NamSinh = namSinh;

                    context.KhachHang.Add(kh);
                    context.SaveChanges();
                }
                else
                {
                    KhachHang? kh = context.KhachHang.Find(id);
                    if (kh != null)
                    {
                        kh.TenKhachHang = txtHoVaTen.Text;
                        kh.SoDienThoai = txtDienThoai.Text;
                        kh.DiaChi = txtDiaChi.Text;
                        if (!DateTime.TryParse(txtNamSinh.Text, out DateTime namSinh))
                        {
                            MessageBox.Show("Năm sinh không hợp lệ! (vd: 01/01/2000)");
                            return;
                        }

                        kh.NamSinh = namSinh;
                        context.KhachHang.Update(kh);
                    }
                    context.SaveChanges();
                }
            }
            frmKhachHang_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa khách hàng " + txtHoVaTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                KhachHang? kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                }
                context.SaveChanges();
                frmKhachHang_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulythem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }
    }
    
}
