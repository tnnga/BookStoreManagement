using BLLQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kthp
{
    public partial class nhapHangCapNhat : Form
    {
        BLLNhapHang bLLNhapHang = new BLLNhapHang();
        DTONhapHang dTONhapHang = null;
        DTOChiTietNhapHang sp = null;

        private string maNhapHang;
        private string tenNhanVien;
        private string ngayNhap;
        private string gioNhap;
        private int donGia;

        private string maSanPham;
        private int soLuong;
        
        public nhapHangCapNhat(string naNhapHang, string tenNhanVien, string ngayNhap, string gioNhap, int donGia)
        {
            InitializeComponent();
            this.maNhapHang = naNhapHang;
            this.tenNhanVien = tenNhanVien;
            this.ngayNhap = ngayNhap;
            this.gioNhap = gioNhap;
            this.donGia = donGia;
        }
        private void ConfigureSP()
        {
            dgwCapNhatChiTietNhapHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwCapNhatChiTietNhapHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwCapNhatChiTietNhapHang.Columns[0].Width = 150;
            dgwCapNhatChiTietNhapHang.Columns[1].Width = 150;
            dgwCapNhatChiTietNhapHang.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwCapNhatChiTietNhapHang.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            dTONhapHang = new DTONhapHang(txtMaNhapHang.Text, txtTenNhanVien.Text, txtNgayNhap.Text, txtGioNhap.Text, int.Parse(txtDonGia.Text));

            if (bLLNhapHang.UpdateNhapHang(dTONhapHang))
            {
                MessageBox.Show("Bạn đã cập nhật thông tin nhập hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin nhập hàng thất bại, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nhapHangCapNhat_Load(object sender, EventArgs e)
        {
            txtMaNhapHang.Text = maNhapHang;
            txtTenNhanVien.Text = tenNhanVien;
            txtNgayNhap.Text = ngayNhap;
            txtGioNhap.Text = gioNhap;
            txtDonGia.Text = donGia.ToString();

            sp = new DTOChiTietNhapHang(txtMaNhapHang.Text, "", 0);
            dgwCapNhatChiTietNhapHang.DataSource = bLLNhapHang.SelectChiTietNhapHang(sp);
            ConfigureSP();
        }

        private void chinhSuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dgwCapNhatChiTietNhapHang.CurrentCell.RowIndex;

            maSanPham = dgwCapNhatChiTietNhapHang.Rows[rowIndex].Cells[0].Value.ToString().Trim();
            soLuong = int.Parse(dgwCapNhatChiTietNhapHang.Rows[rowIndex].Cells[1].Value.ToString().Trim());

            nhapHangCapNhatChiTiet frmNhapHangCapNhatChiTiet = new nhapHangCapNhatChiTiet(maNhapHang, maSanPham, soLuong);
            frmNhapHangCapNhatChiTiet.ShowDialog();

            sp = new DTOChiTietNhapHang(txtMaNhapHang.Text, "", 0);
            dgwCapNhatChiTietNhapHang.DataSource = bLLNhapHang.SelectChiTietNhapHang(sp);
            ConfigureSP();
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dgwCapNhatChiTietNhapHang.CurrentCell.RowIndex;

            maSanPham = dgwCapNhatChiTietNhapHang.Rows[rowIndex].Cells[0].Value.ToString().Trim();

            var res = MessageBox.Show("Bạn có chắc chắn muốn xoá thông tin chi tiết nhập hàng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (res == DialogResult.Yes)
            {
                sp = new DTOChiTietNhapHang("", maSanPham, 0);
                if (bLLNhapHang.DeleteChiTietNhapHang(sp))
                {
                    var res1 = MessageBox.Show("Xóa thông tin chi tiết nhập hàng thành công?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                else
                {
                    var res3 = MessageBox.Show("Xóa thông tin chi tiết nhập hàng thất bại, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                }
            }

            sp = new DTOChiTietNhapHang(txtMaNhapHang.Text, "", 0);
            dgwCapNhatChiTietNhapHang.DataSource = bLLNhapHang.SelectChiTietNhapHang(sp);
            ConfigureSP();
        }

        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
