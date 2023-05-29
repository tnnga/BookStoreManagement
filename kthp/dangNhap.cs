using BLLQLNS;
using DTOQLNS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace kthp
{
    public partial class frmDangNhap : Form
    {
        DTOTaiKhoan dTOTaiKhoan = null;
        BLLTaiKhoan bLLTaiKhoan = new BLLTaiKhoan();
        public static string tenDangNhap;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "TÊN ĐĂNG NHẬP")
            {
                txtTenDangNhap.Text = null;
                txtTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Text = "TÊN ĐĂNG NHẬP";
                txtTenDangNhap.ForeColor = Color.DarkGray;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "MẬT KHẨU")
            {
                txtMatKhau.Text = null;
                txtMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "MẬT KHẨU";
                txtMatKhau.PasswordChar = '\0';
                txtMatKhau.ForeColor = Color.DarkGray;
            }
        }

        private void lblDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy dangKy = new frmDangKy();
            dangKy.ShowDialog();
        }

        private void lblDangKy_MouseEnter(object sender, EventArgs e)
        {
            lblDangKy.ForeColor = Color.LightSeaGreen;
            lblDangKy.Font = new Font(lblDangKy.Font.FontFamily, lblDangKy.Font.Size + 1, FontStyle.Bold);
            Cursor = Cursors.Hand;
        }

        private void lblDangKy_MouseLeave(object sender, EventArgs e)
        {
            lblDangKy.ForeColor = Color.White;
            lblDangKy.Font = new Font(lblDangKy.Font.FontFamily, lblDangKy.Font.Size - 1, FontStyle.Bold);
            Cursor = Cursors.Default;
        }

        private void btnDangNhap_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            btnDangNhap.Font = new Font(btnDangNhap.Font.FontFamily, btnDangNhap.Font.Size + 2, btnDangNhap.Font.Style);
            btnDangNhap.ForeColor = Color.Cyan;
        }

        private void btnDangNhap_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            btnDangNhap.Font = new Font(btnDangNhap.Font.FontFamily, btnDangNhap.Font.Size - 2, btnDangNhap.Font.Style);
            btnDangNhap.ForeColor = Color.White;
        }

        private void lblQuenMatKhau_Click(object sender, EventArgs e)
        {
            Form quenMatKhau = new frmQuenMatKhau();
            quenMatKhau.ShowDialog();
            
        }
        private void lblQuenMatKhau_MouseEnter(object sender, EventArgs e)
        {
            lblQuenMatKhau.ForeColor = Color.LightSeaGreen;
            lblQuenMatKhau.Font = new Font(lblQuenMatKhau.Font.FontFamily, lblQuenMatKhau.Font.Size + 1, FontStyle.Bold);
            Cursor = Cursors.Hand;
        }

        private void lblQuenMatKhau_MouseLeave(object sender, EventArgs e)
        {
            lblQuenMatKhau.ForeColor = Color.White;
            lblQuenMatKhau.Font = new Font(lblQuenMatKhau.Font.FontFamily, lblQuenMatKhau.Font.Size - 1, FontStyle.Bold);
            Cursor = Cursors.Default;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            dTOTaiKhoan = new DTOTaiKhoan(txtTenDangNhap.Text, txtMatKhau.Text, "", "", "", "", "", "");
            if (bLLTaiKhoan.LoginTaiKhoan(dTOTaiKhoan))
            {
                tenDangNhap = txtTenDangNhap.Text;
                frmManHinhChinh mHC = new frmManHinhChinh(tenDangNhap);
                chiTietTaiKhoan cTTK = new chiTietTaiKhoan(tenDangNhap);

                frmManHinhChinh frmManHinhChinh = new frmManHinhChinh();
                frmManHinhChinh.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, vui lòng kiểm tra lại");
            }
        }

        private void chkAnHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnHienMatKhau.Checked == true)
                txtMatKhau.PasswordChar = '\0';
            else
                txtMatKhau.PasswordChar = '*';
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }
    }
}
