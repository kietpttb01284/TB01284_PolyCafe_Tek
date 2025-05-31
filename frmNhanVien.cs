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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.WindowState = FormWindowState.Normal;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDSNhanVien();
        }

        public void LoadDSNhanVien()
        {
            BUS_NhanVien bus = new BUS_NhanVien();
            DataNhanVien.DataSource = null;
            DataNhanVien.DataSource = bus.GetDSNhanVien();
            DataNhanVien.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            DataNhanVien.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            DataNhanVien.Columns["Email"].HeaderText = "Email";
            DataNhanVien.Columns["MatKhau"].HeaderText = "Mật khẩu";
            DataNhanVien.Columns["VaiTroText"].HeaderText = "Vai trò";
            DataNhanVien.Columns["TrangThaiText"].HeaderText = "Trạng thái";
            DataNhanVien.Columns["VaiTro"].Visible = false;
            DataNhanVien.Columns["TrangThai"].Visible = false;
        }

        private void butLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = true;
            butThem.Enabled = true;
            butSua.Enabled = false;
            butXoa.Enabled = false;
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            txtXacNhanMatKhau.Clear();

        }
        private void ClearForm()
        {
            butThem.Enabled = true;
            butSua.Enabled = false;
            butXoa.Enabled = true;
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            txtXacNhanMatKhau.Clear();
            rbutNhanVien.Checked = true;
            rbutTrangThai1.Checked = true;
        }
        private void butThem_Click(object sender, EventArgs e)
        {

            try
            {
                // Bước 1: Lấy dữ liệu từ form
                string maNV = txtMaNhanVien.Text.Trim();
                string hoTen = txtTenNhanVien.Text.Trim();
                string email = txtEmail.Text.Trim();
                string matKhau = txtMatKhau.Text.Trim();
                string xacNhanMK = txtXacNhanMatKhau.Text.Trim();
                bool vaiTro;

                if (rbutNhanVien.Checked)
                {
                    vaiTro = true; // Nhân viên
                }
                else
                {
                    vaiTro = false; // Quản lý
                }

                // Bước 2: Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (matKhau != xacNhanMK)
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Bước 3: Tạo đối tượng nhân viên
                NhanVien nv = new NhanVien
                {
                    MaNhanVien = maNV,
                    TenNhanVien = hoTen,
                    Email = email,
                    MatKhau = matKhau,
                    VaiTro = vaiTro,
                    TrangThai = false // Mặc định là active
                };

                BUS_NhanVien busNhanVien = new BUS_NhanVien();
                busNhanVien.InsertNhanVien(nv);

                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbutQuanLi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DataNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= DataNhanVien.Rows.Count)
            {
                return;
            }

            // Use a local variable to store the row instead of directly accessing it in the statement
            var selectedRow = DataNhanVien.Rows[e.RowIndex];
            DataGridViewRow row = selectedRow;

            txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value.ToString();
            txtTenNhanVien.Text = row.Cells["TenNhanVien"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            txtXacNhanMatKhau.Text = row.Cells["MatKhau"].Value.ToString();

            bool vaiTro = Convert.ToBoolean(row.Cells["VaiTro"].Value);
            if (vaiTro == false)
            {
                rbutNhanVien.Checked = true;
            }
            else
            {
                rbutQuanLi.Checked = true;
            }

            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            if (trangThai == false)
            {
                rbutTrangThai1.Checked = true;
            }
            else
            {
                rbutTrangThai2.Checked = true;
            }

            // Bật nút "Sửa"  
            butThem.Enabled = false;
            butSua.Enabled = true;
            butXoa.Enabled = true;
            // Tắt chỉnh sửa mã nhân viên  
            txtMaNhanVien.Enabled = false;
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNhanVien.Text.Trim();
            string hoTen = txtTenNhanVien.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string xacNhanMK = txtXacNhanMatKhau.Text.Trim();
            bool vaiTro;

            if (rbutQuanLi.Checked)
            {
                vaiTro = true;
            }
            else
            {
                vaiTro = false;
            }
            bool trangThai;

            if (rbutTrangThai2.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }

            if (!matKhau.Equals(xacNhanMK))
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp.");
                return;
            }
            NhanVien nv = new NhanVien
            {
                MaNhanVien = maNV,
                TenNhanVien = hoTen,
                Email = email,
                MatKhau = matKhau,
                VaiTro = vaiTro,
                TrangThai = trangThai
            };
            BUS_NhanVien bus = new BUS_NhanVien();
            string result = bus.UpdateNhanVien(nv);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadDSNhanVien();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void DataNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNhanVien.Text.Trim();
            string name = txtTenNhanVien.Text.Trim();
            if (string.IsNullOrEmpty(maNhanVien))
            {
                if (DataNhanVien.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = DataNhanVien.SelectedRows[0];
                    maNhanVien = selectedRow.Cells["MaNhanVien"].Value.ToString();
                    name = selectedRow.Cells["HoTen"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maNhanVien))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên {maNhanVien} - {name}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUS_NhanVien bus = new BUS_NhanVien();
                string kq = bus.DeleteNhanVien(maNhanVien);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin nhân viên {maNhanVien} - {name} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDSNhanVien();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void butTimKiemnhanVien_Click(object sender, EventArgs e)
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
                List<int> foundRows = new List<int>(); // Lưu các dòng tìm thấy

                // Duyệt qua từng dòng trong DataGridView
                foreach (DataGridViewRow row in DataNhanVien.Rows)
                {
                    if (row.IsNewRow) continue; // Bỏ qua dòng mới (empty row)

                    bool rowMatches = false;

                    // Dối chiếu text từng ô với keyword
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            string cellText = cell.Value.ToString().Trim();

                            // So sánh không phân biệt hoa thường
                            if (cellText.ToLower().Contains(keyword.ToLower()))
                            {
                                rowMatches = true;
                                break; // Thoát khỏi vòng lặp cell khi tìm thấy match
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
                    // Xóa selection cũ
                    DataNhanVien.ClearSelection();

                    // Highlight tất cả các dòng tìm thấy
                    foreach (int rowIndex in foundRows)
                    {
                        DataNhanVien.Rows[rowIndex].Selected = true;
                    }

                    // Cuộn đến dòng đầu tiên tìm thấy
                    if (foundRows.Count > 0)
                    {
                        DataNhanVien.FirstDisplayedScrollingRowIndex = foundRows[0];

                        // Nếu chỉ có 1 kết quả, điền thông tin vào form
                        if (foundRows.Count == 1)
                        {
                            DataGridViewRow selectedRow = DataNhanVien.Rows[foundRows[0]];

                            // Điền thông tin vào form
                            txtMaNhanVien.Text = selectedRow.Cells["MaNhanVien"].Value.ToString();
                            txtTenNhanVien.Text = selectedRow.Cells["TenNhanVien"].Value.ToString();
                            txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                            txtMatKhau.Text = selectedRow.Cells["MatKhau"].Value.ToString();
                            txtXacNhanMatKhau.Text = selectedRow.Cells["MatKhau"].Value.ToString();

                            // Thiết lập radio button vai trò
                            bool vaiTro = Convert.ToBoolean(selectedRow.Cells["VaiTro"].Value);
                            if (vaiTro == false)
                            {
                                rbutNhanVien.Checked = true;
                            }
                            else
                            {
                                rbutQuanLi.Checked = true;
                            }

                            // Thiết lập radio button trạng thái
                            bool trangThai = Convert.ToBoolean(selectedRow.Cells["TrangThai"].Value);
                            if (trangThai == false)
                            {
                                rbutTrangThai1.Checked = true;
                            }
                            else
                            {
                                rbutTrangThai2.Checked = true;
                            }

                            // Cập nhật trạng thái các button
                            butThem.Enabled = false;
                            butSua.Enabled = true;
                            butXoa.Enabled = true;
                            txtMaNhanVien.Enabled = false;
                        }
                    }

                    MessageBox.Show($"Tìm thấy {foundRows.Count} kết quả khớp với từ khóa: '{keyword}'",
                        "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy kết quả nào khớp với từ khóa: '{keyword}'",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataNhanVien.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
