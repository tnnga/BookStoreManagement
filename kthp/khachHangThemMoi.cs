using System;
using System.Windows.Forms;

namespace kthp
{
    public partial class frmKhachHangThemMoi : Form
    {
        public frmKhachHangThemMoi()
        {
            InitializeComponent();
        }

        private bool InsertKhachHang()
        {
            dcKTHPDataContext data = new dcKTHPDataContext();
            KhachHang kh = new KhachHang();

            kh.MaKhachHang = txtMaKhachHang.Text.Trim();
            kh.TenKhachHang = txtTenKhachHang.Text.Trim();
            kh.GioiTinh = txtGioiTinh.Text.Trim();
            kh.SDT = txtSoDienThoai.Text.Trim();
            kh.DiaChi = txtDiaChi.Text.Trim();
            if (kh.MaKhachHang != "" && kh.TenKhachHang != "" && kh.GioiTinh != "" && kh.SDT != "" && kh.DiaChi != "")
            {
                data.KhachHangs.InsertOnSubmit(kh);
                data.SubmitChanges();
                return true;
            }
            return false;
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(txtMaKhachHang) == "" &&
                errorProvider1.GetError(txtTenKhachHang) == "" &&
                errorProvider1.GetError(txtGioiTinh) == "" &&
                errorProvider1.GetError(txtSoDienThoai) == "" &&
                errorProvider1.GetError(txtDiaChi) == "" &&
                txtMaKhachHang.Text != "" &&
                txtTenKhachHang.Text != "" &&
                txtGioiTinh.Text != "" &&
                txtSoDienThoai.Text != "" &&
                txtDiaChi.Text != "")
            {
                if (InsertKhachHang())
                {
                    MessageBox.Show("Bạn đã thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtMaKhachHang_Leave(object sender, EventArgs e)
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

        private void txtTenKhachHang_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text))
            {
                errorProvider1.SetError(txtTenKhachHang, "Vui lòng nhập thông tin!");
                txtTenKhachHang.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtGioiTinh_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGioiTinh.Text))
            {
                errorProvider1.SetError(txtGioiTinh, "Vui lòng nhập thông tin!");
                txtGioiTinh.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSoDienThoai_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                errorProvider1.SetError(txtSoDienThoai, "Vui lòng nhập thông tin!");
                txtSoDienThoai.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                errorProvider1.SetError(txtDiaChi, "Vui lòng nhập thông tin!");
                txtDiaChi.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void frmSanPhamThemMoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn hủy thêm sản phẩm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
