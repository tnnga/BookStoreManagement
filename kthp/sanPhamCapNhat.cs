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

        BLLSanPham bLLSanPham = new BLLSanPham();
        DTOSanPham dTOSanPham = null;
        
        public frmSanPhamCapNhat(string maSach, string tenSach, int giaTien, int soLuong)
        {
            InitializeComponent();
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.giaTien = giaTien;
            this.soLuong = soLuong;
        }

        private void frmSanPhamCapNhat_Load(object sender, EventArgs e)
        {
            txtMaSach.Text = maSach;
            txtTenSach.Text = tenSach;
            txtGiaTien.Text = giaTien.ToString();
            txtSoLuong.Text = soLuong.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text != null && txtSoLuong.Text != null && txtGiaTien.Text != null)
            {
                dTOSanPham = new DTOSanPham(txtMaSach.Text, txtTenSach.Text, int.Parse(txtSoLuong.Text), int.Parse(txtGiaTien.Text));

                if (bLLSanPham.UpdateSanPham(dTOSanPham))
                {
                    MessageBox.Show("Hợp lệ! Thực hiện thành công cập nhật thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không hợp lệ! Thực hiện không thành công cập nhật thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không hợp lệ!\nVui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
