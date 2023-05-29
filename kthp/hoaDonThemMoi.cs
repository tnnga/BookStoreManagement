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
    public partial class frmHoaDonThemMoi : Form
    {

        public frmHoaDonThemMoi()
        {
            InitializeComponent();
        }

        BLLSanPham bLLSanPham = new BLLSanPham();
        BLLHoaDon bLLHoaDon = new BLLHoaDon();
        DTOHoaDon dTOHoaDon = null;
        DTOChiTietHoaDon sp = null;

        

        private void ConfigureSP()
        {
            dgwHoaDonThemChiTiet.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwHoaDonThemChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwHoaDonThemChiTiet.Columns[0].Width = 120;
            dgwHoaDonThemChiTiet.Columns[1].Width = 200;
            dgwHoaDonThemChiTiet.Columns[2].Width = 100;
            dgwHoaDonThemChiTiet.Columns[3].Width = 120;
            dgwHoaDonThemChiTiet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwHoaDonThemChiTiet.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(txtMaHoaDon) == "" &&
                errorProvider1.GetError(txtMaKhachHang) == "" &&
                errorProvider1.GetError(txtNgayHoaDon) == "" &&
                errorProvider1.GetError(txtGioLapHoaDon) == "" &&
                txtMaHoaDon.Text != "" &&
                txtMaKhachHang.Text != "" &&
                txtNgayHoaDon.Text != "" &&
                txtGioLapHoaDon.Text != "")
            {
                dTOHoaDon = new DTOHoaDon(txtMaHoaDon.Text, txtMaKhachHang.Text, txtNgayHoaDon.Text, txtGioLapHoaDon.Text);
                if (bLLHoaDon.InsertHoaDon(dTOHoaDon))
                {
                    lblMaHoaDonChiTiet.Text = txtMaHoaDon.Text;

                    DialogResult resquest = MessageBox.Show("Thêm thông tin thành công!\nVui lòng thêm chi tiết hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnThemChiTiet.Enabled = true;
                }
                else
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Vui lòng nhập đủ thông tin cần thiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtMaHoaDon_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHoaDon.Text))
            {
                errorProvider1.SetError(txtMaHoaDon, "Vui lòng nhập thông tin!");
                txtMaHoaDon.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtTenKhachHang_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhachHang.Text))
            {
                errorProvider1.SetError(txtMaKhachHang, "Vui lòng nhập thông tin!");
                txtMaKhachHang.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtNgayHoaDon_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNgayHoaDon.Text))
            {
                errorProvider1.SetError(txtNgayHoaDon, "Vui lòng nhập thông tin!");
                txtNgayHoaDon.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtGioLapHoaDon_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGioLapHoaDon.Text))
            {
                errorProvider1.SetError(txtGioLapHoaDon, "Vui lòng nhập thông tin!");
                txtGioLapHoaDon.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void dgwHoaDonThemChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmHoaDonThemMoi_Load(object sender, EventArgs e)
        {
            sp = new DTOChiTietHoaDon(lblMaHoaDon.Text, "", "", 0);
            dgwHoaDonThemChiTiet.DataSource = bLLHoaDon.SelectChiTietHoaDon(sp);
            ConfigureSP();
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            HoaDonThemMoiChiTiet hoaDonThemMoiChiTiet = new HoaDonThemMoiChiTiet(txtMaHoaDon.Text);
            hoaDonThemMoiChiTiet.ShowDialog();

            sp = new DTOChiTietHoaDon(txtMaHoaDon.Text, "", "", 0);
            dgwHoaDonThemChiTiet.DataSource = bLLHoaDon.SelectChiTietHoaDon(sp);
            ConfigureSP();
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            dgwThanhTien.DataSource = bLLHoaDon.TongThanhTien(sp);
            txtDonGia.Text = dgwThanhTien.Rows[0].Cells[0].Value.ToString().Trim();

            dTOHoaDon = new DTOHoaDon(txtMaHoaDon.Text, "", "", "", int.Parse(txtDonGia.Text));
            if (bLLHoaDon.InsertDonGiaHoaDon(dTOHoaDon))
            {
                DialogResult resquest = MessageBox.Show("Hoàn tất thêm hóa đơn, bạn có muốn in hoá đơn hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resquest == DialogResult.Yes)
                {
                    reportHoaDon reportHoaDon = new reportHoaDon(txtMaHoaDon.Text);
                    reportHoaDon.Show();

                    Close();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Thêm chi tiết hóa đơn không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyThemHoaDon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgwHoaDonThemChiTiet.RowCount - 1; i++)
            {
                string maSanPham = dgwHoaDonThemChiTiet.Rows[i].Cells[0].Value.ToString().Trim();
                string soLuong = dgwHoaDonThemChiTiet.Rows[i].Cells[3].Value.ToString().Trim();
                sp = new DTOChiTietHoaDon("", "", maSanPham, int.Parse(soLuong));
                bLLSanPham.UpdateTangSoLuongSanPhamGiam(sp);
            }

            dTOHoaDon = new DTOHoaDon(txtMaHoaDon.Text, "", "", "", 0);
            sp = new DTOChiTietHoaDon(txtMaHoaDon.Text, "", "", 0);

            if (bLLHoaDon.DeleteChiTietHoaDonAll(sp) && bLLHoaDon.DeleteHoaDon(dTOHoaDon))
            {
                MessageBox.Show("Huỷ thêm thông tin hoá đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
                MessageBox.Show("Huỷ không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHangThemMoi frmKhachHangThemMoi = new frmKhachHangThemMoi();
            frmKhachHangThemMoi.ShowDialog();
        }
    }
}
