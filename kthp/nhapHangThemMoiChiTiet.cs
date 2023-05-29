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
    public partial class nhapHangThemMoiChiTiet : Form
    {
        BLLSanPham bLLSanPham = new BLLSanPham();
        BLLNhapHang bLLNhapHang = new BLLNhapHang();
        DTOChiTietNhapHang dTOChiTietNhapHang = null;
        private string maNhapHang;

        public void UpdateSoLuongTonSanPham()
        {
            dTOChiTietNhapHang = new DTOChiTietNhapHang("", "", txtMaSanPham.Text, int.Parse(txtSoLuong.Text));
            bLLSanPham.UpdateTangSoLuongSanPham(dTOChiTietNhapHang);
        }

        public nhapHangThemMoiChiTiet(string maNhapHang)
        {
            InitializeComponent();
            this.maNhapHang = maNhapHang;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSanPham.Text != "" && txtSoLuong.Text != "")
            {
                dTOChiTietNhapHang = new DTOChiTietNhapHang(maNhapHang, "", txtMaSanPham.Text, int.Parse(txtSoLuong.Text));

                if (bLLNhapHang.InsertChiTietNhapHang(dTOChiTietNhapHang))
                {
                    UpdateSoLuongTonSanPham();

                    MessageBox.Show("Bạn đã thêm thông tin chi tiết nhập hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin chi tiết nhập hàng thất bại, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void nhapHangThemMoiChiTiet_Load(object sender, EventArgs e)
        {
            txtMaNhapHang.Text = maNhapHang;
        }
    }
}
