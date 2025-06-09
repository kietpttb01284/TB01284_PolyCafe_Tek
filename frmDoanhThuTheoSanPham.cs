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
    public partial class frmDoanhThuTheoSanPham : Form
    {
        public frmDoanhThuTheoSanPham()
        {
            InitializeComponent();
        }

        private void butThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                if (TPTuNgay.Value.Date > TPDenNgay.Value.Date)
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string maLoai = CBLoaiSanPham.SelectedValue?.ToString() ?? string.Empty;
                DateTime bd = TPTuNgay.Value.Date;
                DateTime kt = TPDenNgay.Value.Date;

                BUS_ThongKe busThongKe = new BUS_ThongKe();
                List<DoanhThuSP> result = busThongKe.getThongKeLoaiSP(maLoai, bd, kt);

                if (result == null || result.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu thống kê trong khoảng thời gian này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DataDoanhThuSanPham.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDoanhThuTheoSanPham_Load(object sender, EventArgs e)
        {
            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            // Gán giá trị cho DateTimePicker
            TPTuNgay.Value = firstDayOfMonth;

            LoadLoaiSanPham();
            butThongKe_Click(sender, e);
        }

        private void LoadLoaiSanPham()
        {
            try
            {
                BUS_LoaiSanPham bUSLoaiSanPham = new BUS_LoaiSanPham();
                List<LoaiSanPham> dsLoai = bUSLoaiSanPham.GetLoaiSanPhamList();

                dsLoai.Insert(0, new LoaiSanPham() { MaLoai = string.Empty, TenLoai = "--Tất Cả--" });

                CBLoaiSanPham.DataSource = dsLoai;
                CBLoaiSanPham.ValueMember = "MaLoai";
                CBLoaiSanPham.DisplayMember = "TenLoai";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
