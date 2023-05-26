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
        BLLHoaDon bLLHoaDon = new BLLHoaDon();
        DTOChiTietHoaDon dTOChiTietHoaDon = null;
        private string maHoaDon;

        public HoaDonThemMoiChiTiet(string maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenSanPham.Text != "" && txtSoLuong.Text != "")
            {
                dTOChiTietHoaDon = new DTOChiTietHoaDon(maHoaDon, txtTenSanPham.Text, int.Parse(txtSoLuong.Text));

                if (bLLHoaDon.InsertChiTietHoaDon(dTOChiTietHoaDon))
                {
                    MessageBox.Show("Bạn đã thêm thông tin chi tiết hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin chi tiết hóa đơn thất bại, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void HoaDonThemMoiChiTiet_Load(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = maHoaDon;
        }
    }
}
