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
    public partial class frmSanPhamCapNhat : Form
    {
        private string maSach;
        private string tenSach;
        private int soLuong;
        private int giaTien;

        public frmSanPhamCapNhat(string maSach, string tenSach, int soLuong, int giaTien)
        {
            InitializeComponent();
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.soLuong = soLuong;
            this.giaTien = giaTien;
        }

        private void frmSanPhamCapNhat_Load(object sender, EventArgs e)
        {
            txtMaSach.Text = maSach;
            txtTenSach.Text = tenSach;
            txtSoLuong.Text = soLuong.ToString();
            txtGiaTien.Text = giaTien.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text != null && txtSoLuong.Text != null && txtGiaTien.Text != null)
            {
                dcKTHPDataContext data = new dcKTHPDataContext();
                SanPham sp = (from sanpham in data.SanPhams
                              where sanpham.MaSach == txtMaSach.Text.Trim()
                              select sanpham).Single<SanPham>();

                sp.MaSach = txtMaSach.Text;
                sp.TenSach = txtTenSach.Text;
                sp.SoLuongTon = int.Parse(txtSoLuong.Text);
                sp.GiaTien = int.Parse(txtGiaTien.Text);

                data.SubmitChanges();

                MessageBox.Show("Hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không hợp lệ!\nVui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
