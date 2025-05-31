using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS_Poly;
using DTO_PolyCafe;

namespace TB01284_PolyCafe
{
    public partial class frmSanPham : Form
    {
        BUS_SanPham bus_LoaiSanPham = new BUS_SanPham();
        public frmSanPham()
        {
            InitializeComponent();
            txtDonGia.Mask = "000000.00";
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            ClearForm();
            ClearFormLoai();
            LoadLoaiSanPham();
            LoadDanhSachSanPham();
        }

        private void ClearForm()
        {
            butThem.Enabled = true;
            butSua.Enabled = false;
            butXoa.Enabled = true;
            txtMaSanPham.Clear();
            txtTenSanPham.Clear();
            txtDonGia.Clear();
            rbutConBan.Checked = true;
            PicSanPham.Image = null;
        }
        private void LoadLoaiSanPham()
        {
            try
            {
                List<LoaiSanPham> dsLoai = bus_LoaiSanPham.GetLoaiSanPhamList();
                CBLoaiSanPham.DataSource = dsLoai;
                CBLoaiSanPham.ValueMember = "tenLoai";
                CBLoaiSanPham.DisplayMember = "TenLoai";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachSanPham()
        {
            BUS_SanPham BUS_SanPham = new BUS_SanPham();
            DataSanPham.DataSource = null;
            List<SanPham> lstSP = BUS_SanPham.GetSanPhamList();
            DataSanPham.DataSource = lstSP;
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSP = txtTenSanPham.Text.Trim();
                string donGiaText = txtDonGia.Text.Trim();
                string tenLoai = CBLoaiSanPham.SelectedValue?.ToString();
                bool trangThai = rbutConBan.Checked;

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donGiaText) || string.IsNullOrEmpty(tenLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển đổi đơn giá
                if (!decimal.TryParse(donGiaText, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng sản phẩm
                SanPham sp = new SanPham
                {
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    TenLoai = tenLoai,
                    TrangThai = trangThai,
                    HinhAnh = ""
                };

                // Thêm sản phẩm vào cơ sở dữ liệu
                BUS_SanPham BUS_SanPham = new BUS_SanPham();
                BUS_SanPham.InsertSanPham(sp);

                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới form sau khi thêm
                ClearForm();
                LoadDanhSachSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSanPham.Text.Trim();
            string tenSP = string.Empty;
            string hinhAnh = string.Empty;

            if (string.IsNullOrEmpty(maSP))
            {
                if (DataSanPham.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = DataSanPham.SelectedRows[0];
                    maSP = selectedRow.Cells["MaSanPham"].Value.ToString();
                    tenSP = selectedRow.Cells["TenSanPham"].Value.ToString();
                    hinhAnh = selectedRow.Cells["HinhAnh"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                tenSP = txtTenSanPham.Text.Trim();
            }

            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm {maSP} - {tenSP}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUS_SanPham bus = new BUS_SanPham();
                string kq = bus.DeleteSanPham(maSP);

                if (string.IsNullOrEmpty(kq))
                {

                    MessageBox.Show($"Xóa thông tin sản phẩm {maSP} - {tenSP} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachSanPham();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSP = txtTenSanPham.Text.Trim();
                string donGiaText = txtDonGia.Text.Trim();
                string tenLoai = CBLoaiSanPham.SelectedValue?.ToString();
                bool trangThai = rbutConBan.Checked;
                string maSP = txtMaSanPham.Text.Trim();

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donGiaText) || string.IsNullOrEmpty(tenLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển đổi đơn giá
                if (!decimal.TryParse(donGiaText, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng sản phẩm
                SanPham sp = new SanPham
                {
                    MaSanPham = maSP,
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    TenLoai = tenLoai,
                    TrangThai = trangThai,
                };

                // Thêm sản phẩm vào cơ sở dữ liệu
                BUS_SanPham BUS_SanPham = new BUS_SanPham();
                string result = BUS_SanPham.UpdateSanPham(sp);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Cập nhật thông tin thành công");
                    ClearForm();
                    LoadDanhSachSanPham();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadLoaiSanPham();
            LoadDanhSachSanPham();
        }

        private void DataSanPham_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DataSanPham.Rows[e.RowIndex];
            txtMaSanPham.Text = row.Cells["MaSanPham"].Value.ToString();
            txtTenSanPham.Text = row.Cells["TenSanPham"].Value.ToString();
            txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
            CBLoaiSanPham.SelectedValue = row.Cells["tenLoai"].Value.ToString();
            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            if (trangThai)
            {
                rbutConBan.Checked = true;
            }
            else
            {
                rbutNgungBan.Checked = true;
            }
            butThem.Enabled = false;
            butSua.Enabled = true;
            butXoa.Enabled = true;
        }

        private void frmSanPham_Resize(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = 10;
        }









































        private void ClearFormLoai()
        {
            butThemLoai.Enabled = true;
            butSuaLoai.Enabled = false;
            butXoaLoai.Enabled = true;
            txtMaLoai.Clear();
            txtGhiChu.Clear();
            txtTenLoai.Clear();
        }

        private void LoadDanhSachLoaiSP()
        {
            BUS_SanPham busLoaiSp = new BUS_SanPham();
            DataLoaiSanPham.DataSource = null;
            DataLoaiSanPham.DataSource = busLoaiSp.GetLoaiSanPhamList();
            DataLoaiSanPham.Columns["MaLoai"].HeaderText = "Mã Loại";
            DataLoaiSanPham.Columns["TenLoai"].HeaderText = "Tên Loại";
            DataLoaiSanPham.Columns["GhiChu"].HeaderText = "Ghi Chú";

            DataLoaiSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void butTthem_Click(object sender, EventArgs e)
        {
            string maLoai = txtMaLoai.Text.Trim();
            string tenLoai = txtTenLoai.Text.Trim();
            string ghiChu = txtGhiChu.Text.Trim();


            if (string.IsNullOrEmpty(tenLoai))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin thẻ lưu động.");
                return;
            }

            LoaiSanPham loai = new LoaiSanPham
            {
                MaLoai = maLoai,
                TenLoai = tenLoai,
                GhiChu = ghiChu
            };
            BUS_SanPham bus = new BUS_SanPham();
            string result = bus.InsertLoaiSanPham(loai);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearFormLoai();
                LoadLoaiSanPham();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maLoai = txtMaLoai.Text.Trim();
            string tenLoai = txtTenLoai.Text.Trim();
            string ghiChu = txtGhiChu.Text.Trim();
            if (string.IsNullOrEmpty(maLoai))
            {
                if (DataLoaiSanPham.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = DataLoaiSanPham.SelectedRows[0];
                    maLoai = selectedRow.Cells["MaLoai"].Value.ToString();
                    tenLoai = selectedRow.Cells["TenLoai"].Value.ToString();
                    ghiChu = selectedRow.Cells["GhiChu"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thông tin loại sản phẩm cần xóa xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maLoai))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa loại sản phẩm {maLoai} - {tenLoai}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUS_SanPham bus = new BUS_SanPham();
                string kq = bus.DeleteLoaiSanPham(maLoai);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin loại sản phẩm {maLoai} - {tenLoai} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachLoaiSP();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataLoaiSanPham_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DataLoaiSanPham.Rows[e.RowIndex];
            // Đổ dữ liệu vào các ô nhập liệu trên form
            txtMaLoai.Text = row.Cells["MaLoai"].Value.ToString();
            txtTenLoai.Text = row.Cells["TenLoai"].Value.ToString();
            txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();

            // Bật nút "Sửa"
            butThemLoai.Enabled = false;
            butSuaLoai.Enabled = true;
            butXoaLoai.Enabled = true;
            // Tắt chỉnh sửa mã thẻ
            txtMaLoai.Enabled = false;
        }

        private void DataLoaiSanPham_Resize(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = 10;
        }

        private void DataSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
