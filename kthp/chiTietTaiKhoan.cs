using BLLQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kthp
{
    public partial class chiTietTaiKhoan : Form
    {
        DTOTaiKhoan dTOTaiKhoan = null;
        BLLTaiKhoan bLLTaiKhoan = new BLLTaiKhoan();
        public static string _TenDangNhap;

        public chiTietTaiKhoan()
        {
            InitializeComponent();
        }

        public chiTietTaiKhoan(string tenDangNhap)
        {
            InitializeComponent();
            _TenDangNhap = tenDangNhap;
        }

        private void chiTietTaiKhoan_Load(object sender, EventArgs e)
        {
            dTOTaiKhoan = new DTOTaiKhoan(_TenDangNhap, "", "", "", "", "", "", "");
            dgwTaiKhoan.DataSource = bLLTaiKhoan.SelectTaiKhoan(dTOTaiKhoan);

            txtHoTen.Text = dgwTaiKhoan.Rows[0].Cells[2].Value.ToString().Trim();
            cboGioiTinh.Text = dgwTaiKhoan.Rows[0].Cells[3].Value.ToString().Trim();
            mtbNgaySinh.Text = dgwTaiKhoan.Rows[0].Cells[4].Value.ToString().Trim();
            mtbSoDienThoai.Text = dgwTaiKhoan.Rows[0].Cells[5].Value.ToString().Trim();
            txtEmail.Text = dgwTaiKhoan.Rows[0].Cells[6].Value.ToString().Trim();
            txtDiaChi.Text = dgwTaiKhoan.Rows[0].Cells[7].Value.ToString().Trim();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != "")
            {
                dTOTaiKhoan = new DTOTaiKhoan(_TenDangNhap, txtMatKhau.Text, "", "", "", "", "", "");
                if (bLLTaiKhoan.UpdateTaiKhoan(dTOTaiKhoan))
                {
                    MessageBox.Show("Cập nhật mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Thất bại, mật khẩu chưa được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhatTaiKhoan_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            _TenDangNhap = frmDangNhap.tenDangNhap;

            dTOTaiKhoan = new DTOTaiKhoan(_TenDangNhap, "", "", "", "", "", "", "");
            if (bLLTaiKhoan.UpdateTaiKhoan(dTOTaiKhoan))
            {
                MessageBox.Show("Cập nhật thông tin tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thành công!\nVui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
