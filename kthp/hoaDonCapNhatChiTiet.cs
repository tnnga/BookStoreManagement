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
    public partial class hoaDonCapNhatChiTiet : Form
    {
        BLLHoaDon bLLHoaDon = new BLLHoaDon();
        DTOChiTietHoaDon dTOChiTietHoaDon = null;
        private string maHoaDon;

        public hoaDonCapNhatChiTiet(string maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
        }

        private void hoaDonCapNhatChiTiet_Load(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = maHoaDon;
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            dTOChiTietHoaDon = new DTOChiTietHoaDon(maHoaDon, "", 0);

            if (bLLHoaDon.DeleteChiTietHoaDon(dTOChiTietHoaDon))
            {
                if (errorProvider1.GetError(txtTenSanPham) == "" &&
                errorProvider1.GetError(txtSoLuong) == "" &&
                txtTenSanPham.Text != "" &&
                txtSoLuong.Text != "")
                {
                    if (txtTenSanPham1.Text != "" && txtSoLuong1.Text != "")
                    {
                        dTOChiTietHoaDon = new DTOChiTietHoaDon(maHoaDon, txtTenSanPham1.Text, int.Parse(txtSoLuong1.Text));
                        bLLHoaDon.InsertChiTietHoaDon(dTOChiTietHoaDon);
                    }
                    if (txtTenSanPham2.Text != "" && txtSoLuong2.Text != "")
                    {
                        dTOChiTietHoaDon = new DTOChiTietHoaDon(maHoaDon, txtTenSanPham2.Text, int.Parse(txtSoLuong2.Text));
                        bLLHoaDon.InsertChiTietHoaDon(dTOChiTietHoaDon);
                    }
                    if (txtTenSanPham3.Text != "" && txtSoLuong3.Text != "")
                    {
                        dTOChiTietHoaDon = new DTOChiTietHoaDon(maHoaDon, txtTenSanPham3.Text, int.Parse(txtSoLuong3.Text));
                        bLLHoaDon.InsertChiTietHoaDon(dTOChiTietHoaDon);
                    }
                    dTOChiTietHoaDon = new DTOChiTietHoaDon(maHoaDon, txtTenSanPham.Text, int.Parse(txtSoLuong.Text));
                    if (bLLHoaDon.InsertChiTietHoaDon(dTOChiTietHoaDon))
                    {
                        MessageBox.Show("Bạn đã cập nhật thông tin hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                        MessageBox.Show("Cập nhật không thành công, vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Vui lòng nhập đủ thông tin cần thiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
