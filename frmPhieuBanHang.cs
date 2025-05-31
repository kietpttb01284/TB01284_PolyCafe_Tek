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
        public frmPhieuBanHang()
        {
            InitializeComponent();
        }
        private void ClearForm(string msThe)
        {
            butThem.Enabled = true;
            butSua.Enabled = false;
            butXoa.Enabled = true;
            butLamMoi.Enabled = true;
            txtMaPhieu.Clear();
            txtMaThe.Clear();
            txtMaNhanVien.Clear();
            txtMaKhachHang.Clear();
            rbutChoXacNhan.Checked = true;
            TPNgayTao.Enabled = true;
            TPNgayTao.Value = DateTime.Now;
        }
        //private void LoadNhanVien()
        //{
        //    try
        //    {
        //        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        //        List<NhanVien> dsLoai = busNhanVien.GetDSNhanVien();
        //        if (AuthUntil.user.VaiTro)
        //        {
        //            dsLoai.Insert(0, new NhanVien() { MaNhanVien = string.Empty, TenNhanVien = string.Format("--Vui lòng chọn nhân viên--") });
        //        }
        //        else
        //        {
        //            dsLoai = dsLoai.Where(x => x.MaNhanVien == AuthUntil.user.MaNhanVien).ToList();
        //            cboNhanVienBH.Enabled = false;
        //        }
        //        cboNhanVienBH.DataSource = dsLoai;
        //        cboNhanVienBH.ValueMember = "MaNhanVien";
        //        cboNhanVienBH.DisplayMember = "HoTen";
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void DataPhieuBanHang_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butThem_Click(object sender, EventArgs e)
        {

        }
    }
}
