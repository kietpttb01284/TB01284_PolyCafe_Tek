using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
            //txtDonGia.Mask = "000000.00";
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            ClearForm();
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
                BUS_LoaiSanPham bUSLoaiSanPham = new BUS_LoaiSanPham();
                List<LoaiSanPham> dsLoai = bUSLoaiSanPham.GetLoaiSanPhamList();
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

        private void butThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string tenSP = txtTenSanPham.Text.Trim();
                string donGiaText = txtDonGia.Text.Trim();
                string tenLoai = CBLoaiSanPham.SelectedValue?.ToString();
                bool trangThai = rbutConBan.Checked;
                string savapath = string.Empty; // Đường dẫn lưu ảnh, nếu có

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

                string savepath = ImageUtil.SaveImage(PicSanPham.Image, "Uploads");


                // Tạo đối tượng sản phẩm
                SanPham sp = new SanPham
                {
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    TenLoai = tenLoai,
                    TrangThai = trangThai,
                    HinhAnh = savapath
                };



                // Thêm sản phẩm vào cơ sở dữ liệu
                BUS_SanPham BUS_SanPham = new BUS_SanPham();
                string result = BUS_SanPham.InsertSanPham(sp);

                if (!string.IsNullOrEmpty(result))
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Làm mới form sau khi thêm
                ClearForm();
                LoadDanhSachSanPham(); // Đảm bảo gọi lại để cập nhật danh sách
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butXoa_Click_1(object sender, EventArgs e)
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

        private void butSua_Click_1(object sender, EventArgs e)
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

        private void butLamMoi_Click_1(object sender, EventArgs e)
        {
            ClearForm();
            LoadLoaiSanPham();
            LoadDanhSachSanPham();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DataSanPham_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= DataSanPham.Rows.Count)
                return;

            DataGridViewRow row = DataSanPham.Rows[e.RowIndex];

            // Gán dữ liệu từ dòng được chọn lên các controls
            txtMaSanPham.Text = row.Cells["MaSanPham"].Value?.ToString();
            txtTenSanPham.Text = row.Cells["TenSanPham"].Value?.ToString();
            txtDonGia.Text = row.Cells["DonGia"].Value?.ToString();

            string tenLoai = row.Cells["TenLoai"].Value?.ToString();
            if (!string.IsNullOrEmpty(tenLoai))
            {
                CBLoaiSanPham.SelectedValue = tenLoai;
            }

            string hinhAnh = row.Cells["HinhAnh"].Value?.ToString();
            if (!string.IsNullOrEmpty(hinhAnh))
            {
                string path = Path.Combine(AppContext.BaseDirectory, hinhAnh);

                try
                {
                    PicSanPham.Image = ImageUtil.LoadImage(path);
                    PicSanPham.Tag = path;
                }
                catch
                {
                    PicSanPham.Image = TB01284_PolyCafe.Properties.Resources.defalt_image;
                    PicSanPham.Tag = null;
                }
            }
            else
            {
                PicSanPham.Image = TB01284_PolyCafe.Properties.Resources.defalt_image;
                PicSanPham.Tag = null;
            }

            bool trangThai = false;
            bool.TryParse(row.Cells["TrangThai"].Value?.ToString(), out trangThai);
            rbutConBan.Checked = trangThai;
            rbutNgungBan.Checked = !trangThai;

            // Điều chỉnh trạng thái nút
            butThem.Enabled = false;
            butSua.Enabled = true;
            butXoa.Enabled = true;
        }

        private void butChonAnh_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
                openFileDialog.Title = "Chọn ảnh sản phẩm";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    PicSanPham.Image = Image.FromFile(imagePath);
                    PicSanPham.Tag = imagePath; // Ghi nhớ đường dẫn ảnh để lưu về sau
                }
            }
        }

        private void butTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool found = false;
                List<int> foundRows = new List<int>();

                foreach (DataGridViewRow row in DataSanPham.Rows)
                {
                    if (row.IsNewRow) continue;

                    bool rowMatches = false;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            string cellText = cell.Value.ToString().Trim();
                            if (cellText.ToLower().Contains(keyword.ToLower()))
                            {
                                rowMatches = true;
                                break;
                            }
                        }
                    }

                    if (rowMatches)
                    {
                        foundRows.Add(row.Index);
                        found = true;
                    }
                }

                if (found)
                {
                    DataSanPham.ClearSelection();

                    foreach (int rowIndex in foundRows)
                    {
                        DataSanPham.Rows[rowIndex].Selected = true;
                    }

                    if (foundRows.Count > 0)
                    {
                        DataSanPham.FirstDisplayedScrollingRowIndex = foundRows[0];

                        // Nếu chỉ tìm thấy 1 dòng → đổ dữ liệu vào form
                        if (foundRows.Count == 1)
                        {
                            DataSanPham_CellDoubleClick_1(this, new DataGridViewCellEventArgs(0, foundRows[0]));
                        }
                    }

                    MessageBox.Show($"Tìm thấy {foundRows.Count} kết quả khớp với từ khóa: '{keyword}'",
                        "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy kết quả nào khớp với từ khóa: '{keyword}'",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataSanPham.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butTimKiem.PerformClick();
            }
        }
    }
}
