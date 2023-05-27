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
    public partial class nhapHangCapNhatChiTiet : Form
    {
        BLLNhapHang bLLNhapHang = new BLLNhapHang();
        DTOChiTietNhapHang dTOChiTietNhapHang = null;

        private string maNhapHang;
        private string maSanPham;
        private int soLuong;

        public nhapHangCapNhatChiTiet(string maNhapHang, string maSanPham, int soLuong)
        {
            InitializeComponent();
            this.maNhapHang = maNhapHang;
            this.maSanPham = maSanPham;
            this.soLuong = soLuong;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dTOChiTietNhapHang = new DTOChiTietNhapHang(txtMaNhapHang.Text, maSanPham, txtMaSanPham.Text, int.Parse(txtSoLuong.Text));

            if (bLLNhapHang.UpdateChiTietNhapHang(dTOChiTietNhapHang))
            {
                MessageBox.Show("Bạn đã cập nhật chi tiết nhập hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin chi tiết nhập hàng thất bại, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nhapHangCapNhatChiTiet_Load(object sender, EventArgs e)
        {
            txtMaNhapHang.Text = maNhapHang;
            txtMaSanPham.Text = maSanPham;
            txtSoLuong.Text = soLuong.ToString();
        }
    }
}
