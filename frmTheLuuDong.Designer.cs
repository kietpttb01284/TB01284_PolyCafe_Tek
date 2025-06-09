namespace TB01284_PolyCafe
{
    partial class frmTheLuuDong
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DataTheLuuDong = new System.Windows.Forms.DataGridView();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbutNgung = new System.Windows.Forms.RadioButton();
            this.rbutHoatDong = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenNguoiSoHuu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.butThem = new System.Windows.Forms.Button();
            this.butSua = new System.Windows.Forms.Button();
            this.butLamMoi = new System.Windows.Forms.Button();
            this.butXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTheLuuDong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTheLuuDong
            // 
            this.DataTheLuuDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTheLuuDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTheLuuDong.ColumnHeadersHeight = 29;
            this.DataTheLuuDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataTheLuuDong.Location = new System.Drawing.Point(496, 104);
            this.DataTheLuuDong.Name = "DataTheLuuDong";
            this.DataTheLuuDong.RowHeadersWidth = 51;
            this.DataTheLuuDong.RowTemplate.Height = 24;
            this.DataTheLuuDong.Size = new System.Drawing.Size(735, 491);
            this.DataTheLuuDong.TabIndex = 0;
            this.DataTheLuuDong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTheLuuDong_CellContentClick);
            this.DataTheLuuDong.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtMaThe
            // 
            this.txtMaThe.Location = new System.Drawing.Point(174, 27);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(220, 22);
            this.txtMaThe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(286, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lí Thẻ lưu động";
            // 
            // butTimKiem
            // 
            this.butTimKiem.Location = new System.Drawing.Point(803, 30);
            this.butTimKiem.Name = "butTimKiem";
            this.butTimKiem.Size = new System.Drawing.Size(106, 40);
            this.butTimKiem.TabIndex = 3;
            this.butTimKiem.Text = "Tìm kiếm";
            this.butTimKiem.UseVisualStyleBackColor = true;
            this.butTimKiem.Click += new System.EventHandler(this.butTimKiem_Click);
            this.butTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.butTimKiem_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbutNgung);
            this.groupBox1.Controls.Add(this.rbutHoatDong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenNguoiSoHuu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaThe);
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 204);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Thẻ lưu động";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbutNgung
            // 
            this.rbutNgung.AutoSize = true;
            this.rbutNgung.Location = new System.Drawing.Point(290, 129);
            this.rbutNgung.Name = "rbutNgung";
            this.rbutNgung.Size = new System.Drawing.Size(68, 20);
            this.rbutNgung.TabIndex = 12;
            this.rbutNgung.TabStop = true;
            this.rbutNgung.Text = "Ngưng";
            this.rbutNgung.UseVisualStyleBackColor = true;
            // 
            // rbutHoatDong
            // 
            this.rbutHoatDong.AutoSize = true;
            this.rbutHoatDong.Location = new System.Drawing.Point(174, 127);
            this.rbutHoatDong.Name = "rbutHoatDong";
            this.rbutHoatDong.Size = new System.Drawing.Size(91, 20);
            this.rbutHoatDong.TabIndex = 11;
            this.rbutHoatDong.TabStop = true;
            this.rbutHoatDong.Text = "Hoạt động";
            this.rbutHoatDong.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trạng thái";
            // 
            // txtTenNguoiSoHuu
            // 
            this.txtTenNguoiSoHuu.Location = new System.Drawing.Point(174, 80);
            this.txtTenNguoiSoHuu.Name = "txtTenNguoiSoHuu";
            this.txtTenNguoiSoHuu.Size = new System.Drawing.Size(220, 22);
            this.txtTenNguoiSoHuu.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên người sở hữu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã thẻ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(941, 39);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(277, 22);
            this.txtTimKiem.TabIndex = 6;
            // 
            // butThem
            // 
            this.butThem.Location = new System.Drawing.Point(56, 414);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(150, 53);
            this.butThem.TabIndex = 7;
            this.butThem.Text = "Thêm";
            this.butThem.UseVisualStyleBackColor = true;
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // butSua
            // 
            this.butSua.Location = new System.Drawing.Point(292, 414);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(150, 53);
            this.butSua.TabIndex = 8;
            this.butSua.Text = "Sửa";
            this.butSua.UseVisualStyleBackColor = true;
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butLamMoi
            // 
            this.butLamMoi.Location = new System.Drawing.Point(292, 491);
            this.butLamMoi.Name = "butLamMoi";
            this.butLamMoi.Size = new System.Drawing.Size(150, 53);
            this.butLamMoi.TabIndex = 9;
            this.butLamMoi.Text = "Làm mới";
            this.butLamMoi.UseVisualStyleBackColor = true;
            this.butLamMoi.Click += new System.EventHandler(this.butLamMoi_Click);
            // 
            // butXoa
            // 
            this.butXoa.Location = new System.Drawing.Point(56, 491);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(150, 53);
            this.butXoa.TabIndex = 10;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = true;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // frmTheLuuDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1243, 607);
            this.Controls.Add(this.butXoa);
            this.Controls.Add(this.butLamMoi);
            this.Controls.Add(this.butSua);
            this.Controls.Add(this.butThem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butTimKiem);
            this.Controls.Add(this.DataTheLuuDong);
            this.Controls.Add(this.label1);
            this.Name = "frmTheLuuDong";
            this.Text = "frmTheLuuDong";
            ((System.ComponentModel.ISupportInitialize)(this.DataTheLuuDong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView DataTheLuuDong;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenNguoiSoHuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbutNgung;
        private System.Windows.Forms.RadioButton rbutHoatDong;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.Button butLamMoi;
        private System.Windows.Forms.Button butXoa;
    }
}