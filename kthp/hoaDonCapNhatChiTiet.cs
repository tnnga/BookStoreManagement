using BLLQLNS;
using DTOQLNS;
using System;
using System.Windows.Forms;

namespace kthp
{
    public partial class hoaDonCapNhatChiTiet : Form
    {
        BLLHoaDon bLLHoaDon = new BLLHoaDon();
        DTOChiTietHoaDon dTOChiTietHoaDon = null;

        private string maHoaDon;
        private string maSanPham;
        private int soLuong;

        public hoaDonCapNhatChiTiet(string maHoaDon, string maSanPham, int soLuong)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
            this.maSanPham = maSanPham;
            this.soLuong = soLuong;
        }

        private void hoaDonCapNhatChiTiet_Load(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = maHoaDon;
            txtMaSanPham.Text = maSanPham;
            txtSoLuong.Text = soLuong.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            dTOChiTietHoaDon = new DTOChiTietHoaDon(txtMaHoaDon.Text, maSanPham, txtMaSanPham.Text, int.Parse(txtSoLuong.Text));

            if (bLLHoaDon.UpdateChiTietHoaDon(dTOChiTietHoaDon))
            {
                MessageBox.Show("Bạn đã cập nhật chi tiết hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin chi tiết hóa đơn thất bại, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
