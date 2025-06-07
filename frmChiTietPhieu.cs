using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Poly;
using DTO_PolyCafe;

namespace TB01284_PolyCafe
{
    public partial class frmChiTietPhieu : Form
    {
        public frmChiTietPhieu()
        {
            InitializeComponent();
        }

        private TheLuuDong theLuuDong;
        private PhieuBanHang phieuBanHang;
        private NhanVien nhanVien;
        private List<ChiTietPhieu> lstChiTiet;
        private List<SanPham> lstSanPham;
        bool isActive = true;
        public frmChiTietPhieu(TheLuuDong the, PhieuBanHang phieu, NhanVien nv)
        {
            InitializeComponent();
            theLuuDong = the;
            phieuBanHang = phieu;
            nhanVien = nv;
            lstChiTiet = new List<ChiTietPhieu>();
            lstSanPham = new List<SanPham>();
            isActive = phieu.TrangThai;
        }

        private void activeTranfer()
        {
            if (isActive)
            {
                butThem.Enabled = false;
                butXoa.Enabled = false;
            }
        }
        private void frmChiTietPhieu_Load(object sender, EventArgs e)
        {
            loadThanhToan();
            LoadInfo();
            loadSanPham();
            loadChiTietPhieu(phieuBanHang.MaPhieu);
            activeTranfer();
        }

        private void LoadInfo()
        {
            labelChuSohuu.Text = $"{theLuuDong.MaThe} - {theLuuDong.ChuSoHuu}";
            labelMaPhieu.Text = phieuBanHang.MaPhieu;
            labelNgaylap.Text = phieuBanHang.NgayTao.ToString("dd/MM/yyyy");
        }
        private void loadSanPham()
        {
            BUS_SanPham sp = new BUS_SanPham();
            lstSanPham = sp.GetSanPhamList(1);
            DataSanPham.DataSource = lstSanPham;
            DataSanPham.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            DataSanPham.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            DataSanPham.Columns["DonGia"].HeaderText = "Đơn Gía";
            DataSanPham.Columns["TenLoai"].HeaderText = "Loại Sản Phẩm";
            DataSanPham.Columns["HinhAnh"].HeaderText = "Hình Ảnh";


            DataSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void loadChiTietPhieu(string maPhieu)
        {
            BUS_ChiTietPhieu bus = new BUS_ChiTietPhieu();
            lstChiTiet = bus.GetChiTietPhieuList(maPhieu);
            DataChiTietPhieu.DataSource = lstChiTiet;
            DataChiTietPhieu.Columns["MaChiTiet"].Visible = false;
            DataChiTietPhieu.Columns["MaPhieu"].Visible = false;
            DataChiTietPhieu.Columns["MaSanPham"].Visible = false;
            DataChiTietPhieu.Columns["TenSanPham"].HeaderText = "Sản Phẩm";
            DataChiTietPhieu.Columns["SoLuong"].HeaderText = "Số Lượng";
            DataChiTietPhieu.Columns["DonGia"].HeaderText = "Đơn Giá";
            DataChiTietPhieu.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            DataChiTietPhieu.Columns["SoLuong"].ReadOnly = false;

            DataChiTietPhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn col in DataChiTietPhieu.Columns)
            {
                col.ReadOnly = true;
            }
            DataChiTietPhieu.Columns["SoLuong"].ReadOnly = false;
        }
        


        private void butTthem_Click(object sender, EventArgs e)
        {
           
        }

        private void butXoa_Click(object sender, EventArgs e)
        {

        }

        private void DataChiTietPhieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isActive)
            {
                return;
            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataSanPham.Rows[e.RowIndex];

                // Tạo đối tượng từ dữ liệu hàng
                SanPham sanPham = new SanPham
                {
                    MaSanPham = row.Cells["MaSanPham"].Value.ToString(),
                    TenSanPham = row.Cells["TenSanPham"].Value.ToString(),
                    DonGia = Convert.ToInt32(row.Cells["DonGia"].Value)
                };

                transfer(sanPham);
            }
        }

        private void transfer(SanPham sp, int soLuong = 1)
        {
            if (isActive)
            {
                return;
            }
            if (sp != null)
            {
                BUS_ChiTietPhieu bus = new BUS_ChiTietPhieu();
                ChiTietPhieu existingItem = lstChiTiet.FirstOrDefault(item => item.MaSanPham == sp.MaSanPham);
                if (existingItem != null)
                {
                    existingItem.SoLuong += soLuong;
                    string result = bus.UpdateSoLuong(existingItem);
                    if (!string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    ChiTietPhieu ct = new ChiTietPhieu()
                    {
                        MaPhieu = phieuBanHang.MaPhieu,
                        MaSanPham = sp.MaSanPham,
                        SoLuong = soLuong,
                        DonGia = sp.DonGia,
                    };
                    string result = bus.InsertChiTietPhieu(ct);
                    if (!string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                loadChiTietPhieu(phieuBanHang.MaPhieu);

            }
        }
        private void deleteChiTiet()
        {
            if (DataChiTietPhieu.CurrentRow != null)
            {
                string id = Convert.ToString(DataChiTietPhieu.CurrentRow.Cells["MaChiTiet"].Value);
                string name = Convert.ToString(DataChiTietPhieu.CurrentRow.Cells["TenSanPham"].Value);
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phầm {name}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    BUS_ChiTietPhieu bus = new BUS_ChiTietPhieu();
                    string kq = bus.DeleteChiTiet(id); ;
                    if (string.IsNullOrEmpty(kq))
                    {
                        loadChiTietPhieu(phieuBanHang.MaPhieu);
                    }
                }
            }
        }

        private void DataChiTietPhieu_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (isActive)
            {
                return;
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                BUS_ChiTietPhieu bus = new BUS_ChiTietPhieu();
                ChiTietPhieu ct = lstChiTiet[e.RowIndex];
                int newQuantity;
                if (int.TryParse(DataChiTietPhieu.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString(), out newQuantity))
                {
                    ct.SoLuong = newQuantity;
                    string result = bus.UpdateSoLuong(ct);
                    if (!string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //Đảm bảo ko lỗi khi đang edit mà chuyển ô
                    this.BeginInvoke((Action)(() =>
                    {
                        loadChiTietPhieu(phieuBanHang.MaPhieu);
                    }));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void loadThanhToan()
        {
            txtTong.Text = "0";
            txtGiamGia.Text = "0";
            txtPhanTram.Text = "0";
            txtThanhTien.Text = "0";
        }

        private void DataChiTietPhieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (isActive)
            {
                return;
            }
            if (DataSanPham.CurrentRow != null)
            {
                string id = Convert.ToString(DataSanPham.CurrentRow.Cells["MaSanPham"].Value);
                string ten = Convert.ToString(DataSanPham.CurrentRow.Cells["TenSanPham"].Value);
                decimal dongia = Convert.ToDecimal(DataSanPham.CurrentRow.Cells["DonGia"].Value);
                SanPham sanPham = new SanPham
                {
                    MaSanPham = id,
                    TenSanPham = ten,
                    DonGia = dongia
                };

                transfer(sanPham);
            }
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
