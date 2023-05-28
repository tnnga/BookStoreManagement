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
        private string tenDangNhap;
        public chiTietTaiKhoan()
        {
            InitializeComponent();
        }

        private void chiTietTaiKhoan_Load(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            tenDangNhap = frmDangNhap.tenDangNhap;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != "")
            {
                dTOTaiKhoan = new DTOTaiKhoan(tenDangNhap, txtMatKhau.Text, "", "", "", "", "", "");
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
    }
}
