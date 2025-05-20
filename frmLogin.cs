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
    public partial class frmLogin : Form
    {
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void butDangNhap_Click(object sender, EventArgs e)
        {
            //string nguoidung = txtTenDangNhap.Text;
            //string matkhau = txtMatKhau.Text;

            NhanVien nv = busNhanVien.DangNhap("hoa.nguyen@cafe.com", "password1");
            if (nv == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }
            else if (nv.TrangThai == false)
            {
                MessageBox.Show("Tài khoản đang tạm khóa");
                return;
            }

            frmLogin main = new frmLogin();
            main.Show();
            this.Hide();
        }

        private void butThoat_Click(object sender, EventArgs e)
        {

        }

        private void rbut_HienThi_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = rbut_HienThi.Checked ? '\0' : '*';
        }
    }
}
