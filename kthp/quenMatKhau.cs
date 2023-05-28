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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace kthp
{
    public partial class frmQuenMatKhau : Form
    {
        DTOTaiKhoan dTOTaiKhoan = null;
        BLLTaiKhoan bLLTaiKhoan = new BLLTaiKhoan();
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            dTOTaiKhoan = new DTOTaiKhoan(txtTenDangNhap.Text, "", "", "", "", "", txtEmail.Text, "");
            if (bLLTaiKhoan.DoiMatKhau(dTOTaiKhoan))
            {
                MessageBox.Show("Thông tin trùng khớp, vui lòng nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Thông tin không trùng khớp, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMatKhau1.Text == txtMatKhau2.Text)
            {
                dTOTaiKhoan = new DTOTaiKhoan(txtTenDangNhap.Text, txtMatKhau1.Text, "", "", "", "", "","");
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
                MessageBox.Show("Mật khẩu không trùng khớp, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
