using System;
using System.Windows.Forms;

namespace kthp
{
    public partial class trangChu : Form
    {
        public trangChu()
        {
            InitializeComponent();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            chiTietTaiKhoan chiTietTaiKhoan = new chiTietTaiKhoan();
            chiTietTaiKhoan.Show();
        }
    }
}
