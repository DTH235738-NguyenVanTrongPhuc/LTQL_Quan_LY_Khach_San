namespace Quan_Ly_Khach_san.form
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtNamSinh = new TextBox();
            txtDiaChi = new TextBox();
            txtHoVaTen = new TextBox();
            label4 = new Label();
            txtDienThoai = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txtMatKhau = new TextBox();
            label7 = new Label();
            txtTenDangNhap = new TextBox();
            label6 = new Label();
            cboQuyenHan = new ComboBox();
            label5 = new Label();
            HoVaTen = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            NamSInh = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 189);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1399, 356);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách Hàng";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { HoVaTen, DiaChi, DienThoai, NamSInh, QuyenHan, TenDangNhap });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1393, 330);
            dataGridView.TabIndex = 4;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1095, 96);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 12;
            btnXuat.Text = "Xuất..";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1095, 61);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 10;
            btnNhap.Text = "Nhập..";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1095, 30);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm kiếm ";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(972, 96);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(972, 61);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 10;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(972, 26);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(872, 96);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(872, 61);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(872, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtNamSinh
            // 
            txtNamSinh.Location = new Point(662, 77);
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Size = new Size(154, 27);
            txtNamSinh.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(136, 81);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(392, 27);
            txtDiaChi.TabIndex = 5;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(136, 39);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(274, 27);
            txtHoVaTen.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(561, 80);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 3;
            label4.Text = "Nam sinh";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(662, 39);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(154, 27);
            txtDienThoai.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 42);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(561, 39);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 87);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtNamSinh);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1232, 171);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Nhân viên";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(822, 133);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(331, 27);
            txtMatKhau.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(745, 136);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 17;
            label7.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(441, 133);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(274, 27);
            txtTenDangNhap.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(328, 136);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 15;
            label6.Text = "Tên đăng nhập";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Admin", "Nhan Vien" });
            cboQuyenHan.Location = new Point(136, 133);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(151, 28);
            cboQuyenHan.TabIndex = 14;
            cboQuyenHan.SelectedIndexChanged += cboQuyenHan_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 136);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 13;
            label5.Text = "Quyền hạn";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "TenNhanVien";
            HoVaTen.HeaderText = "Tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "SoDienThoai";
            DienThoai.HeaderText = "Số điện thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            // 
            // NamSInh
            // 
            NamSInh.DataPropertyName = "NamSinh";
            NamSInh.HeaderText = "Năm sinh";
            NamSInh.MinimumWidth = 6;
            NamSInh.Name = "NamSInh";
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.HeaderText = "Quyền hạn";
            QuyenHan.MinimumWidth = 6;
            QuyenHan.Name = "QuyenHan";
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên Đăng Nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1411, 557);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtNamSinh;
        private TextBox txtDiaChi;
        private TextBox txtHoVaTen;
        private Label label4;
        private TextBox txtDienThoai;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label5;
        private ComboBox cboQuyenHan;
        private TextBox txtTenDangNhap;
        private Label label6;
        private TextBox txtMatKhau;
        private Label label7;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn NamSInh;
        private DataGridViewTextBoxColumn QuyenHan;
        private DataGridViewTextBoxColumn TenDangNhap;
    }
}