using BLLQLNS;
using DTOQLNS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace kthp
{
    public partial class frmDangKy : Form
    {
        DTOTaiKhoan dTOTaiKhoan = null;
        BLLTaiKhoan bLLTaiKhoan = new BLLTaiKhoan();
        public frmDangKy()
        {
            InitializeComponent();
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(txtTenDangNhap) == "" &&
                errorProvider1.GetError(txtHoTen) == "" &&
                errorProvider1.GetError(txtMatKhau) == "" &&
                errorProvider1.GetError(txtEmail) == "" &&
                errorProvider1.GetError(txtDiaChi) == "" &&
                errorProvider1.GetError(cboGioiTinh) == "" &&
                errorProvider1.GetError(mtbNgaySinh) == "" &&
                errorProvider1.GetError(mtbSoDienThoai) == "" &&
                txtTenDangNhap.Text != "" &&
                txtDiaChi.Text != "" &&
                txtEmail.Text != "" &&
                txtHoTen.Text != "" &&
                txtMatKhau.Text != "" &&
                cboGioiTinh.Text != "" &&
                mtbNgaySinh.Text != "" &&
                mtbSoDienThoai.Text != "")
            {

                dTOTaiKhoan = new DTOTaiKhoan(txtTenDangNhap.Text, txtMatKhau.Text, txtHoTen.Text, cboGioiTinh.Text, mtbNgaySinh.Text, mtbSoDienThoai.Text, txtEmail.Text, txtDiaChi.Text);
                if (bLLTaiKhoan.InSertTaiKhoan(dTOTaiKhoan))
                {
                    DialogResult result = MessageBox.Show("Bạn đã đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Thất bại, đăng kí chưa được thực hiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Đăng kí không thành công, vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dangKy_Load(object sender, EventArgs e)
        {

            errorProvider1.BlinkRate = 500;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;

            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
        }

        private void btnDangKy_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            btnDangKy.Font = new Font(btnDangKy.Font.FontFamily, btnDangKy.Font.Size + 3, btnDangKy.Font.Style);
            btnDangKy.ForeColor = Color.Indigo;
        }

        private void btnDangKy_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            btnDangKy.Font = new Font(btnDangKy.Font.FontFamily, btnDangKy.Font.Size - 3, btnDangKy.Font.Style);
            btnDangKy.ForeColor = Color.White;
        }
        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                errorProvider1.SetError(txtMatKhau, "Vui lòng nhập thông tin!");
                txtMatKhau.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Vui lòng nhập thông tin!");
                txtHoTen.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void cboGioiTinh_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboGioiTinh.Text))
            {
                errorProvider1.SetError(cboGioiTinh, "Vui lòng nhập thông tin!");
                cboGioiTinh.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void mtbNgaySinh_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtbNgaySinh.Text))
            {
                errorProvider1.SetError(mtbNgaySinh, "Vui lòng nhập thông tin!");
                mtbNgaySinh.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void mtbSoDienThoai_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtbSoDienThoai.Text))
            {
                errorProvider1.SetError(mtbSoDienThoai, "Vui lòng nhập thông tin!");
                mtbSoDienThoai.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Vui lòng nhập thông tin!");
                txtEmail.Focus();
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

        private void frmDangKy_Shown(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                errorProvider1.SetError(txtTenDangNhap, "Vui lòng nhập thông tin!");
                txtTenDangNhap.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
