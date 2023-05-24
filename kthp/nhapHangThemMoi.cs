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
    public partial class frmNhapHangThemMoi : Form
    {
        BLLNhapHang bLLNhapHang = new BLLNhapHang();
        DTONhapHang dTONhapHang = null;
        public frmNhapHangThemMoi()
        {
            InitializeComponent();
        }

        private void btnThemNhapHang_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(txtMaNhapHang) == "" &&
                errorProvider1.GetError(txtTenNhanVien) == "" &&
                errorProvider1.GetError(txtNgayNhapHang) == "" &&
                errorProvider1.GetError(txtGioNhapHang) == "" &&
                errorProvider1.GetError(txtDonGia) == "" &&
                txtMaNhapHang.Text != "" &&
                txtTenNhanVien.Text != "" &&
                txtNgayNhapHang.Text != "" &&
                txtGioNhapHang.Text != "" &&
                txtDonGia.Text != "")
            {
                dTONhapHang = new DTONhapHang(txtMaNhapHang.Text, txtTenNhanVien.Text, txtNgayNhapHang.Text, txtGioNhapHang.Text, float.Parse(txtDonGia.Text));
                if (bLLNhapHang.InSertNhapHang(dTONhapHang))
                {
                    frmNhapHangThemChiTiet frmNhapHangThemChiTiet = new frmNhapHangThemChiTiet(txtMaNhapHang.Text);
                    frmNhapHangThemChiTiet.ShowDialog();
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

        private void txtMaNhapHang_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNhapHang.Text))
            {
                errorProvider1.SetError(txtMaNhapHang, "Vui lòng nhập thông tin!");
                txtMaNhapHang.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtTenNhanVien_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text))
            {
                errorProvider1.SetError(txtTenNhanVien, "Vui lòng nhập thông tin!");
                txtTenNhanVien.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtNgayNhapHang_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNgayNhapHang.Text))
            {
                errorProvider1.SetError(txtNgayNhapHang, "Vui lòng nhập thông tin!");
                txtNgayNhapHang.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtGioNhapHang_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGioNhapHang.Text))
            {
                errorProvider1.SetError(txtGioNhapHang, "Vui lòng nhập thông tin!");
                txtGioNhapHang.Focus();
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
    }
}
