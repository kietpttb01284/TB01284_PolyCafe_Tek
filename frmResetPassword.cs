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
using Util_Polycafe;

namespace TB01284_PolyCafe
{
    public partial class frmResetPassword : Form
    {
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        public frmResetPassword()
        {
            InitializeComponent();
        }

        private void rbut_HTMatKhauCu_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_MatKhauCu.PasswordChar == '*')
            {
                txt_MatKhauCu.PasswordChar = '\0';
            }
        }

        private void rbut_HTMatKhauMoi_CheckedChanged(object sender, EventArgs e)
        {
            txt_MatKhauMoi.PasswordChar = rbut_HTMatKhauMoi.Checked ? '\0' : '*';
        }

        private void rbut_HTXacNhanMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txt_XacNhanMatKhau.PasswordChar = rbut_HTXacNhanMatKhau.Checked ? '\0' : '*';
        }

        private void but_DoiMatKhau_Click(object sender, EventArgs e)
        {
            if (!AuthUntil.user.MatKhau.Equals(txt_MatKhauCu.Text))
            {
                MessageBox.Show(this, "Mật khẩu cũ chưa đúng!!!");
            }
            else
            {
                if (!txt_MatKhauMoi.Text.Equals(txt_XacNhanMatKhau.Text))
                {
                    MessageBox.Show(this, "Xác nhận mật khẩu mới chưa trùng khớp!!!");
                }
                else
                {
                    AuthUntil.user.MatKhau = txt_MatKhauMoi.Text;

                    if (busNhanVien.ResetMatKhau(AuthUntil.user.Email, txt_MatKhauMoi.Text))
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công!!!");
                    }
                    else MessageBox.Show("Đổi mật khẩu thất bại, vui lòng kiểm tra lại!!!");
                }
            }
        }

        private void but_ThoatDoiMatKhau_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmResetPassword_Load(object sender, EventArgs e)
        {
            if (AuthUntil.IsLogin())
            {
                txt_TenTaKhoanDoiMatKhau.Text = AuthUntil.user.TenNhanVien;
                txt_MatKhauCu.Text = AuthUntil.user.MatKhau;
            }
        }
    }
}
