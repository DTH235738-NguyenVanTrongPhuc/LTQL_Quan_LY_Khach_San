namespace Quan_Ly_Khach_san.form
{
    partial class frmPhong
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
            label1 = new Label();
            txttenphong = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbTang = new ComboBox();
            cbLoaiPhong = new ComboBox();
            cbtrangthai = new ComboBox();
            label5 = new Label();
            txtghichu = new TextBox();
            txttimkiem = new TextBox();
            label7 = new Label();
            btntimkiem = new Button();
            btnthem = new Button();
            btnluu = new Button();
            btnxoa = new Button();
            btnSua = new Button();
            btnhuy = new Button();
            dataGridView1 = new DataGridView();
            phong = new DataGridViewTextBoxColumn();
            tang = new DataGridViewTextBoxColumn();
            loaiphong = new DataGridViewTextBoxColumn();
            ghichu = new DataGridViewTextBoxColumn();
            trangthai = new DataGridViewTextBoxColumn();
            btnthoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 74);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Phong";
            // 
            // txttenphong
            // 
            txttenphong.Location = new Point(103, 71);
            txttenphong.Name = "txttenphong";
            txttenphong.Size = new Size(99, 27);
            txttenphong.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 117);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 2;
            label2.Text = "Tầng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 161);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 3;
            label3.Text = "Loại Phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 207);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 4;
            label4.Text = "Trạng Thái";
            // 
            // cbTang
            // 
            cbTang.FormattingEnabled = true;
            cbTang.Location = new Point(103, 114);
            cbTang.Name = "cbTang";
            cbTang.Size = new Size(308, 28);
            cbTang.TabIndex = 5;
            // 
            // cbLoaiPhong
            // 
            cbLoaiPhong.FormattingEnabled = true;
            cbLoaiPhong.Location = new Point(103, 161);
            cbLoaiPhong.Name = "cbLoaiPhong";
            cbLoaiPhong.Size = new Size(308, 28);
            cbLoaiPhong.TabIndex = 6;
            // 
            // cbtrangthai
            // 
            cbtrangthai.FormattingEnabled = true;
            cbtrangthai.Location = new Point(103, 204);
            cbtrangthai.Name = "cbtrangthai";
            cbtrangthai.Size = new Size(308, 28);
            cbtrangthai.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 253);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 8;
            label5.Text = "Ghi chú";
            // 
            // txtghichu
            // 
            txtghichu.Location = new Point(103, 253);
            txtghichu.Multiline = true;
            txtghichu.Name = "txtghichu";
            txtghichu.Size = new Size(308, 121);
            txtghichu.TabIndex = 9;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(303, 70);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(108, 27);
            txttimkiem.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(417, 9);
            label7.Name = "label7";
            label7.Size = new Size(154, 28);
            label7.TabIndex = 13;
            label7.Text = "Quản Lý Phòng";
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(217, 69);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(80, 29);
            btntimkiem.TabIndex = 14;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(103, 409);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(80, 29);
            btnthem.TabIndex = 15;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // btnluu
            // 
            btnluu.Location = new Point(202, 460);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(80, 29);
            btnluu.TabIndex = 16;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = true;
            btnluu.Click += btnluu_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(103, 460);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(80, 29);
            btnxoa.TabIndex = 17;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(202, 409);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 29);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnhuy
            // 
            btnhuy.Location = new Point(303, 460);
            btnhuy.Name = "btnhuy";
            btnhuy.Size = new Size(80, 29);
            btnhuy.TabIndex = 19;
            btnhuy.Text = "Hủy";
            btnhuy.UseVisualStyleBackColor = true;
            btnhuy.Click += btnhuy_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { phong, tang, loaiphong, ghichu, trangthai });
            dataGridView1.Location = new Point(436, 74);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(821, 415);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // phong
            // 
            phong.DataPropertyName = "phong";
            phong.HeaderText = "Phòng";
            phong.MinimumWidth = 6;
            phong.Name = "phong";
            // 
            // tang
            // 
            tang.DataPropertyName = "tang";
            tang.HeaderText = "Tầng";
            tang.MinimumWidth = 6;
            tang.Name = "tang";
            // 
            // loaiphong
            // 
            loaiphong.DataPropertyName = "loaiphong";
            loaiphong.HeaderText = "LoaiPhong";
            loaiphong.MinimumWidth = 6;
            loaiphong.Name = "loaiphong";
            // 
            // ghichu
            // 
            ghichu.DataPropertyName = "ghichu";
            ghichu.HeaderText = "Ghi Chú";
            ghichu.MinimumWidth = 6;
            ghichu.Name = "ghichu";
            // 
            // trangthai
            // 
            trangthai.DataPropertyName = "trangthai";
            trangthai.HeaderText = "Trạng Thái";
            trangthai.MinimumWidth = 6;
            trangthai.Name = "trangthai";
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(303, 409);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(80, 29);
            btnthoat.TabIndex = 21;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // frmPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 557);
            Controls.Add(btnthoat);
            Controls.Add(dataGridView1);
            Controls.Add(btnhuy);
            Controls.Add(btnSua);
            Controls.Add(btnxoa);
            Controls.Add(btnluu);
            Controls.Add(btnthem);
            Controls.Add(btntimkiem);
            Controls.Add(label7);
            Controls.Add(txttimkiem);
            Controls.Add(txtghichu);
            Controls.Add(label5);
            Controls.Add(cbtrangthai);
            Controls.Add(cbLoaiPhong);
            Controls.Add(cbTang);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txttenphong);
            Controls.Add(label1);
            Name = "frmPhong";
            Text = "frmPhong";
            Load += frmPhong_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txttenphong;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbTang;
        private ComboBox cbLoaiPhong;
        private ComboBox cbtrangthai;
        private Label label5;
        private TextBox txtghichu;
        private TextBox txttimkiem;
        private Label label7;
        private Button btntimkiem;
        private Button btnthem;
        private Button btnluu;
        private Button btnxoa;
        private Button btnSua;
        private Button btnhuy;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn phong;
        private DataGridViewTextBoxColumn tang;
        private DataGridViewTextBoxColumn loaiphong;
        private DataGridViewTextBoxColumn ghichu;
        private DataGridViewTextBoxColumn trangthai;
        private Button btnthoat;
    }
}