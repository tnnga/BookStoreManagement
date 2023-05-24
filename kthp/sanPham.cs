using BLLQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kthp
{
    public partial class sanPham : Form
    {
        BLLSanPham bLLSanPham = new BLLSanPham();
        DTOSanPham sp = null;
        public sanPham()
        {
            InitializeComponent();
        }

        private string maSach;
        private string tenSach;
        private int soLuong;
        private int giaTien;
        private string loaiSach;
        private string noiDungChinh;

        private void ConfigureSP()
        {
            dgwSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwSanPham.Columns[0].Width = 80;
            dgwSanPham.Columns[1].Width = 200;
            dgwSanPham.Columns[2].Width = 80;
            dgwSanPham.Columns[3].Width = 120;
            dgwSanPham.Columns[4].Width = 120;
            dgwSanPham.Columns[5].Width = 100;
            dgwSanPham.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwSanPham.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
        private void sanPham_Load(object sender, EventArgs e)
        {
            string[] luaChonTimKiem = { "Tên sách", "Mã sách" };
            cbTimKiem.Items.AddRange(luaChonTimKiem);

            string[] loaiSach = { "Toán học", "Kinh tế", "Lịch sử", "Khoa học", "Thể thao"};
            cbLoaiSach.Items.AddRange(loaiSach);

            dgwSanPham.DataSource = bLLSanPham.SelectSanPham();
            ConfigureSP();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            frmSanPhamThemMoi frmSanPhamThemMoi = new frmSanPhamThemMoi();
            frmSanPhamThemMoi.ShowDialog();
            
            dgwSanPham.DataSource = bLLSanPham.SelectSanPham();
            ConfigureSP();     
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.SelectedIndex == 0)
            {
                sp = new DTOSanPham( "", txtTimKiem.Text, 0, 0, "", "");
                dgwSanPham.DataSource = bLLSanPham.FindTenSanPham(sp);
                ConfigureSP();
            }
            if (cbTimKiem.SelectedIndex == 1)
            {
                sp = new DTOSanPham(txtTimKiem.Text, "", 0, 0, "", "");
                dgwSanPham.DataSource = bLLSanPham.FindMaSanPham(sp);
                ConfigureSP();
            }
            if (cbLoaiSach.SelectedIndex != -1 && txtTimKiem.Text == "" )
            {
                sp = new DTOSanPham("", "", 0, 0, cbLoaiSach.Text, "");
                dgwSanPham.DataSource = bLLSanPham.PhanLoaiSanPham(sp);
                ConfigureSP();
            }
            if ((cbTimKiem.Text == "" && cbLoaiSach.Text == "") ||
                (cbTimKiem.SelectedIndex == 0 && cbLoaiSach.Text == "") ||
                (cbLoaiSach.SelectedIndex == 0 && cbTimKiem.Text == "") ||
                (cbTimKiem.SelectedIndex == 0 && cbLoaiSach.Text == "(Lựa chọn)"))
            {
                dgwSanPham.DataSource = bLLSanPham.SelectSanPham();
                ConfigureSP();
            }
        }

        private void ChiTietThongTinSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dgwSanPham.CurrentCell.RowIndex;

            maSach = dgwSanPham.Rows[rowIndex].Cells[0].Value.ToString().Trim();
            tenSach = dgwSanPham.Rows[rowIndex].Cells[1].Value.ToString().Trim();
            giaTien = int.Parse(dgwSanPham.Rows[rowIndex].Cells[2].Value.ToString().Trim());
            soLuong = int.Parse(dgwSanPham.Rows[rowIndex].Cells[3].Value.ToString().Trim());
            loaiSach = dgwSanPham.Rows[rowIndex].Cells[4].Value.ToString().Trim();
            noiDungChinh = dgwSanPham.Rows[rowIndex].Cells[5].Value.ToString().Trim();

            frmSanPhamChiTiet frmSanPhamChiTiet = new frmSanPhamChiTiet(maSach, tenSach, giaTien, soLuong, loaiSach,noiDungChinh);
            frmSanPhamChiTiet.ShowDialog();
        }

        private void CapNhatThongTinSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dgwSanPham.CurrentCell.RowIndex;

            maSach = dgwSanPham.Rows[rowIndex].Cells[0].Value.ToString().Trim();
            tenSach = dgwSanPham.Rows[rowIndex].Cells[1].Value.ToString().Trim();
            giaTien = int.Parse(dgwSanPham.Rows[rowIndex].Cells[2].Value.ToString().Trim());
            soLuong = int.Parse(dgwSanPham.Rows[rowIndex].Cells[3].Value.ToString().Trim());
            loaiSach = dgwSanPham.Rows[rowIndex].Cells[4].Value.ToString().Trim();
            noiDungChinh = dgwSanPham.Rows[rowIndex].Cells[5].Value.ToString().Trim();

            frmSanPhamCapNhat frmSanPhamCapNhat = new frmSanPhamCapNhat(maSach, tenSach, giaTien, soLuong, loaiSach, noiDungChinh);
            frmSanPhamCapNhat.ShowDialog();
        }

        private void XoaThongTinSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc chắn muốn xoá thông tin của sản phẩm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (res == DialogResult.Yes)
            {

                dgwSanPham.Refresh();
            }
        }
    }
}
