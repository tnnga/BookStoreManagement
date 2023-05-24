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
    public partial class frmNhapLaiMatKhau : Form
    {
        public string matKhauMoi;

        public frmNhapLaiMatKhau()
        {
            InitializeComponent();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMatKhau1.Text == "" || txtMatKhau2.Text == "")
            {
                DialogResult result = MessageBox.Show("Đổi mật khẩu không thành công, vui lòng điền đủ thông tin!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                if (txtMatKhau1.Text == txtMatKhau2.Text)
                {
                    matKhauMoi = txtMatKhau1.Text;
                    DialogResult result = MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Mật khẩu không trùng lặp, vui lòng nhập lại!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
    }
}
