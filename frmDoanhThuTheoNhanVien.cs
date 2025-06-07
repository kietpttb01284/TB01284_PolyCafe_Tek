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
    public partial class frmDoanhThuTheoNhanVien : Form
    {
        public frmDoanhThuTheoNhanVien()
        {
            InitializeComponent();
        }

        private void frmDoanhThuTheoNhanVien_Load(object sender, EventArgs e)
        {
            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            // Gán giá trị cho DateTimePicker
            TPTuNgay.Value = firstDayOfMonth;
            LoadNhanVien();

            butThongKe_Click(sender, e);
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

                string maNV = CBNhanVien.SelectedValue?.ToString() ?? string.Empty;
                DateTime bd = TPTuNgay.Value.Date;
                DateTime kt = TPDenNgay.Value.Date;

                BUS_ThongKe busThongKe = new BUS_ThongKe();
                List<DoanhThuNV> result = busThongKe.getThongKeNhanVien(maNV, bd, kt);

                if (result == null || result.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu thống kê trong khoảng thời gian này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DataDoanhThuNhanVien.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadNhanVien()
        {
            try
            {
                BUS_NhanVien busNhanVien = new BUS_NhanVien();
                List<NhanVien> dsNhanVien = busNhanVien.GetDSNhanVien();
                dsNhanVien.Insert(0, new NhanVien()
                {
                    MaNhanVien = string.Empty,
                    TenNhanVien = "--Tất Cả--"
                });

                CBNhanVien.DataSource = dsNhanVien;
                CBNhanVien.ValueMember = "MaNhanVien";
                CBNhanVien.DisplayMember = "TenNhanVien";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
