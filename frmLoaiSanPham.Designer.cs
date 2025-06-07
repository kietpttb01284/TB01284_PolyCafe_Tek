namespace TB01284_PolyCafe
{
    partial class frmLoaiSanPham
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
            this.butTimKiem2 = new System.Windows.Forms.Button();
            this.butLamMoi = new System.Windows.Forms.Button();
            this.butSua = new System.Windows.Forms.Button();
            this.butThem = new System.Windows.Forms.Button();
            this.txtTimKiem2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DataLoaiSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataLoaiSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // butXoa
            // 
            this.butXoa.Location = new System.Drawing.Point(41, 423);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(136, 38);
            this.butXoa.TabIndex = 43;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = true;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butTimKiem2
            // 
            this.butTimKiem2.Location = new System.Drawing.Point(825, 32);
            this.butTimKiem2.Name = "butTimKiem2";
            this.butTimKiem2.Size = new System.Drawing.Size(99, 35);
            this.butTimKiem2.TabIndex = 42;
            this.butTimKiem2.Text = "Tìm kiếm";
            this.butTimKiem2.UseVisualStyleBackColor = true;
            // 
            // butLamMoi
            // 
            this.butLamMoi.Location = new System.Drawing.Point(292, 423);
            this.butLamMoi.Name = "butLamMoi";
            this.butLamMoi.Size = new System.Drawing.Size(136, 38);
            this.butLamMoi.TabIndex = 41;
            this.butLamMoi.Text = "Làm mới";
            this.butLamMoi.UseVisualStyleBackColor = true;
            this.butLamMoi.Click += new System.EventHandler(this.butLamMoi_Click);
            // 
            // butSua
            // 
            this.butSua.Location = new System.Drawing.Point(292, 356);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(136, 38);
            this.butSua.TabIndex = 40;
            this.butSua.Text = "Sửa";
            this.butSua.UseVisualStyleBackColor = true;
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butThem
            // 
            this.butThem.Location = new System.Drawing.Point(41, 356);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(136, 38);
            this.butThem.TabIndex = 39;
            this.butThem.Text = "Thêm";
            this.butThem.UseVisualStyleBackColor = true;
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // txtTimKiem2
            // 
            this.txtTimKiem2.Location = new System.Drawing.Point(930, 38);
            this.txtTimKiem2.Name = "txtTimKiem2";
            this.txtTimKiem2.Size = new System.Drawing.Size(271, 22);
            this.txtTimKiem2.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(343, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 32);
            this.label7.TabIndex = 38;
            this.label7.Text = "Loại sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaLoai);
            this.groupBox2.Controls.Add(this.txtTenLoai);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(16, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 173);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu bán hàng";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(174, 33);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(251, 22);
            this.txtMaLoai.TabIndex = 9;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(174, 86);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(251, 22);
            this.txtTenLoai.TabIndex = 8;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(174, 136);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(251, 22);
            this.txtGhiChu.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Ghi chú:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Tên loại:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Mã loại:";
            // 
            // DataLoaiSanPham
            // 
            this.DataLoaiSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataLoaiSanPham.Location = new System.Drawing.Point(475, 91);
            this.DataLoaiSanPham.Name = "DataLoaiSanPham";
            this.DataLoaiSanPham.RowHeadersWidth = 51;
            this.DataLoaiSanPham.RowTemplate.Height = 24;
            this.DataLoaiSanPham.Size = new System.Drawing.Size(751, 484);
            this.DataLoaiSanPham.TabIndex = 35;
            this.DataLoaiSanPham.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataLoaiSanPham_CellDoubleClick);
            this.DataLoaiSanPham.Resize += new System.EventHandler(this.DataLoaiSanPham_Resize);
            // 
            // frmLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1243, 607);
            this.Controls.Add(this.butXoa);
            this.Controls.Add(this.butTimKiem2);
            this.Controls.Add(this.butLamMoi);
            this.Controls.Add(this.butSua);
            this.Controls.Add(this.butThem);
            this.Controls.Add(this.txtTimKiem2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DataLoaiSanPham);
            this.Name = "frmLoaiSanPham";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLoaiSanPham_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataLoaiSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.Button butTimKiem2;
        private System.Windows.Forms.Button butLamMoi;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.TextBox txtTimKiem2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView DataLoaiSanPham;
    }
}