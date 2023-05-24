using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLQLNS;
using DTOQLNS;


namespace kthp
{
    public partial class frmSanPhamCapNhat : Form
    {
        private string maSach;
        private string tenSach;
        private int giaTien;
        private int soLuong;
        private string loaiSach;
        private string noiDungChinh;

        BLLSanPham bLLSanPham = new BLLSanPham();
        DTOSanPham dTOSanPham = null;
        
        public frmSanPhamCapNhat(string maSach, string tenSach, int giaTien, int soLuong, string loaiSach, string noiDungChinh)
        {
            InitializeComponent();
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.giaTien = giaTien;
            this.soLuong = soLuong;
            this.loaiSach = loaiSach;
            this.noiDungChinh = noiDungChinh;
        }

        private void frmSanPhamCapNhat_Load(object sender, EventArgs e)
        {
            txtMaSach.Text = maSach;
            txtTenSach.Text = tenSach;
            txtGiaTien.Text = giaTien.ToString();
            txtSoLuong.Text = soLuong.ToString();
            txtLoaiSach.Text = loaiSach;
            txtNoiDungChinh.Text = noiDungChinh;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            dTOSanPham = new DTOSanPham(txtMaSach.Text, txtTenSach.Text, int.Parse(txtSoLuong.Text), int.Parse(txtGiaTien.Text), txtLoaiSach.Text, txtNoiDungChinh.Text);
            bLLSanPham.UpdateSanPham(dTOSanPham);

            if (bLLSanPham.UpdateSanPham(dTOSanPham) == true)
            {
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
