using System.Windows.Forms;

namespace TB01284_PolyCafe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbutTrangThai2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbutQuanLi = new System.Windows.Forms.RadioButton();
            this.rbutNhanVien = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbutTrangThai1 = new System.Windows.Forms.RadioButton();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.DataNhanVien = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.butThem = new System.Windows.Forms.Button();
            this.butLamMoi = new System.Windows.Forms.Button();
            this.butXoa = new System.Windows.Forms.Button();
            this.butSua = new System.Windows.Forms.Button();
            this.butTimKiemnhanVien = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtXacNhanMatKhau);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbutTrangThai2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.rbutTrangThai1);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.txtMaNhanVien);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1226, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(770, 75);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(163, 22);
            this.txtXacNhanMatKhau.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(694, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Xác nhận";
            // 
            // rbutTrangThai2
            // 
            this.rbutTrangThai2.AutoSize = true;
            this.rbutTrangThai2.BackColor = System.Drawing.Color.Transparent;
            this.rbutTrangThai2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbutTrangThai2.Location = new System.Drawing.Point(586, 71);
            this.rbutTrangThai2.Name = "rbutTrangThai2";
            this.rbutTrangThai2.Size = new System.Drawing.Size(59, 22);
            this.rbutTrangThai2.TabIndex = 22;
            this.rbutTrangThai2.TabStop = true;
            this.rbutTrangThai2.Text = "Nghỉ";
            this.rbutTrangThai2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbutQuanLi);
            this.panel1.Controls.Add(this.rbutNhanVien);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(359, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 36);
            this.panel1.TabIndex = 21;
            // 
            // rbutQuanLi
            // 
            this.rbutQuanLi.AutoSize = true;
            this.rbutQuanLi.BackColor = System.Drawing.Color.Transparent;
            this.rbutQuanLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbutQuanLi.Location = new System.Drawing.Point(227, 3);
            this.rbutQuanLi.Name = "rbutQuanLi";
            this.rbutQuanLi.Size = new System.Drawing.Size(75, 22);
            this.rbutQuanLi.TabIndex = 24;
            this.rbutQuanLi.TabStop = true;
            this.rbutQuanLi.Text = "Quản lí";
            this.rbutQuanLi.UseVisualStyleBackColor = false;
            this.rbutQuanLi.CheckedChanged += new System.EventHandler(this.rbutQuanLi_CheckedChanged);
            // 
            // rbutNhanVien
            // 
            this.rbutNhanVien.AutoSize = true;
            this.rbutNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.rbutNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbutNhanVien.Location = new System.Drawing.Point(77, 3);
            this.rbutNhanVien.Name = "rbutNhanVien";
            this.rbutNhanVien.Size = new System.Drawing.Size(94, 22);
            this.rbutNhanVien.TabIndex = 23;
            this.rbutNhanVien.TabStop = true;
            this.rbutNhanVien.Text = "Nhân viên";
            this.rbutNhanVien.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Vai trò";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 21;
            // 
            // rbutTrangThai1
            // 
            this.rbutTrangThai1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.rbutTrangThai1.AutoSize = true;
            this.rbutTrangThai1.BackColor = System.Drawing.Color.Transparent;
            this.rbutTrangThai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbutTrangThai1.Location = new System.Drawing.Point(436, 74);
            this.rbutTrangThai1.Name = "rbutTrangThai1";
            this.rbutTrangThai1.Size = new System.Drawing.Size(134, 22);
            this.rbutTrangThai1.TabIndex = 21;
            this.rbutTrangThai1.TabStop = true;
            this.rbutTrangThai1.Text = "Đang hoạt động";
            this.rbutTrangThai1.UseVisualStyleBackColor = false;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(774, 32);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(163, 22);
            this.txtMatKhau.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(357, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Trạng thái";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(1026, 32);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 22);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(694, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(960, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã nhân viên";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(131, 75);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(194, 22);
            this.txtTenNhanVien.TabIndex = 1;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(131, 30);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(194, 22);
            this.txtMaNhanVien.TabIndex = 0;
            // 
            // DataNhanVien
            // 
            this.DataNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataNhanVien.Location = new System.Drawing.Point(12, 240);
            this.DataNhanVien.Name = "DataNhanVien";
            this.DataNhanVien.ReadOnly = true;
            this.DataNhanVien.RowHeadersWidth = 51;
            this.DataNhanVien.RowTemplate.Height = 24;
            this.DataNhanVien.Size = new System.Drawing.Size(1226, 353);
            this.DataNhanVien.TabIndex = 1;
            this.DataNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNhanVien_CellContentClick);
            this.DataNhanVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNhanVien_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Sienna;
            this.label10.Location = new System.Drawing.Point(266, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 32);
            this.label10.TabIndex = 19;
            this.label10.Text = "Quản lí nhân viên";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(958, 18);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(269, 22);
            this.txtTimKiem.TabIndex = 19;
            // 
            // butThem
            // 
            this.butThem.Location = new System.Drawing.Point(29, 193);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(127, 41);
            this.butThem.TabIndex = 20;
            this.butThem.Text = "Thêm";
            this.butThem.UseVisualStyleBackColor = true;
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // butLamMoi
            // 
            this.butLamMoi.Location = new System.Drawing.Point(527, 193);
            this.butLamMoi.Name = "butLamMoi";
            this.butLamMoi.Size = new System.Drawing.Size(127, 41);
            this.butLamMoi.TabIndex = 21;
            this.butLamMoi.Text = "Làm mới";
            this.butLamMoi.UseVisualStyleBackColor = true;
            this.butLamMoi.Click += new System.EventHandler(this.butLamMoi_Click);
            // 
            // butXoa
            // 
            this.butXoa.Location = new System.Drawing.Point(358, 193);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(127, 41);
            this.butXoa.TabIndex = 22;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = true;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butSua
            // 
            this.butSua.Location = new System.Drawing.Point(194, 193);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(127, 41);
            this.butSua.TabIndex = 23;
            this.butSua.Text = "Sửa";
            this.butSua.UseVisualStyleBackColor = true;
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butTimKiemnhanVien
            // 
            this.butTimKiemnhanVien.Location = new System.Drawing.Point(830, 13);
            this.butTimKiemnhanVien.Name = "butTimKiemnhanVien";
            this.butTimKiemnhanVien.Size = new System.Drawing.Size(119, 33);
            this.butTimKiemnhanVien.TabIndex = 24;
            this.butTimKiemnhanVien.Text = "Tìm kiếm";
            this.butTimKiemnhanVien.UseVisualStyleBackColor = true;
            this.butTimKiemnhanVien.Click += new System.EventHandler(this.butTimKiemnhanVien_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1243, 605);
            this.Controls.Add(this.butTimKiemnhanVien);
            this.Controls.Add(this.butSua);
            this.Controls.Add(this.butXoa);
            this.Controls.Add(this.butLamMoi);
            this.Controls.Add(this.butThem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DataNhanVien);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DataNhanVien;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.Button butLamMoi;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.Button butTimKiemnhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbutTrangThai1;
        private System.Windows.Forms.RadioButton rbutQuanLi;
        private System.Windows.Forms.RadioButton rbutNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbutTrangThai2;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.Label label5;
    }
}