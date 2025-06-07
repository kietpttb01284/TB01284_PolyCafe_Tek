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
using Util_Polycafe;

namespace TB01284_PolyCafe
{
    public partial class frmPhieuBanHang : Form
    {
        private bool isLoadingTheLuuDongData = true;
        private TheLuuDong theLuuDong;
        private PhieuBanHang phieuBanHang;
        private NhanVien nhanVien;
        private List<SanPham> listSanPham;
        private List<PhieuBanHang> listPhieuBanHang;
        public frmPhieuBanHang()
        {
            InitializeComponent();
        }
        private void frmPhieuBanHang_Load(object sender, EventArgs e)
        {
            ClearForm("");
            LoadTheLuuDong();
            LoadNhanVien();
            LoadDanhSachPhieu("");
        }
        private void ClearForm(string msThe)
        {
            try
            {
                butThem.Enabled = true;
                butSua.Enabled = false;
                butXoa.Enabled = false; // Sửa: ban đầu không cho phép xóa
                txtMaPhieu.Clear();
                CBNhanVien.Enabled = true;

                // Sửa lỗi: kiểm tra ComboBox trước khi thao tác
                if (CBMaThe.DataSource != null)
                {
                    CBMaThe.SelectedIndex = 0; // Chọn item đầu tiên thay vì Clear()
                }

                txtMaKhachHang.Clear();
                rbutChoXacNhan.Checked = true;
                TPNgayTao.Enabled = true;
                TPNgayTao.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa form: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadNhanVien()
        {
            try
            {
                BUS_NhanVien busNhanVien = new BUS_NhanVien();
                List<NhanVien> dsNhanVien = busNhanVien.GetDSNhanVien();

                if (dsNhanVien == null)
                {
                    dsNhanVien = new List<NhanVien>();
                }

                if (AuthUntil.user.VaiTro) // Admin
                {
                    dsNhanVien.Insert(0, new NhanVien()
                    {
                        MaNhanVien = string.Empty,
                        TenNhanVien = "--Vui lòng chọn nhân viên--" 
                    });
                    CBNhanVien.Enabled = true;
                }
                else // Nhân viên thường
                {
                    dsNhanVien = dsNhanVien.Where(x => x.MaNhanVien == AuthUntil.user.MaNhanVien).ToList();
                    CBNhanVien.Enabled = false;
                }

                CBNhanVien.DataSource = dsNhanVien;
                CBNhanVien.ValueMember = "MaNhanVien";
                CBNhanVien.DisplayMember = "HoTen";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTheLuuDong()
        {
            BUS_TheLuuDong BUS_TheLuuDong = new BUS_TheLuuDong();
            List<TheLuuDong> lst = BUS_TheLuuDong.GetTheLuuDongList();
            lst.Insert(0, new TheLuuDong() { MaThe = string.Empty, ChuSoHuu = string.Format("--Tất Cả--") });
            CBMaThe.DataSource = lst;
            CBMaThe.ValueMember = "MaThe";
            CBMaThe.DisplayMember = "ChuSoHuu";
            isLoadingTheLuuDongData = false;
        }

        private void LoadDanhSachPhieu(string maThe)
        {
            BUS_PhieuBanHang busPhieuBanHang = new BUS_PhieuBanHang();
            List<PhieuBanHang> lst = busPhieuBanHang.GetListPhieuBanHang(maThe);
            if (!AuthUntil.user.VaiTro)
            {
                lst = lst.Where(x => x.MaNhanVien == AuthUntil.user.MaNhanVien).ToList();
               CBNhanVien.Enabled = false;
            }
            DataPhieuBanHang.DataSource = lst;


            DataGridViewImageColumn buttonColumn = new DataGridViewImageColumn();
            buttonColumn.Name = "ThanhToan";
            buttonColumn.HeaderText = "Thanh Toán";
            //buttonColumn.Text = "Thanh Toán";
            //buttonColumn.UseColumnTextForButtonValue = true; // Hiển thị văn bản lên nút
            buttonColumn.Image = Properties.Resources.defalt_image; // Replace 'pay' with 'defalt_image'

            buttonColumn.DefaultCellStyle.BackColor = Color.LightBlue;
            buttonColumn.DefaultCellStyle.ForeColor = Color.DarkBlue;

            buttonColumn.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            if (!DataPhieuBanHang.Columns.Contains("ThanhToan"))
            {
                DataPhieuBanHang.Columns.Add(buttonColumn);
            }
            DataPhieuBanHang.Columns["ThanhToan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataPhieuBanHang.RowTemplate.Height = 50;

            DataPhieuBanHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void butThem_Click_1(object sender, EventArgs e)
        {
            string maThe = CBMaThe.SelectedValue?.ToString();
            string maNhanVien = CBNhanVien.SelectedValue?.ToString();
            DateTime ngayTao = TPNgayTao.Value;

            bool trangThai;
            if (rbutChoXacNhan.Checked)
            {
                trangThai = false;
            }
            else
            {
                trangThai = true;
            }
            if (string.IsNullOrEmpty(maNhanVien) || string.IsNullOrEmpty(maThe))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin phiếu bán hàng.");
                return;
            }

            PhieuBanHang theLuuDong = new PhieuBanHang
            {
                MaThe = maThe,
                MaNhanVien = maNhanVien,
                NgayTao = ngayTao,
                TrangThai = trangThai
            };
            BUS_PhieuBanHang bus = new BUS_PhieuBanHang();
            string result = bus.InsertPhieuBanHang(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm(maThe);
                LoadTheLuuDong();
                LoadNhanVien();
                LoadDanhSachPhieu("");
                CBMaThe.SelectedValue = maThe;
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            string maThe = CBMaThe.SelectedValue?.ToString();
            string maPhieu = txtMaPhieu.Text;
            string maNhanVien = CBNhanVien.SelectedValue?.ToString();
            DateTime ngayTao = TPNgayTao.Value;

            bool trangThai;
            if (rbutChoXacNhan.Checked)
            {
                trangThai = false;
            }
            else


            {
                trangThai = true;
            }
            if (string.IsNullOrEmpty(maNhanVien) || string.IsNullOrEmpty(maThe))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin phiếu bán hàng.");
                return;
            }

            PhieuBanHang theLuuDong = new PhieuBanHang
            {
                MaPhieu = maPhieu,
                MaThe = maThe,
                MaNhanVien = maNhanVien,
                NgayTao = ngayTao,
                TrangThai = trangThai
            };
            BUS_PhieuBanHang bus = new BUS_PhieuBanHang();
            string result = bus.UpdatePhieuBanHang(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm(maThe);
                LoadTheLuuDong();
                LoadNhanVien();
                LoadDanhSachPhieu("");
                CBMaThe.SelectedValue = maThe;
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            string maPhieu = txtMaPhieu.Text.Trim();
            string maThe = CBMaThe.SelectedValue?.ToString();
            string chuSoHuu = CBMaThe.Text;
            if (string.IsNullOrEmpty(maPhieu))
            {
                if (DataPhieuBanHang.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = DataPhieuBanHang.SelectedRows[0];
                    maPhieu = selectedRow.Cells["MaPhieu"].Value.ToString();
                    maThe = selectedRow.Cells["MaThe"].Value.ToString();
                    chuSoHuu = selectedRow.Cells["ChuSoHuu"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thông tin phiếu bán hàng cần xóa xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maPhieu))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa phiếu bán hàng {maPhieu} - {chuSoHuu}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BUS_PhieuBanHang bus = new BUS_PhieuBanHang();
                string kq = bus.DeletePhieuBanHang(maPhieu);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin phiếu bán hàng {maPhieu} - {chuSoHuu} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm(maThe);
                    LoadTheLuuDong();
                    LoadNhanVien();
                    LoadDanhSachPhieu("");

                    CBMaThe.SelectedValue = maThe;
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void butLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm("");
            LoadTheLuuDong();
            LoadNhanVien();
            LoadDanhSachPhieu("");
        }

        private void DataPhieuBanHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maPhieu = DataPhieuBanHang.Rows[e.RowIndex].Cells["MaPhieu"].Value.ToString();
            string maThe = DataPhieuBanHang.Rows[e.RowIndex].Cells["MaThe"].Value.ToString();
            string maNV = DataPhieuBanHang.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
            PhieuBanHang phieu = (PhieuBanHang)DataPhieuBanHang.CurrentRow.DataBoundItem;
            TheLuuDong the = new TheLuuDong();
            NhanVien nv = new NhanVien();
            foreach (TheLuuDong item in CBMaThe.Items)
            {
                if (item.MaThe == maThe)
                {
                    the = item;
                    break;
                }
            }

            foreach (NhanVien item in CBNhanVien.Items)
            {
                if (item.MaNhanVien == maNV)
                {
                    nv = item;
                    break;
                }
            }
            frmChiTietPhieu frmChiTiet = new frmChiTietPhieu(the, phieu, nv);
            frmChiTiet.ShowDialog();
        }

        private void DataPhieuBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isLoadingTheLuuDongData = true;
            DataGridViewRow row = DataPhieuBanHang.Rows[e.RowIndex];
            CBMaThe.SelectedValue = row.Cells["MaThe"].Value.ToString();
            CBNhanVien.SelectedValue = row.Cells["MaNhanVien"].Value.ToString();
            TPNgayTao.Text = row.Cells["NgayTao"].Value.ToString();
            txtMaPhieu.Text = row.Cells["MaPhieu"].Value.ToString();

            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            if (trangThai)
            {
                rbutDaThanhToan.Checked = true;
                rbutDaThanhToan.Enabled = false;
                rbutChoXacNhan.Enabled = false;
                CBNhanVien.Enabled = false;
                TPNgayTao.Enabled = false;
                butThem.Enabled = false;
                butSua.Enabled = false;
                butXoa.Enabled = false;

            }
            else
            {
                rbutDaThanhToan.Checked = false;
                rbutDaThanhToan.Enabled = true;
                rbutChoXacNhan.Enabled = true;
                CBNhanVien.Enabled = true;
                rbutChoXacNhan.Checked = true;
                rbutChoXacNhan.Enabled = true;
                TPNgayTao.Enabled = true;
                // Bật nút "Sửa"
                butThem.Enabled = false;
                butSua.Enabled = true;
                butXoa.Enabled = true;
            }

        }
    }
}
