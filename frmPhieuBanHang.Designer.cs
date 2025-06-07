namespace TB01284_PolyCafe
{
    partial class frmPhieuBanHang
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
            this.butXoa = new System.Windows.Forms.Button();
            this.butTimKiem = new System.Windows.Forms.Button();
            this.butLamMoi = new System.Windows.Forms.Button();
            this.butSua = new System.Windows.Forms.Button();
            this.butThem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBMaThe = new System.Windows.Forms.ComboBox();
            this.CBNhanVien = new System.Windows.Forms.ComboBox();
            this.TPNgayTao = new System.Windows.Forms.DateTimePicker();
            this.rbutChoXacNhan = new System.Windows.Forms.RadioButton();
            this.rbutDaThanhToan = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.DataPhieuBanHang = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPhieuBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // butXoa
            // 
            this.butXoa.Location = new System.Drawing.Point(33, 517);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(156, 47);
            this.butXoa.TabIndex = 34;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = true;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butTimKiem
            // 
            this.butTimKiem.Location = new System.Drawing.Point(830, 33);
            this.butTimKiem.Name = "butTimKiem";
            this.butTimKiem.Size = new System.Drawing.Size(99, 35);
            this.butTimKiem.TabIndex = 33;
            this.butTimKiem.Text = "Tìm kiếm";
            this.butTimKiem.UseVisualStyleBackColor = true;
            // 
            // butLamMoi
            // 
            this.butLamMoi.Location = new System.Drawing.Point(249, 517);
            this.butLamMoi.Name = "butLamMoi";
            this.butLamMoi.Size = new System.Drawing.Size(156, 47);
            this.butLamMoi.TabIndex = 32;
            this.butLamMoi.Text = "Làm mới";
            this.butLamMoi.UseVisualStyleBackColor = true;
            this.butLamMoi.Click += new System.EventHandler(this.butLamMoi_Click);
            // 
            // butSua
            // 
            this.butSua.Location = new System.Drawing.Point(249, 450);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(156, 47);
            this.butSua.TabIndex = 31;
            this.butSua.Text = "Sửa";
            this.butSua.UseVisualStyleBackColor = true;
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butThem
            // 
            this.butThem.Location = new System.Drawing.Point(33, 450);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(156, 47);
            this.butThem.TabIndex = 30;
            this.butThem.Text = "Thêm";
            this.butThem.UseVisualStyleBackColor = true;
            this.butThem.Click += new System.EventHandler(this.butThem_Click_1);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(935, 39);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(271, 22);
            this.txtTimKiem.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Sienna;
            this.label10.Location = new System.Drawing.Point(329, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 32);
            this.label10.TabIndex = 29;
            this.label10.Text = "Phiếu bán hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBMaThe);
            this.groupBox1.Controls.Add(this.CBNhanVien);
            this.groupBox1.Controls.Add(this.TPNgayTao);
            this.groupBox1.Controls.Add(this.rbutChoXacNhan);
            this.groupBox1.Controls.Add(this.rbutDaThanhToan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaKhachHang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaPhieu);
            this.groupBox1.Location = new System.Drawing.Point(11, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 339);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu bán hàng";
            // 
            // CBMaThe
            // 
            this.CBMaThe.FormattingEnabled = true;
            this.CBMaThe.Location = new System.Drawing.Point(174, 86);
            this.CBMaThe.Name = "CBMaThe";
            this.CBMaThe.Size = new System.Drawing.Size(249, 24);
            this.CBMaThe.TabIndex = 15;
            // 
            // CBNhanVien
            // 
            this.CBNhanVien.FormattingEnabled = true;
            this.CBNhanVien.Location = new System.Drawing.Point(174, 142);
            this.CBNhanVien.Name = "CBNhanVien";
            this.CBNhanVien.Size = new System.Drawing.Size(249, 24);
            this.CBNhanVien.TabIndex = 14;
            // 
            // TPNgayTao
            // 
            this.TPNgayTao.Location = new System.Drawing.Point(174, 292);
            this.TPNgayTao.Name = "TPNgayTao";
            this.TPNgayTao.Size = new System.Drawing.Size(249, 22);
            this.TPNgayTao.TabIndex = 13;
            // 
            // rbutChoXacNhan
            // 
            this.rbutChoXacNhan.AutoSize = true;
            this.rbutChoXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbutChoXacNhan.Location = new System.Drawing.Point(174, 247);
            this.rbutChoXacNhan.Name = "rbutChoXacNhan";
            this.rbutChoXacNhan.Size = new System.Drawing.Size(120, 22);
            this.rbutChoXacNhan.TabIndex = 12;
            this.rbutChoXacNhan.TabStop = true;
            this.rbutChoXacNhan.Text = "Chờ xác nhận";
            this.rbutChoXacNhan.UseVisualStyleBackColor = true;
            // 
            // rbutDaThanhToan
            // 
            this.rbutDaThanhToan.AutoSize = true;
            this.rbutDaThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbutDaThanhToan.Location = new System.Drawing.Point(302, 247);
            this.rbutDaThanhToan.Name = "rbutDaThanhToan";
            this.rbutDaThanhToan.Size = new System.Drawing.Size(121, 22);
            this.rbutDaThanhToan.TabIndex = 11;
            this.rbutDaThanhToan.TabStop = true;
            this.rbutDaThanhToan.Text = "Đã thanh toán";
            this.rbutDaThanhToan.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày tạo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Trạng thái:";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(172, 193);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(251, 22);
            this.txtMaKhachHang.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã thẻ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phiếu:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(174, 37);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(249, 22);
            this.txtMaPhieu.TabIndex = 1;
            // 
            // DataPhieuBanHang
            // 
            this.DataPhieuBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPhieuBanHang.Location = new System.Drawing.Point(480, 92);
            this.DataPhieuBanHang.Name = "DataPhieuBanHang";
            this.DataPhieuBanHang.RowHeadersWidth = 51;
            this.DataPhieuBanHang.RowTemplate.Height = 24;
            this.DataPhieuBanHang.Size = new System.Drawing.Size(751, 484);
            this.DataPhieuBanHang.TabIndex = 26;
            this.DataPhieuBanHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPhieuBanHang_CellClick);
            this.DataPhieuBanHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPhieuBanHang_CellDoubleClick);
            // 
            // frmPhieuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1243, 605);
            this.Controls.Add(this.butXoa);
            this.Controls.Add(this.butTimKiem);
            this.Controls.Add(this.butLamMoi);
            this.Controls.Add(this.butSua);
            this.Controls.Add(this.butThem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataPhieuBanHang);
            this.Name = "frmPhieuBanHang";
            this.Text = "frmPhieuBanHang";
            this.Load += new System.EventHandler(this.frmPhieuBanHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPhieuBanHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.Button butTimKiem;
        private System.Windows.Forms.Button butLamMoi;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBMaThe;
        private System.Windows.Forms.ComboBox CBNhanVien;
        private System.Windows.Forms.DateTimePicker TPNgayTao;
        private System.Windows.Forms.RadioButton rbutChoXacNhan;
        private System.Windows.Forms.RadioButton rbutDaThanhToan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.DataGridView DataPhieuBanHang;
    }
}