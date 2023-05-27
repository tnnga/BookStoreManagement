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
    public partial class frmHoaDonThemChiTiet : Form
    {
        BLLHoaDon bLLHoaDon = new BLLHoaDon();
        DTOChiTietHoaDon dTOChiTietHoaDon = null;
        public string maHoaDon;
        public frmHoaDonThemChiTiet(string maHoaDon)
        {
            this.maHoaDon = maHoaDon;
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(txtMaSanPham) == "" &&
                errorProvider1.GetError(txtSoLuong) == "" &&
                txtMaSanPham.Text != "" &&
                txtSoLuong.Text != "")
            {
                if(txtMaSanPham1.Text != "" && txtSoLuong1.Text != "")
                {
                    dTOChiTietHoaDon = new DTOChiTietHoaDon(maHoaDon, txtMaSanPham1.Text, int.Parse(txtSoLuong1.Text));
                    bLLHoaDon.InsertChiTietHoaDon(dTOChiTietHoaDon);
                }
                if (txtMaSanPham2.Text != "" && txtSoLuong2.Text != "")
                {
                    dTOChiTietHoaDon = new DTOChiTietHoaDon(maHoaDon, txtMaSanPham2.Text, int.Parse(txtSoLuong2.Text));
                    bLLHoaDon.InsertChiTietHoaDon(dTOChiTietHoaDon);
                }
                if (txtMaSanPham3.Text != "" && txtSoLuong3.Text != "")
                {
                    dTOChiTietHoaDon = new DTOChiTietHoaDon(maHoaDon, txtMaSanPham3.Text, int.Parse(txtSoLuong3.Text));
                    bLLHoaDon.InsertChiTietHoaDon(dTOChiTietHoaDon);
                }
                dTOChiTietHoaDon = new DTOChiTietHoaDon(maHoaDon, txtMaSanPham.Text, int.Parse(txtSoLuong.Text));
                if (bLLHoaDon.InsertChiTietHoaDon(dTOChiTietHoaDon))
                {
                    MessageBox.Show("Bạn đã thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Vui lòng nhập đủ thông tin cần thiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSanPham.Text))
            {
                errorProvider1.SetError(txtMaSanPham, "Vui lòng nhập thông tin!");
                txtMaSanPham.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                errorProvider1.SetError(txtSoLuong, "Vui lòng nhập thông tin!");
                txtSoLuong.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
