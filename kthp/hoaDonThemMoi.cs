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
        DTOChiTietHoaDon sp = null;

        

        private void ConfigureSP()
        {
            dgwHoaDonThemChiTiet.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwHoaDonThemChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwHoaDonThemChiTiet.Columns[0].Width = 150;
            dgwHoaDonThemChiTiet.Columns[1].Width = 150;
            dgwHoaDonThemChiTiet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwHoaDonThemChiTiet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
                    DialogResult resquest = MessageBox.Show("Vui lòng thêm chi tiết hoá đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Hoàn tất thêm chi tiết hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm chi tiết hóa đơn không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHoanTatThemHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult resquest = MessageBox.Show("Hoàn tất thêm hóa đơn, bạn có muốn in hoá đơn hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resquest == DialogResult.Yes)
            {
                reportHoaDon reportHoaDon = new reportHoaDon(txtMaHoaDon.Text);
                reportHoaDon.Show();
            }
            else
            {
                Close();
            }
        }

        private void lblDienThongTin_Click(object sender, EventArgs e)
        {

        }
    }
}
