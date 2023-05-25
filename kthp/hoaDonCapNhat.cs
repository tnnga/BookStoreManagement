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
    public partial class hoaDonCapNhat : Form
    {
        BLLHoaDon bLLHoaDon = new BLLHoaDon();
        DTOHoaDon dTOHoaDon = null;

        private string maHoaDon;
        private string tenKhachHang;
        private string ngayHoaDon;
        private string gioHoaDon;
        private int donGia;

        public hoaDonCapNhat(string maHoaDon, string tenKhachHang, string ngayHoaDon, string gioHoaDon, int donGia)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
            this.tenKhachHang = tenKhachHang;
            this.ngayHoaDon = ngayHoaDon;
            this.gioHoaDon = gioHoaDon;
            this.donGia = donGia;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            dTOHoaDon = new DTOHoaDon(txtMaHoaDon.Text, txtTenKhachHang.Text, txtNgayHoaDon.Text, txtGioHoaDon.Text, int.Parse(txtDonGia.Text));

            if (bLLHoaDon.UpdateHoaDon(dTOHoaDon))
            {
                hoaDonCapNhatChiTiet hoaDonCapNhatChiTiet = new hoaDonCapNhatChiTiet(maHoaDon);
                hoaDonCapNhatChiTiet.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void hoaDonCapNhat_Load(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = maHoaDon;
            txtTenKhachHang.Text = tenKhachHang;
            txtNgayHoaDon.Text = ngayHoaDon;
            txtGioHoaDon.Text = gioHoaDon;
            txtDonGia.Text = donGia.ToString();
        }
    }
}
