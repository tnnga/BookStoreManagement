using BLLQLNS;
using DTOQLNS;
using System;
using System.Windows.Forms;

namespace kthp
{
    public partial class frmSanPhamThemMoi : Form
    {
        BLLSanPham bLLSanPham = new BLLSanPham();
        DTOSanPham dTOSanPham = null;
        public frmSanPhamThemMoi()
        {
            InitializeComponent();
        }

        private void frmSanPhamThemMoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn hủy thêm sản phẩm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtMaSach_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                errorProvider1.SetError(txtMaSach, "Vui lòng nhập thông tin!");
                txtMaSach.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtTenSach_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSach.Text))
            {
                errorProvider1.SetError(txtTenSach, "Vui lòng nhập thông tin!");
                txtMaSach.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSoLuongTon_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoLuongTon.Text))
            {
                errorProvider1.SetError(txtSoLuongTon, "Vui lòng nhập thông tin!");
                txtMaSach.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtGiaTien_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGiaTien.Text))
            {
                errorProvider1.SetError(txtGiaTien, "Vui lòng nhập thông tin!");
                txtMaSach.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtLoaiSach_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLoaiSach.Text))
            {
                errorProvider1.SetError(txtLoaiSach, "Vui lòng nhập thông tin!");
                txtMaSach.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtNoiDungChinh_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoiDungChinh.Text))
            {
                errorProvider1.SetError(txtNoiDungChinh, "Vui lòng nhập thông tin!");
                txtMaSach.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(txtMaSach) == "" &&
                errorProvider1.GetError(txtTenSach) == "" &&
                errorProvider1.GetError(txtSoLuongTon) == "" &&
                errorProvider1.GetError(txtGiaTien) == "" &&
                errorProvider1.GetError(txtLoaiSach) == "" &&
                txtMaSach.Text != "" &&
                txtTenSach.Text != "" &&
                txtSoLuongTon.Text != "" &&
                txtGiaTien.Text != "" &&
                txtLoaiSach.Text != "")
            {
                dTOSanPham = new DTOSanPham(txtMaSach.Text, txtTenSach.Text, int.Parse(txtSoLuongTon.Text), int.Parse(txtGiaTien.Text), txtLoaiSach.Text, txtNoiDungChinh.Text);
                if (bLLSanPham.InSertSanPham(dTOSanPham))
                {
                    MessageBox.Show("Bạn đã thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtMaSach.Text = null;
                    txtTenSach.Text = null;
                    txtSoLuongTon.Text = null;
                    txtGiaTien.Text = null;
                    txtLoaiSach.Text = null;
                    txtNoiDungChinh.Text = null;
                }
                else
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Vui lòng nhập đủ thông tin cần thiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
