using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util_Polycafe;


namespace TB01284_PolyCafe
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
            KiemTraQuyen();

        }
        private Form currentFormChild;

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResetPassword reset = new frmResetPassword();
            reset.ShowDialog();
        }
        private void openChildForm(Form formChild)
        {
            try
            {
                if (currentFormChild != null)
                {
                    currentFormChild.Close();
                }
                currentFormChild = formChild;
                formChild.TopLevel = false;
                formChild.FormBorderStyle = FormBorderStyle.None;
                formChild.Dock = DockStyle.Fill;
                pnMain.Controls.Add(formChild);
                pnMain.Tag = formChild;
                formChild.BringToFront();
                formChild.Show();
                if (pnMain == null || pnMain.IsDisposed)
                {
                    Debug.WriteLine("Panel container không tồn tại!");
                    return;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Lỗi khi mở form: {ex.Message}");
                MessageBox.Show($"Lỗi khi mở form: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VaiTroNhanVien()
        {
            TSDanhMuc.Visible = false;
            TSNhanVien.Visible = false;
            TSDoanhThu.Visible = false;
        }

        public void KiemTraQuyen()
        {
            if (AuthUntil.IsLogin())
            {
                //toolStripUserName.Text = AuthUntil.user.TenNhanVien;
                TSDanhMuc.Visible = true;
                TSBanHang.Visible = true;
                TSNhanVien.Visible = true;
                TSDoanhThu.Visible = true;
                if (AuthUntil.user.VaiTro == false)
                {
                    VaiTroNhanVien();
                }
            }
            else
            {
                TSHeThong.Visible = true; // Xác định xem điều khiển có hiển thị trên giao diện hay không.
                TSDangXuat.Enabled = false; // Xác định xem điều khiển có thể tương tác hay không.
                TSThongTinTaiKhoan.Enabled = false;
                TSDanhMuc.Visible = false;
                TSBanHang.Visible = false;
                TSNhanVien.Visible = false;
                TSDoanhThu.Visible = false;
            }
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());
        }


        private void frmMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thẻLưuĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTheLuuDong());
        }

        private void TSBanHang_Click(object sender, EventArgs e)
        {

        }

        private void TSSanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSanPham());
        }

        private void phiếuBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhieuBanHang());
        }

        private void chiTiếtPhiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmChiTietPhieu());
        }
    }
}
