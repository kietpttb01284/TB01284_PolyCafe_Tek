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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }

        public void getDSNhanVien() 
        {
            BUS_NhanVien bus = new BUS_NhanVien();
            DataNhanVien.DataSource = null;
            DataNhanVien.DataSource = bus.select();
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
                    HoTen = hoTen,
                    Email = email,
                    MatKhau = matKhau,
                    VaiTro = vaiTro,
                    TrangThai = true // Mặc định là active
                };

                // Gọi DAL để thêm nhân viên vào database
                BUS_NhanVien busNhanVien = new BUS_NhanVien();
                 busNhanVien.InsertNhanVien(nv);

                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới form sau khi thêm thành công
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
    }
}
