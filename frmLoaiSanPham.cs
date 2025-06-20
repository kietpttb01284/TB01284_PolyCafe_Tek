﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Poly;
using DTO_PolyCafe;

namespace TB01284_PolyCafe
{
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        private void butThem_Click(object sender, EventArgs e)
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
            BUS_LoaiSanPham bus = new BUS_LoaiSanPham();
            string result = bus.InsertLoaiSanPham(loai);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadDanhSachLoaiSP();
            }
            else
            {
                MessageBox.Show(result);
            }
        }



        private void butXoa_Click(object sender, EventArgs e)
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
                BUS_LoaiSanPham bus = new BUS_LoaiSanPham();
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

        private void butSua_Click(object sender, EventArgs e)
        {
            string maLoai = txtMaLoai.Text.Trim();
            string tenLoai = txtTenLoai.Text.Trim();
            string ghiChu = txtGhiChu.Text.Trim();


            if (string.IsNullOrEmpty(tenLoai))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin loại sản phẩm.");
                return;
            }
            LoaiSanPham loaiSanPham = new LoaiSanPham
            {
                MaLoai = maLoai,
                TenLoai = tenLoai,
                GhiChu = ghiChu
            };
            BUS_LoaiSanPham bus = new BUS_LoaiSanPham();
            string result = bus.UpdateLoaiSanPham(loaiSanPham);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadDanhSachLoaiSP();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void butLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachLoaiSP();
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        { 
            ClearForm();
            LoadDanhSachLoaiSP();
        }

        private void ClearForm()
        {
            butThem.Enabled = true;
            butSua.Enabled = false;
            butXoa.Enabled = true;
            txtMaLoai.Clear();
            txtGhiChu.Clear();
            txtTenLoai.Clear();
        }

        private void LoadDanhSachLoaiSP()
        {
            BUS_LoaiSanPham busLoaiSp = new BUS_LoaiSanPham();
            DataLoaiSanPham.DataSource = null;
            DataLoaiSanPham.DataSource = busLoaiSp.GetLoaiSanPhamList();
            DataLoaiSanPham.Columns["MaLoai"].HeaderText = "Mã Loại";
            DataLoaiSanPham.Columns["TenLoai"].HeaderText = "Tên Loại";
            DataLoaiSanPham.Columns["GhiChu"].HeaderText = "Ghi Chú";

            DataLoaiSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DataLoaiSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DataLoaiSanPham.Rows[e.RowIndex];
            // Đổ dữ liệu vào các ô nhập liệu trên form
            txtMaLoai.Text = row.Cells["MaLoai"].Value.ToString();
            txtTenLoai.Text = row.Cells["TenLoai"].Value.ToString();
            txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();

            // Bật nút "Sửa"
            butThem.Enabled = false;
            butSua.Enabled = true;
            butXoa.Enabled = true;
            // Tắt chỉnh sửa mã thẻ
            txtMaLoai.Enabled = false;
        }

        private void DataLoaiSanPham_Resize(object sender, EventArgs e)
        {

        }

        private void butTimKiem2_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem2.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool found = false;
                List<int> foundRows = new List<int>();

                foreach (DataGridViewRow row in DataLoaiSanPham.Rows)
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
                    DataLoaiSanPham.ClearSelection();

                    foreach (int rowIndex in foundRows)
                    {
                        DataLoaiSanPham.Rows[rowIndex].Selected = true;
                    }

                    if (foundRows.Count > 0)
                    {
                        DataLoaiSanPham.FirstDisplayedScrollingRowIndex = foundRows[0];

                        // Nếu chỉ có 1 kết quả, đổ dữ liệu vào form
                        if (foundRows.Count == 1)
                        {
                            DataGridViewRow selectedRow = DataLoaiSanPham.Rows[foundRows[0]];

                            txtMaLoai.Text = selectedRow.Cells["MaLoai"].Value.ToString();
                            txtTenLoai.Text = selectedRow.Cells["TenLoai"].Value.ToString();
                            txtGhiChu.Text = selectedRow.Cells["GhiChu"].Value.ToString();

                            // Cập nhật trạng thái nút
                            butThem.Enabled = false;
                            butSua.Enabled = true;
                            butXoa.Enabled = true;
                            txtMaLoai.Enabled = false;
                        }
                    }

                    MessageBox.Show($"Tìm thấy {foundRows.Count} kết quả khớp với từ khóa: '{keyword}'",
                        "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy kết quả nào khớp với từ khóa: '{keyword}'",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataLoaiSanPham.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butTimKiem2.PerformClick();
            }
        }
    }
}
