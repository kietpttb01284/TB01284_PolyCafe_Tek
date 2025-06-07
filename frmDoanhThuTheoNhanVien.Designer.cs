namespace TB01284_PolyCafe
{
    partial class frmDoanhThuTheoNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.DataDoanhThuNhanVien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TPDenNgay = new System.Windows.Forms.DateTimePicker();
            this.TPTuNgay = new System.Windows.Forms.DateTimePicker();
            this.butThongKe = new System.Windows.Forms.Button();
            this.CBNhanVien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataDoanhThuNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(362, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Doanh Thu Theo Nhân Viên";
            // 
            // DataDoanhThuNhanVien
            // 
            this.DataDoanhThuNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDoanhThuNhanVien.Location = new System.Drawing.Point(6, 144);
            this.DataDoanhThuNhanVien.Name = "DataDoanhThuNhanVien";
            this.DataDoanhThuNhanVien.RowHeadersWidth = 51;
            this.DataDoanhThuNhanVien.RowTemplate.Height = 24;
            this.DataDoanhThuNhanVien.Size = new System.Drawing.Size(1231, 459);
            this.DataDoanhThuNhanVien.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(715, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Đến ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Từ ngày";
            // 
            // TPDenNgay
            // 
            this.TPDenNgay.Location = new System.Drawing.Point(822, 96);
            this.TPDenNgay.Name = "TPDenNgay";
            this.TPDenNgay.Size = new System.Drawing.Size(207, 22);
            this.TPDenNgay.TabIndex = 17;
            // 
            // TPTuNgay
            // 
            this.TPTuNgay.Location = new System.Drawing.Point(469, 96);
            this.TPTuNgay.Name = "TPTuNgay";
            this.TPTuNgay.Size = new System.Drawing.Size(207, 22);
            this.TPTuNgay.TabIndex = 18;
            // 
            // butThongKe
            // 
            this.butThongKe.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.butThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butThongKe.Location = new System.Drawing.Point(1086, 84);
            this.butThongKe.Name = "butThongKe";
            this.butThongKe.Size = new System.Drawing.Size(141, 45);
            this.butThongKe.TabIndex = 21;
            this.butThongKe.Text = "Thống kê";
            this.butThongKe.UseVisualStyleBackColor = false;
            this.butThongKe.Click += new System.EventHandler(this.butThongKe_Click);
            // 
            // CBNhanVien
            // 
            this.CBNhanVien.FormattingEnabled = true;
            this.CBNhanVien.Location = new System.Drawing.Point(132, 96);
            this.CBNhanVien.Name = "CBNhanVien";
            this.CBNhanVien.Size = new System.Drawing.Size(209, 24);
            this.CBNhanVien.TabIndex = 22;
            // 
            // frmDoanhThuTheoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1243, 607);
            this.Controls.Add(this.CBNhanVien);
            this.Controls.Add(this.butThongKe);
            this.Controls.Add(this.TPTuNgay);
            this.Controls.Add(this.TPDenNgay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataDoanhThuNhanVien);
            this.Controls.Add(this.label1);
            this.Name = "frmDoanhThuTheoNhanVien";
            this.Text = "frmDoanhThuTheoNhanVien";
            this.Load += new System.EventHandler(this.frmDoanhThuTheoNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataDoanhThuNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataDoanhThuNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TPDenNgay;
        private System.Windows.Forms.DateTimePicker TPTuNgay;
        private System.Windows.Forms.Button butThongKe;
        private System.Windows.Forms.ComboBox CBNhanVien;
    }
}