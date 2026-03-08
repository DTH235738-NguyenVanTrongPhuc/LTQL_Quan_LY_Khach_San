namespace Quan_Ly_Khach_san.form
{
    partial class frmMain
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
            panel1 = new Panel();
            label1 = new Label();
            picname = new PictureBox();
            panelMenu = new Panel();
            lbkhachhang = new Label();
            pictureBox7 = new PictureBox();
            pictureBox5 = new PictureBox();
            lbsetting = new Label();
            pictureBox4 = new PictureBox();
            lbdash = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            lbdatphong = new Label();
            lbphong = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            flpl = new FlowLayoutPanel();
            txttimkiem = new TextBox();
            cbtimkiem = new ComboBox();
            lbflex = new Label();
            panel3 = new Panel();
            lbthongke = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picname).BeginInit();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Ivory;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(picname);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1383, 50);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(84, 12);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 7;
            label1.Text = "Dashboard";
            // 
            // picname
            // 
            picname.BackColor = SystemColors.ControlDarkDark;
            picname.Location = new Point(45, 7);
            picname.Name = "picname";
            picname.Size = new Size(33, 36);
            picname.SizeMode = PictureBoxSizeMode.Zoom;
            picname.TabIndex = 1;
            picname.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Transparent;
            panelMenu.Controls.Add(lbkhachhang);
            panelMenu.Controls.Add(pictureBox7);
            panelMenu.Controls.Add(pictureBox5);
            panelMenu.Controls.Add(lbsetting);
            panelMenu.Controls.Add(pictureBox4);
            panelMenu.Controls.Add(lbdash);
            panelMenu.Controls.Add(pictureBox3);
            panelMenu.Controls.Add(pictureBox2);
            panelMenu.Controls.Add(label2);
            panelMenu.Controls.Add(lbdatphong);
            panelMenu.Controls.Add(lbphong);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Location = new Point(0, 46);
            panelMenu.MinimumSize = new Size(200, 200);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 539);
            panelMenu.TabIndex = 1;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // lbkhachhang
            // 
            lbkhachhang.AutoSize = true;
            lbkhachhang.Location = new Point(64, 207);
            lbkhachhang.Name = "lbkhachhang";
            lbkhachhang.Size = new Size(84, 20);
            lbkhachhang.TabIndex = 11;
            lbkhachhang.Text = "khach hang";
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(25, 256);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(33, 20);
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(25, 207);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 20);
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // lbsetting
            // 
            lbsetting.AutoSize = true;
            lbsetting.Location = new Point(64, 256);
            lbsetting.Name = "lbsetting";
            lbsetting.Size = new Size(56, 20);
            lbsetting.TabIndex = 8;
            lbsetting.Text = "Cai dat";
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(25, 158);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 20);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // lbdash
            // 
            lbdash.AutoSize = true;
            lbdash.Location = new Point(64, 11);
            lbdash.Name = "lbdash";
            lbdash.Size = new Size(82, 20);
            lbdash.TabIndex = 6;
            lbdash.Text = "Dashboard";
            lbdash.Click += lbdash_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(25, 109);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 20);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(25, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 20);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 109);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 3;
            label2.Text = "Quan Ly Dich Vu";
            // 
            // lbdatphong
            // 
            lbdatphong.AutoSize = true;
            lbdatphong.Location = new Point(64, 60);
            lbdatphong.Name = "lbdatphong";
            lbdatphong.Size = new Size(79, 20);
            lbdatphong.TabIndex = 2;
            lbdatphong.Text = "Dat Phong";
            // 
            // lbphong
            // 
            lbphong.AutoSize = true;
            lbphong.Location = new Point(64, 158);
            lbphong.Name = "lbphong";
            lbphong.Size = new Size(51, 20);
            lbphong.TabIndex = 1;
            lbphong.Text = "Phong";
            lbphong.Click += lbphong_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(25, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 20);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(flpl);
            panel2.Location = new Point(206, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(1177, 487);
            panel2.TabIndex = 5;
            // 
            // flpl
            // 
            flpl.AutoScroll = true;
            flpl.Location = new Point(0, 26);
            flpl.Name = "flpl";
            flpl.Size = new Size(1177, 461);
            flpl.TabIndex = 0;
            // 
            // txttimkiem
            // 
            txttimkiem.ForeColor = SystemColors.GrayText;
            txttimkiem.Location = new Point(779, 3);
            txttimkiem.Multiline = true;
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(208, 28);
            txttimkiem.TabIndex = 6;
            txttimkiem.Text = "Tim Kiem Phong";
            // 
            // cbtimkiem
            // 
            cbtimkiem.FormattingEnabled = true;
            cbtimkiem.Location = new Point(993, 3);
            cbtimkiem.Name = "cbtimkiem";
            cbtimkiem.Size = new Size(169, 28);
            cbtimkiem.TabIndex = 0;
            // 
            // lbflex
            // 
            lbflex.AutoSize = true;
            lbflex.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbflex.Location = new Point(3, 4);
            lbflex.Name = "lbflex";
            lbflex.Size = new Size(40, 23);
            lbflex.TabIndex = 7;
            lbflex.Text = "flex";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(lbthongke);
            panel3.Controls.Add(lbflex);
            panel3.Controls.Add(cbtimkiem);
            panel3.Controls.Add(txttimkiem);
            panel3.Location = new Point(206, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(1177, 80);
            panel3.TabIndex = 8;
            // 
            // lbthongke
            // 
            lbthongke.AutoSize = true;
            lbthongke.Location = new Point(349, 11);
            lbthongke.Name = "lbthongke";
            lbthongke.Size = new Size(70, 20);
            lbthongke.TabIndex = 7;
            lbthongke.Text = "Thong ke";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1383, 597);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelMenu);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "frmMain";
            Text = "Quản Lý Khách Sạn";
            Load += frmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picname).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panelMenu;
        private Label lbphong;
        private PictureBox pictureBox1;
        private Panel panel2;
        private FlowLayoutPanel flpl;
        private Label label2;
        private Label lbdatphong;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox txttimkiem;
        private ComboBox cbtimkiem;
        private Label lbflex;
        private Panel panel3;
        private PictureBox pictureBox4;
        private Label lbdash;
        private PictureBox pictureBox5;
        private Label lbsetting;
        private Label label1;
        private PictureBox picname;
        private Label lbthongke;
        private PictureBox pictureBox7;
        private Label lbkhachhang;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}