namespace TB01284_PolyCafe
{
    partial class frmDoanhThuTheoSanPham
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
            this.CBLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.butThongKe = new System.Windows.Forms.Button();
            this.TPTuNgay = new System.Windows.Forms.DateTimePicker();
            this.TPDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataDoanhThuSanPham = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataDoanhThuSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // CBLoaiSanPham
            // 
            this.CBLoaiSanPham.FormattingEnabled = true;
            this.CBLoaiSanPham.Location = new System.Drawing.Point(165, 77);
            this.CBLoaiSanPham.Name = "CBLoaiSanPham";
            this.CBLoaiSanPham.Size = new System.Drawing.Size(209, 24);
            this.CBLoaiSanPham.TabIndex = 31;
            // 
            // butThongKe
            // 
            this.butThongKe.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.butThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butThongKe.Location = new System.Drawing.Point(1086, 65);
            this.butThongKe.Name = "butThongKe";
            this.butThongKe.Size = new System.Drawing.Size(141, 45);
            this.butThongKe.TabIndex = 30;
            this.butThongKe.Text = "Thống kê";
            this.butThongKe.UseVisualStyleBackColor = false;
            this.butThongKe.Click += new System.EventHandler(this.butThongKe_Click);
            // 
            // TPTuNgay
            // 
            this.TPTuNgay.Location = new System.Drawing.Point(498, 77);
            this.TPTuNgay.Name = "TPTuNgay";
            this.TPTuNgay.Size = new System.Drawing.Size(207, 22);
            this.TPTuNgay.TabIndex = 29;
            // 
            // TPDenNgay
            // 
            this.TPDenNgay.Location = new System.Drawing.Point(851, 77);
            this.TPDenNgay.Name = "TPDenNgay";
            this.TPDenNgay.Size = new System.Drawing.Size(207, 22);
            this.TPDenNgay.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(744, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Đến ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Loại sản phẩm:";
            // 
            // DataDoanhThuSanPham
            // 
            this.DataDoanhThuSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataDoanhThuSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDoanhThuSanPham.Location = new System.Drawing.Point(6, 119);
            this.DataDoanhThuSanPham.Name = "DataDoanhThuSanPham";
            this.DataDoanhThuSanPham.RowHeadersWidth = 51;
            this.DataDoanhThuSanPham.RowTemplate.Height = 24;
            this.DataDoanhThuSanPham.Size = new System.Drawing.Size(1230, 509);
            this.DataDoanhThuSanPham.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(362, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 42);
            this.label1.TabIndex = 23;
            this.label1.Text = "Doanh Thu Theo Sản Phẩm";
            // 
            // frmDoanhThuTheoSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1243, 633);
            this.Controls.Add(this.CBLoaiSanPham);
            this.Controls.Add(this.butThongKe);
            this.Controls.Add(this.TPTuNgay);
            this.Controls.Add(this.TPDenNgay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataDoanhThuSanPham);
            this.Controls.Add(this.label1);
            this.Name = "frmDoanhThuTheoSanPham";
            this.Text = "frmDoanhThuTheoSanPham";
            this.Load += new System.EventHandler(this.frmDoanhThuTheoSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataDoanhThuSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBLoaiSanPham;
        private System.Windows.Forms.Button butThongKe;
        private System.Windows.Forms.DateTimePicker TPTuNgay;
        private System.Windows.Forms.DateTimePicker TPDenNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataDoanhThuSanPham;
        private System.Windows.Forms.Label label1;
    }
}