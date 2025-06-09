namespace TB01284_PolyCafe
{
    partial class frmSanPham
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.butChonAnh = new System.Windows.Forms.Button();
            this.PicSanPham = new System.Windows.Forms.PictureBox();
            this.butXoa = new System.Windows.Forms.Button();
            this.butTimKiem = new System.Windows.Forms.Button();
            this.butLamMoi = new System.Windows.Forms.Button();
            this.butSua = new System.Windows.Forms.Button();
            this.butThem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.MaskedTextBox();
            this.rbutNgungBan = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rbutConBan = new System.Windows.Forms.RadioButton();
            this.CBLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.DataSanPham = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PicSanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // butChonAnh
            // 
            this.butChonAnh.Location = new System.Drawing.Point(91, 541);
            this.butChonAnh.Name = "butChonAnh";
            this.butChonAnh.Size = new System.Drawing.Size(114, 33);
            this.butChonAnh.TabIndex = 38;
            this.butChonAnh.Text = "Chọn ảnh";
            this.butChonAnh.UseVisualStyleBackColor = true;
            this.butChonAnh.Click += new System.EventHandler(this.butChonAnh_Click_1);
            // 
            // PicSanPham
            // 
            this.PicSanPham.Image = ((System.Drawing.Image)(resources.GetObject("PicSanPham.Image")));
            this.PicSanPham.Location = new System.Drawing.Point(32, 374);
            this.PicSanPham.Name = "PicSanPham";
            this.PicSanPham.Size = new System.Drawing.Size(218, 161);
            this.PicSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSanPham.TabIndex = 37;
            this.PicSanPham.TabStop = false;
            // 
            // butXoa
            // 
            this.butXoa.Location = new System.Drawing.Point(278, 425);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(156, 40);
            this.butXoa.TabIndex = 36;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = true;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click_1);
            // 
            // butTimKiem
            // 
            this.butTimKiem.Location = new System.Drawing.Point(830, 31);
            this.butTimKiem.Name = "butTimKiem";
            this.butTimKiem.Size = new System.Drawing.Size(99, 35);
            this.butTimKiem.TabIndex = 35;
            this.butTimKiem.Text = "Tìm kiếm";
            this.butTimKiem.UseVisualStyleBackColor = true;
            this.butTimKiem.Click += new System.EventHandler(this.butTimKiem_Click);
            // 
            // butLamMoi
            // 
            this.butLamMoi.Location = new System.Drawing.Point(278, 527);
            this.butLamMoi.Name = "butLamMoi";
            this.butLamMoi.Size = new System.Drawing.Size(156, 40);
            this.butLamMoi.TabIndex = 34;
            this.butLamMoi.Text = "Làm mới";
            this.butLamMoi.UseVisualStyleBackColor = true;
            this.butLamMoi.Click += new System.EventHandler(this.butLamMoi_Click_1);
            // 
            // butSua
            // 
            this.butSua.Location = new System.Drawing.Point(278, 477);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(156, 40);
            this.butSua.TabIndex = 33;
            this.butSua.Text = "Sửa";
            this.butSua.UseVisualStyleBackColor = true;
            this.butSua.Click += new System.EventHandler(this.butSua_Click_1);
            // 
            // butThem
            // 
            this.butThem.Location = new System.Drawing.Point(278, 374);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(156, 40);
            this.butThem.TabIndex = 32;
            this.butThem.Text = "Thêm";
            this.butThem.UseVisualStyleBackColor = true;
            this.butThem.Click += new System.EventHandler(this.butThem_Click_1);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(935, 37);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(271, 22);
            this.txtTimKiem.TabIndex = 30;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Sienna;
            this.label10.Location = new System.Drawing.Point(369, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 32);
            this.label10.TabIndex = 31;
            this.label10.Text = "Sản phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.rbutNgungBan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rbutConBan);
            this.groupBox1.Controls.Add(this.CBLoaiSanPham);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenSanPham);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaSanPham);
            this.groupBox1.Location = new System.Drawing.Point(11, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 250);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu bán hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(174, 124);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(249, 22);
            this.txtDonGia.TabIndex = 27;
            // 
            // rbutNgungBan
            // 
            this.rbutNgungBan.AutoSize = true;
            this.rbutNgungBan.Location = new System.Drawing.Point(294, 213);
            this.rbutNgungBan.Name = "rbutNgungBan";
            this.rbutNgungBan.Size = new System.Drawing.Size(94, 20);
            this.rbutNgungBan.TabIndex = 12;
            this.rbutNgungBan.TabStop = true;
            this.rbutNgungBan.Text = "Ngừng bán";
            this.rbutNgungBan.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tên loại:";
            // 
            // rbutConBan
            // 
            this.rbutConBan.AutoSize = true;
            this.rbutConBan.Location = new System.Drawing.Point(174, 213);
            this.rbutConBan.Name = "rbutConBan";
            this.rbutConBan.Size = new System.Drawing.Size(78, 20);
            this.rbutConBan.TabIndex = 10;
            this.rbutConBan.TabStop = true;
            this.rbutConBan.Text = "Còn bán";
            this.rbutConBan.UseVisualStyleBackColor = true;
            // 
            // CBLoaiSanPham
            // 
            this.CBLoaiSanPham.FormattingEnabled = true;
            this.CBLoaiSanPham.Location = new System.Drawing.Point(174, 171);
            this.CBLoaiSanPham.Name = "CBLoaiSanPham";
            this.CBLoaiSanPham.Size = new System.Drawing.Size(249, 24);
            this.CBLoaiSanPham.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Loại sản phẩm:";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(174, 76);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(249, 22);
            this.txtTenSanPham.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(174, 32);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(249, 22);
            this.txtMaSanPham.TabIndex = 1;
            // 
            // DataSanPham
            // 
            this.DataSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSanPham.Location = new System.Drawing.Point(480, 90);
            this.DataSanPham.Name = "DataSanPham";
            this.DataSanPham.RowHeadersWidth = 51;
            this.DataSanPham.RowTemplate.Height = 24;
            this.DataSanPham.Size = new System.Drawing.Size(751, 484);
            this.DataSanPham.TabIndex = 28;
            this.DataSanPham.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataSanPham_CellDoubleClick_1);
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1243, 605);
            this.Controls.Add(this.butChonAnh);
            this.Controls.Add(this.PicSanPham);
            this.Controls.Add(this.butXoa);
            this.Controls.Add(this.butTimKiem);
            this.Controls.Add(this.butLamMoi);
            this.Controls.Add(this.butSua);
            this.Controls.Add(this.butThem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataSanPham);
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicSanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button butChonAnh;
        private System.Windows.Forms.PictureBox PicSanPham;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.Button butTimKiem;
        private System.Windows.Forms.Button butLamMoi;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtDonGia;
        private System.Windows.Forms.RadioButton rbutNgungBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbutConBan;
        private System.Windows.Forms.ComboBox CBLoaiSanPham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.DataGridView DataSanPham;
        private System.Windows.Forms.Label label1;
    }
}