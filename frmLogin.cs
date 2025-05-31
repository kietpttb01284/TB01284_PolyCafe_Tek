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
    public partial class frmLogin : Form
    {
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void butDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;
            //NhanVien nv = busNhanVien.DangNhap(username, password);
            NhanVien nv = busNhanVien.DangNhap("hoa.nguyen@cafe.com", "password1");
            if (nv == null)
            {
                MessageBox.Show(this, "Tài khoản hoặc mật khẩu không chính xác");
            }
            else
            {
                if (nv.TrangThai == false)
                {
                    MessageBox.Show(this, "Tài khoản đang tạm khóa, vui lòng viên hệ QTV!!!");
                    return;
                }
                AuthUntil.user = nv;

                frmMainForm main = new frmMainForm();
                main.Show();
                this.Hide();
            }
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát khỏi chương trình", "Thoát",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question
                           );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void rbut_HienThi_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = rbut_HienThi.Checked ? '\0' : '*';
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void butDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmResetPassword reset = new frmResetPassword();
            reset.ShowDialog();
        }
    }
}
