using System;
using System.Windows.Forms;

namespace kthp
{
    public partial class khachHangCapNhat : Form
    {
        khachHang khachHang = new khachHang();

        private string maKhachHang;
        private string tenKhachHang;
        private string gioiTinh;
        private string soDienThoai;
        private string diaChi;

        public khachHangCapNhat(string maKhachHang, string tenKhachHang, string gioiTinh, string soDienThoai, string diaChi)
        {
            InitializeComponent();
            this.maKhachHang = maKhachHang;
            this.tenKhachHang = tenKhachHang;
            this.gioiTinh = gioiTinh;
            this.soDienThoai = soDienThoai;
            this.diaChi = diaChi;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (khachHang.UpdateKhachHang(txtMaKhachHang.Text, txtTenKhachHang.Text, txtGioiTinh.Text, txtSoDienThoai.Text, txtDiaChi.Text))
            {
                MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void khachHangCapNhat_Load(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = maKhachHang;
            txtTenKhachHang.Text = tenKhachHang;
            txtGioiTinh.Text = gioiTinh;
            txtSoDienThoai.Text = soDienThoai;
            txtDiaChi.Text = diaChi;
        }
    }
}
