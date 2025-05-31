using System.Windows.Forms;

namespace TB01284_PolyCafe
{
    partial class frmMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.TSDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.TSThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.TSDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.TSThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.TSDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.TSSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.TSBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.thẻLưuĐộngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.TSNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.TSQuanLi = new System.Windows.Forms.ToolStripMenuItem();
            this.TSDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.pnMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSHeThong,
            this.TSDanhMuc,
            this.TSBanHang,
            this.MSNhanVien,
            this.TSDoanhThu,
            this.MSHuongDan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1261, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSHeThong
            // 
            this.TSHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSDoiMatKhau,
            this.TSThongTinTaiKhoan,
            this.TSDangXuat,
            this.TSThoat});
            this.TSHeThong.Name = "TSHeThong";
            this.TSHeThong.Size = new System.Drawing.Size(85, 24);
            this.TSHeThong.Text = "Hệ thống";
            // 
            // TSDoiMatKhau
            // 
            this.TSDoiMatKhau.Name = "TSDoiMatKhau";
            this.TSDoiMatKhau.Size = new System.Drawing.Size(181, 26);
            this.TSDoiMatKhau.Text = "Đổi mật khẩu";
            this.TSDoiMatKhau.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // TSThongTinTaiKhoan
            // 
            this.TSThongTinTaiKhoan.Name = "TSThongTinTaiKhoan";
            this.TSThongTinTaiKhoan.Size = new System.Drawing.Size(181, 26);
            this.TSThongTinTaiKhoan.Text = "Thông tin tài ";
            // 
            // TSDangXuat
            // 
            this.TSDangXuat.Name = "TSDangXuat";
            this.TSDangXuat.Size = new System.Drawing.Size(181, 26);
            this.TSDangXuat.Text = "Đăng xuất";
            // 
            // TSThoat
            // 
            this.TSThoat.Name = "TSThoat";
            this.TSThoat.Size = new System.Drawing.Size(181, 26);
            this.TSThoat.Text = "Thoát";
            this.TSThoat.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // TSDanhMuc
            // 
            this.TSDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSanPham});
            this.TSDanhMuc.Name = "TSDanhMuc";
            this.TSDanhMuc.Size = new System.Drawing.Size(90, 24);
            this.TSDanhMuc.Text = "Danh mục";
            // 
            // TSSanPham
            // 
            this.TSSanPham.Name = "TSSanPham";
            this.TSSanPham.Size = new System.Drawing.Size(224, 26);
            this.TSSanPham.Text = "Sản phẩm";
            this.TSSanPham.Click += new System.EventHandler(this.TSSanPham_Click);
            // 
            // TSBanHang
            // 
            this.TSBanHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thẻLưuĐộngToolStripMenuItem,
            this.phiếuBánHàngToolStripMenuItem});
            this.TSBanHang.Name = "TSBanHang";
            this.TSBanHang.Size = new System.Drawing.Size(85, 24);
            this.TSBanHang.Text = "Bán hàng";
            this.TSBanHang.Click += new System.EventHandler(this.TSBanHang_Click);
            // 
            // thẻLưuĐộngToolStripMenuItem
            // 
            this.thẻLưuĐộngToolStripMenuItem.Name = "thẻLưuĐộngToolStripMenuItem";
            this.thẻLưuĐộngToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.thẻLưuĐộngToolStripMenuItem.Text = "Thẻ lưu động";
            this.thẻLưuĐộngToolStripMenuItem.Click += new System.EventHandler(this.thẻLưuĐộngToolStripMenuItem_Click);
            // 
            // phiếuBánHàngToolStripMenuItem
            // 
            this.phiếuBánHàngToolStripMenuItem.Name = "phiếuBánHàngToolStripMenuItem";
            this.phiếuBánHàngToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.phiếuBánHàngToolStripMenuItem.Text = "Phiếu bán hàng";
            // 
            // MSNhanVien
            // 
            this.MSNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSNhanVien,
            this.TSQuanLi});
            this.MSNhanVien.Name = "MSNhanVien";
            this.MSNhanVien.Size = new System.Drawing.Size(93, 24);
            this.MSNhanVien.Text = "Nhân viên ";
            this.MSNhanVien.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // TSNhanVien
            // 
            this.TSNhanVien.Name = "TSNhanVien";
            this.TSNhanVien.Size = new System.Drawing.Size(162, 26);
            this.TSNhanVien.Text = "Nhân viên ";
            // 
            // TSQuanLi
            // 
            this.TSQuanLi.Name = "TSQuanLi";
            this.TSQuanLi.Size = new System.Drawing.Size(162, 26);
            this.TSQuanLi.Text = "Quản lí";
            // 
            // TSDoanhThu
            // 
            this.TSDoanhThu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiHàngToolStripMenuItem});
            this.TSDoanhThu.Name = "TSDoanhThu";
            this.TSDoanhThu.Size = new System.Drawing.Size(92, 24);
            this.TSDoanhThu.Text = "Doanh thu";
            // 
            // loạiHàngToolStripMenuItem
            // 
            this.loạiHàngToolStripMenuItem.Name = "loạiHàngToolStripMenuItem";
            this.loạiHàngToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.loạiHàngToolStripMenuItem.Text = "Loại hàng";
            // 
            // MSHuongDan
            // 
            this.MSHuongDan.Name = "MSHuongDan";
            this.MSHuongDan.Size = new System.Drawing.Size(98, 24);
            this.MSHuongDan.Text = "Hướng dẫn";
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.ForeColor = System.Drawing.Color.Crimson;
            this.pnMain.Location = new System.Drawing.Point(0, 28);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1261, 654);
            this.pnMain.TabIndex = 1;
            this.pnMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMain_Paint);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1261, 682);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainForm_FormClosing);
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSHeThong;
        private System.Windows.Forms.ToolStripMenuItem TSDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem TSThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem TSDangXuat;
        private System.Windows.Forms.ToolStripMenuItem TSThoat;
        private System.Windows.Forms.ToolStripMenuItem TSDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem TSBanHang;
        private System.Windows.Forms.ToolStripMenuItem MSNhanVien;
        private System.Windows.Forms.ToolStripMenuItem TSDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem MSHuongDan;
        private System.Windows.Forms.Panel pnMain;
        private ToolStripMenuItem TSSanPham;
        private ToolStripMenuItem loạiHàngToolStripMenuItem;
        private ToolStripMenuItem TSNhanVien;
        private ToolStripMenuItem TSQuanLi;
        private ToolStripMenuItem thẻLưuĐộngToolStripMenuItem;
        private ToolStripMenuItem phiếuBánHàngToolStripMenuItem;
    }
}