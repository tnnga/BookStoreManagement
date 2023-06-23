using BLLQLNS;
using DTOQLNS;
using System;
using System.Windows.Forms;


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

            if (bLLSanPham.UpdateSanPham(dTOSanPham))
            {
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
