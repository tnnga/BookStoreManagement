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
        DTOChiTietNhapHang sp = null;

        BLLSanPham bLLSanPham = new BLLSanPham();
        DTOSanPham dTOSanPham = null;
        

        public frmNhapHangThemMoi()
        {
            InitializeComponent();
        }

        private void ConfigureSP()
        {
            dgwNhapHangThemChiTiet.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwNhapHangThemChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwNhapHangThemChiTiet.Columns[0].Width = 150;
            dgwNhapHangThemChiTiet.Columns[1].Width = 150;
            dgwNhapHangThemChiTiet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwNhapHangThemChiTiet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
                dTONhapHang = new DTONhapHang(txtMaNhapHang.Text, txtTenNhanVien.Text, txtNgayNhapHang.Text, txtGioNhapHang.Text, int.Parse(txtDonGia.Text));
                if (bLLNhapHang.InSertNhapHang(dTONhapHang))
                {
                    lblMaNhapHangChiTiet.Text = txtMaNhapHang.Text;

                    MessageBox.Show("Thêm thông tin thành công!\nVui lòng thêm chi tiết nhập hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void frmNhapHangThemMoi_Load(object sender, EventArgs e)
        {
            sp = new DTOChiTietNhapHang(txtMaNhapHang.Text, "", "", 0);
            dgwNhapHangThemChiTiet.DataSource = bLLNhapHang.SelectChiTietNhapHang(sp);
            ConfigureSP();
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            nhapHangThemMoiChiTiet hoaDonThemMoiChiTiet = new nhapHangThemMoiChiTiet(txtMaNhapHang.Text);
            hoaDonThemMoiChiTiet.ShowDialog();

            sp = new DTOChiTietNhapHang(txtMaNhapHang.Text, "", "", 0);
            dgwNhapHangThemChiTiet.DataSource = bLLNhapHang.SelectChiTietNhapHang(sp);
            ConfigureSP();
        }

        private void btnHoanTatThemNhapHang_Click(object sender, EventArgs e)
        {                   

            DialogResult resquest = MessageBox.Show("Hoàn tất thêm nhập hàng, bạn có muốn in phiếu nhập hàng hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resquest == DialogResult.Yes)
            {
                reportNhapHang reportNhapHang = new reportNhapHang(txtMaNhapHang.Text);
                reportNhapHang.Show();

                Close();
            }
            else
            {
                Close();
            }
        }

        private void btnHuyThemNhapHang_Click(object sender, EventArgs e)
        {
            
            dTONhapHang = new DTONhapHang(txtMaNhapHang.Text, "", "", "", 0);
            sp = new DTOChiTietNhapHang(txtMaNhapHang.Text, "", "", 0);
            
            if (bLLNhapHang.DeleteChiTietNhapHangAll(sp) && bLLNhapHang.DeleteNhapHang(dTONhapHang))
            {
                MessageBox.Show("Thêm thông tin thành công!\nVui lòng thêm chi tiết nhập hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
