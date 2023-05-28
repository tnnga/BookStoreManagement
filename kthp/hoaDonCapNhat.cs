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
    public partial class hoaDonCapNhat : Form
    {
        BLLHoaDon bLLHoaDon = new BLLHoaDon();
        DTOHoaDon dTOHoaDon = null;
        DTOChiTietHoaDon sp = null;

        private string maHoaDon;
        private string tenKhachHang;
        private string ngayHoaDon;
        private string gioHoaDon;
        private int donGia;

        private string maSanPham;
        private int soLuong;

        public hoaDonCapNhat(string maHoaDon, string tenKhachHang, string ngayHoaDon, string gioHoaDon, int donGia)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
            this.tenKhachHang = tenKhachHang;
            this.ngayHoaDon = ngayHoaDon;
            this.gioHoaDon = gioHoaDon;
            this.donGia = donGia;
        }
        private void ConfigureSP()
        {
            dgwCapNhatChiTietHoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwCapNhatChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwCapNhatChiTietHoaDon.Columns[0].Width = 150;
            dgwCapNhatChiTietHoaDon.Columns[1].Width = 150;
            dgwCapNhatChiTietHoaDon.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwCapNhatChiTietHoaDon.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            dTOHoaDon = new DTOHoaDon(txtMaHoaDon.Text, txtTenKhachHang.Text, txtNgayHoaDon.Text, txtGioHoaDon.Text, int.Parse(txtDonGia.Text));

            if (bLLHoaDon.UpdateHoaDon(dTOHoaDon))
            {
                MessageBox.Show("Bạn đã cập nhật thông tin hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin hóa đơn thất bại, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void hoaDonCapNhat_Load(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = maHoaDon;
            txtTenKhachHang.Text = tenKhachHang;
            txtNgayHoaDon.Text = ngayHoaDon;
            txtGioHoaDon.Text = gioHoaDon;
            txtDonGia.Text = donGia.ToString();

            sp = new DTOChiTietHoaDon(txtMaHoaDon.Text, "", "", 0);
            dgwCapNhatChiTietHoaDon.DataSource = bLLHoaDon.SelectChiTietHoaDon(sp);
            ConfigureSP();
        }

        private void chinhSuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dgwCapNhatChiTietHoaDon.CurrentCell.RowIndex;

            maSanPham = dgwCapNhatChiTietHoaDon.Rows[rowIndex].Cells[0].Value.ToString().Trim();
            soLuong = int.Parse(dgwCapNhatChiTietHoaDon.Rows[rowIndex].Cells[2].Value.ToString().Trim());

            hoaDonCapNhatChiTiet frmHoaDonCapNhatChiTiet = new hoaDonCapNhatChiTiet(maHoaDon, maSanPham, soLuong);
            frmHoaDonCapNhatChiTiet.ShowDialog();

            sp = new DTOChiTietHoaDon(txtMaHoaDon.Text, "", "", 0);
            dgwCapNhatChiTietHoaDon.DataSource = bLLHoaDon.SelectChiTietHoaDon(sp);
            ConfigureSP();
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dgwCapNhatChiTietHoaDon.CurrentCell.RowIndex;

            maSanPham = dgwCapNhatChiTietHoaDon.Rows[rowIndex].Cells[0].Value.ToString().Trim();

            var res = MessageBox.Show("Bạn có chắc chắn muốn xoá thông tin chi tiết hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (res == DialogResult.Yes)
            {
                sp = new DTOChiTietHoaDon(maHoaDon, "", maSanPham, 0);
                if (bLLHoaDon.DeleteChiTietHoaDon(sp))
                {
                    var res1 = MessageBox.Show("Xóa thông tin chi tiết hóa đơn thành công?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    var res3 = MessageBox.Show("Xóa thông tin chi tiết hóa đơn thất bại, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                }
            }

            sp = new DTOChiTietHoaDon(txtMaHoaDon.Text, "", "", 0);
            dgwCapNhatChiTietHoaDon.DataSource = bLLHoaDon.SelectChiTietHoaDon(sp);
            ConfigureSP();
        }

        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonThemMoiChiTiet hoaDonThemMoiChiTiet = new HoaDonThemMoiChiTiet(maHoaDon);
            hoaDonThemMoiChiTiet.ShowDialog();

            sp = new DTOChiTietHoaDon(txtMaHoaDon.Text, "", "", 0);
            dgwCapNhatChiTietHoaDon.DataSource = bLLHoaDon.SelectChiTietHoaDon(sp);
            ConfigureSP();
        }
    }
}
