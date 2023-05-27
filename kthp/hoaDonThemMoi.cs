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

        BLLHoaDon bLLHoaDon = new BLLHoaDon();
        DTOHoaDon dTOHoaDon = null;


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(txtMaHoaDon) == "" &&
                errorProvider1.GetError(txtMaKhachHang) == "" &&
                errorProvider1.GetError(txtNgayHoaDon) == "" &&
                errorProvider1.GetError(txtGioLapHoaDon) == "" &&
                errorProvider1.GetError(txtDonGia) == "" &&
                txtMaHoaDon.Text != "" &&
                txtMaKhachHang.Text != "" &&
                txtNgayHoaDon.Text != "" &&
                txtGioLapHoaDon.Text != "" &&
                txtDonGia.Text != "")
            {
                dTOHoaDon = new DTOHoaDon(txtMaHoaDon.Text, txtMaKhachHang.Text, txtNgayHoaDon.Text, txtGioLapHoaDon.Text, float.Parse(txtDonGia.Text));
                if (bLLHoaDon.InsertHoaDon(dTOHoaDon))
                {
                    frmHoaDonThemChiTiet frmHoaDonThemChiTiet = new frmHoaDonThemChiTiet(txtMaHoaDon.Text);
                    frmHoaDonThemChiTiet.ShowDialog();
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

        private void txtDonGia_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                errorProvider1.SetError(txtDonGia, "Vui lòng nhập thông tin!");
                txtDonGia.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        
        private void frmHoaDonThemMoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn hủy thêm sản phẩm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DialogResult resquest = MessageBox.Show("Bạn có muốn in hoá đơn hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resquest == DialogResult.Yes)
                {
                    reportHoaDon reportHoaDon = new reportHoaDon(txtMaHoaDon.Text);
                    reportHoaDon.Show();

                }
                else
                {
                    e.Cancel = false;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
