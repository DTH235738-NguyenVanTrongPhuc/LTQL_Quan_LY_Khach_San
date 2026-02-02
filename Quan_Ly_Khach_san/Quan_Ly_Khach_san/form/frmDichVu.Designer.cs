namespace Quan_Ly_Khach_san.form
{
    partial class frmDichVu
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
            groupBox1 = new GroupBox();
            txtMoTa = new TextBox();
            label6 = new Label();
            cboTrangThai = new ComboBox();
            label5 = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtDonGia = new TextBox();
            txtTenDichVu = new TextBox();
            label1 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            TenDichVu = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cboTrangThai);
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
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(txtTenDichVu);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1232, 158);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Dịch vụ";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(136, 89);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(340, 27);
            txtMoTa.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 96);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 15;
            label6.Text = "Mô Tả";
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Admin", "Nhan Vien" });
            cboTrangThai.Location = new Point(616, 34);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(163, 28);
            cboTrangThai.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(521, 39);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 13;
            label5.Text = "Trạng Thái";
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
            // txtDonGia
            // 
            txtDonGia.Location = new Point(616, 81);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(163, 27);
            txtDonGia.TabIndex = 5;
            // 
            // txtTenDichVu
            // 
            txtTenDichVu.Location = new Point(136, 39);
            txtTenDichVu.Name = "txtTenDichVu";
            txtTenDichVu.Size = new Size(274, 27);
            txtTenDichVu.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 42);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Dịch Vụ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(521, 84);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Đơn Giá";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1361, 356);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách dịch vụ";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { TenDichVu, DonGia, TrangThai, MoTa });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1355, 330);
            dataGridView.TabIndex = 4;
            // 
            // TenDichVu
            // 
            TenDichVu.DataPropertyName = "TenDichVu";
            TenDichVu.HeaderText = "Tên Dịch Vụ";
            TenDichVu.MinimumWidth = 6;
            TenDichVu.Name = "TenDichVu";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn Giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng Thái ";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            // 
            // MoTa
            // 
            MoTa.DataPropertyName = "MoTa";
            MoTa.HeaderText = "Mô Tả";
            MoTa.MinimumWidth = 6;
            MoTa.Name = "MoTa";
            // 
            // frmDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 527);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmDichVu";
            Text = "frmDichVu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMoTa;
        private Label label6;
        private ComboBox cboTrangThai;
        private Label label5;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtDonGia;
        private TextBox txtTenDichVu;
        private Label label1;
        private Label label3;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn TenDichVu;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewTextBoxColumn MoTa;
    }
}