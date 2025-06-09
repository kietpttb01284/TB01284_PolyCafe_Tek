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
    public partial class frmTheLuuDong : Form
    {
        public frmTheLuuDong()
        {
            InitializeComponent();
            LoadDanhSachThe();
        }

        private void ClearForm()
        {
            butThem.Enabled = true;
            butSua.Enabled = false;
            butXoa.Enabled = true;
            txtMaThe.Clear();
            txtTenNguoiSoHuu.Clear();
            rbutHoatDong.Checked = true;
        }





        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DataTheLuuDong.Rows[e.RowIndex];
            // Đổ dữ liệu vào các ô nhập liệu trên form
            txtMaThe.Text = row.Cells["MaThe"].Value.ToString();
            txtTenNguoiSoHuu.Text = row.Cells["ChuSoHuu"].Value.ToString();

            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            rbutHoatDong.Checked = trangThai;

            // Bật nút "Sửa"
            butThem.Enabled = false;
            butSua.Enabled = true;
            butXoa.Enabled = true;
            // Tắt chỉnh sửa mã thẻ
            txtMaThe.Enabled = false;
        }

        private void LoadDanhSachThe()
        {
            BUS_TheLuuDong BUS_TheLuuDong = new BUS_TheLuuDong();
            DataTheLuuDong.DataSource = null;
            DataTheLuuDong.DataSource = BUS_TheLuuDong.GetTheLuuDongList();
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            string chuSoHuu = txtTenNguoiSoHuu.Text.Trim();

            bool trangThai;

            if (rbutHoatDong.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(chuSoHuu))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin thẻ lưu động.");
                return;
            }

            TheLuuDong theLuuDong = new TheLuuDong
            {
                MaThe = maThe,
                ChuSoHuu = chuSoHuu,
                TrangThai = trangThai
            };
            BUS_TheLuuDong bus = new BUS_TheLuuDong();
            string result = bus.InsertTheLuuDong(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadDanhSachThe();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void butLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachThe();
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            string chuSoHuu = txtTenNguoiSoHuu.Text.Trim();

            bool trangThai;

            if (rbutHoatDong.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(chuSoHuu))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin thẻ lưu động.");
                return;
            }
            TheLuuDong theLuuDong = new TheLuuDong
            {
                MaThe = maThe,
                ChuSoHuu = chuSoHuu,
                TrangThai = trangThai
            };
            BUS_TheLuuDong bus = new BUS_TheLuuDong();
            string result = bus.UpdateTheLuuDong(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadDanhSachThe();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            string chuSoHuu = txtTenNguoiSoHuu.Text.Trim();
            if (string.IsNullOrEmpty(maThe))
            {
                if (DataTheLuuDong.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = DataTheLuuDong.SelectedRows[0];
                    maThe = selectedRow.Cells["MaThe"].Value.ToString();
                    chuSoHuu = selectedRow.Cells["ChuSoHuu"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một thẻ lưu động để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maThe))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa thẻ lưu động {maThe} - {chuSoHuu}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUS_TheLuuDong bus = new BUS_TheLuuDong();
                string kq = bus.DeleteTheLuuDong(maThe);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin thẻ lưu động {maThe} - {chuSoHuu} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachThe();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void DataTheLuuDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void butTimKiem_Click(object sender, EventArgs e)
        {
            //string keyword = txtTimKiemThe.Text.Trim();
            //if (string.IsNullOrEmpty(keyword))
            //{
            //    MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //try
            //{
            //    bool found = false;
            //    List<int> foundRows = new List<int>();

            //    foreach (DataGridViewRow row in DataTheLuuDong.Rows)
            //    {
            //        if (row.IsNewRow) continue;

            //        bool rowMatches = false;

            //        foreach (DataGridViewCell cell in row.Cells)
            //        {
            //            if (cell.Value != null)
            //            {
            //                string cellText = cell.Value.ToString().Trim();
            //                if (cellText.ToLower().Contains(keyword.ToLower()))
            //                {
            //                    rowMatches = true;
            //                    break;
            //                }
            //            }
            //        }

            //        if (rowMatches)
            //        {
            //            foundRows.Add(row.Index);
            //            found = true;
            //        }
            //    }

            //    if (found)
            //    {
            //        DataTheLuuDong.ClearSelection();

            //        foreach (int rowIndex in foundRows)
            //        {
            //            DataTheLuuDong.Rows[rowIndex].Selected = true;
            //        }

            //        if (foundRows.Count > 0)
            //        {
            //            DataTheLuuDong.FirstDisplayedScrollingRowIndex = foundRows[0];

            //            // Nếu chỉ có 1 kết quả thì đổ dữ liệu vào form
            //            if (foundRows.Count == 1)
            //            {
            //                DataGridViewRow selectedRow = DataTheLuuDong.Rows[foundRows[0]];
            //                txtMaThe.Text = selectedRow.Cells["MaThe"].Value.ToString();
            //                txtTenNguoiSoHuu.Text = selectedRow.Cells["ChuSoHuu"].Value.ToString();

            //                bool trangThai = Convert.ToBoolean(selectedRow.Cells["TrangThai"].Value);
            //                rbutHoatDong.Checked = trangThai;

            //                // Cập nhật trạng thái nút
            //                txtMaThe.Enabled = false;
            //                butThem.Enabled = false;
            //                butSua.Enabled = true;
            //                butXoa.Enabled = true;
            //            }
            //        }

            //        MessageBox.Show($"Tìm thấy {foundRows.Count} kết quả khớp với từ khóa: '{keyword}'",
            //            "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show($"Không tìm thấy kết quả nào khớp với từ khóa: '{keyword}'",
            //            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        DataTheLuuDong.ClearSelection();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                LoadDanhSachThe();
                return;
            }

            BUS_TheLuuDong bus = new BUS_TheLuuDong();
            List<TheLuuDong> danhSach = bus.GetTheLuuDongList();

            var ketQua = danhSach.Where(the =>
                the.MaThe.ToLower().Contains(tuKhoa) ||
                the.ChuSoHuu.ToLower().Contains(tuKhoa)
            ).ToList();

            DataTheLuuDong.DataSource = null;
            DataTheLuuDong.DataSource = ketQua;

            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butTimKiem.PerformClick();
            }
        }
    }
}
