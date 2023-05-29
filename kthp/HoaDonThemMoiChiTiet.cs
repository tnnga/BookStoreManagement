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
    public partial class HoaDonThemMoiChiTiet : Form
    {
        BLLSanPham bLLSanPham = new BLLSanPham();
        BLLHoaDon bLLHoaDon = new BLLHoaDon();
        DTOChiTietHoaDon dTOChiTietHoaDon = null;
        DTOSanPham dTOSanPham = null;
        private string maHoaDon;
        public int tongDonGia;

        public void UpdateSoLuongTonSanPham()
        {
            dTOChiTietHoaDon = new DTOChiTietHoaDon("", "", txtMaSanPham.Text, int.Parse(txtSoLuong.Text));
            bLLSanPham.UpdateGiamSoLuongSanPham(dTOChiTietHoaDon);
        }

        public HoaDonThemMoiChiTiet(string maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {         
            if (txtMaSanPham.Text != "" && txtSoLuong.Text != "")
            {
                dTOSanPham = new DTOSanPham(txtMaSanPham.Text, "", 0, 0, "", "");
                
                if (bLLSanPham.CheckSoLuongSanPhamConHang(dTOSanPham))
                {
                    dTOChiTietHoaDon = new DTOChiTietHoaDon(maHoaDon, "", txtMaSanPham.Text, int.Parse(txtSoLuong.Text));

                    if (bLLHoaDon.InsertChiTietHoaDon(dTOChiTietHoaDon))
                    {
                        UpdateSoLuongTonSanPham();

                        MessageBox.Show("Bạn đã thêm thông tin chi tiết hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin chi tiết hóa đơn thất bại, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                       
                }          
                else
                {
                    MessageBox.Show("Hết sản phẩm, không thể thêm vào hoá đơn!\nVui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin chi tiết hoá đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void HoaDonThemMoiChiTiet_Load(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = maHoaDon;
        }
    }
}
