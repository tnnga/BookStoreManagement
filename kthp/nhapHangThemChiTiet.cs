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
    public partial class frmNhapHangThemChiTiet : Form
    {
        BLLNhapHang bLLNhapHang = new BLLNhapHang();
        DTOChiTietNhapHang dTOChiTietNhapHang = null;
        public string maNhapHang;
        public frmNhapHangThemChiTiet(string maNhapHang)
        {
            this.maNhapHang = maNhapHang;
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(txtTenSanPham) == "" &&
                errorProvider1.GetError(txtSoLuong) == "" &&
                txtTenSanPham.Text != "" &&
                txtSoLuong.Text != "")
            {
                if (txtTenSanPham1.Text != "" && txtSoLuong1.Text != "")
                {
                    dTOChiTietNhapHang = new DTOChiTietNhapHang(maNhapHang, txtTenSanPham1.Text, int.Parse(txtSoLuong1.Text));
                    bLLNhapHang.InsertChiTietNhapHang(dTOChiTietNhapHang);
                }
                if (txtTenSanPham2.Text != "" && txtSoLuong2.Text != "")
                {
                    dTOChiTietNhapHang = new DTOChiTietNhapHang(maNhapHang, txtTenSanPham2.Text, int.Parse(txtSoLuong2.Text));
                    bLLNhapHang.InsertChiTietNhapHang(dTOChiTietNhapHang);
                }
                if (txtTenSanPham3.Text != "" && txtSoLuong3.Text != "")
                {
                    dTOChiTietNhapHang = new DTOChiTietNhapHang(maNhapHang, txtTenSanPham3.Text, int.Parse(txtSoLuong3.Text));
                    bLLNhapHang.InsertChiTietNhapHang(dTOChiTietNhapHang);
                }
                dTOChiTietNhapHang = new DTOChiTietNhapHang(maNhapHang, txtTenSanPham.Text, int.Parse(txtSoLuong.Text));
                if (bLLNhapHang.InsertChiTietNhapHang(dTOChiTietNhapHang))
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

        private void txtTenSanPham_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
            {
                errorProvider1.SetError(txtTenSanPham, "Vui lòng nhập thông tin!");
                txtTenSanPham.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
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
