using BLLQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kthp
{
    public partial class nhapHangCapNhat : Form
    {
        BLLNhapHang bLLNhapHang = new BLLNhapHang();
        DTONhapHang dTONhapHang = null;

        private string maNhapHang;
        private string tenNhanVien;
        private string ngayNhap;
        private string gioNhap;
        private int donGia;

        public nhapHangCapNhat(string naNhapHang, string tenNhanVien, string ngayNhap, string gioNhap, int donGia)
        {
            InitializeComponent();
            this.maNhapHang = naNhapHang;
            this.tenNhanVien = tenNhanVien;
            this.ngayNhap = ngayNhap;
            this.gioNhap = gioNhap;
            this.donGia = donGia;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            dTONhapHang = new DTONhapHang(txtMaNhapHang.Text, txtTenNhanVien.Text, txtNgayNhap.Text, txtGioNhap.Text, int.Parse(txtDonGia.Text));

            if (bLLNhapHang.UpdateNhapHang(dTONhapHang))
            {
                nhapHangCapNhatChiTiet nhapHangCapNhatChiTiet = new nhapHangCapNhatChiTiet(maNhapHang);
                nhapHangCapNhatChiTiet.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nhapHangCapNhat_Load(object sender, EventArgs e)
        {
            txtMaNhapHang.Text = maNhapHang;
            txtTenNhanVien.Text = tenNhanVien;
            txtNgayNhap.Text = ngayNhap;
            txtGioNhap.Text = gioNhap;
            txtDonGia.Text = donGia.ToString();
        }
    }
}
