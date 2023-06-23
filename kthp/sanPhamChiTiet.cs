using System;
using System.Windows.Forms;

namespace kthp
{
    public partial class frmSanPhamChiTiet : Form
    {
        private string maSach;
        private string tenSach;
        private int giaTien;
        private int soLuong;
        private string loaiSach;
        private string noiDungChinh;

        public frmSanPhamChiTiet(string maSach, string tenSach, int giaTien, int soLuong, string loaiSach, string noiDungChinh)
        {
            InitializeComponent();
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.giaTien = giaTien;
            this.soLuong = soLuong;
            this.loaiSach = loaiSach;
            this.noiDungChinh = noiDungChinh;
        }

        private void frmSanPhamChiTiet_Load(object sender, EventArgs e)
        {
            lblTenSach.Text = tenSach;
            lblGiaSach.Text = giaTien.ToString();
            lblSoLuongTon.Text = soLuong.ToString();
            lblLoaiSach.Text = loaiSach;
            lblTomTatNoiDung.Text = noiDungChinh;
        }
    }
}
