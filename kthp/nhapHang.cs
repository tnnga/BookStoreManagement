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
    public partial class nhapHang : Form
    {
        BLLNhapHang bLLNhapHang = new BLLNhapHang();
        DTONhapHang sp = null;
        DTOChiTietNhapHang sp2 = null;

        private string maNhapHang;
        private string tenNhanVien;
        private string ngayNhap;
        private string gioNhap;
        private int donGia;

        public nhapHang()
        {
            InitializeComponent();
        }

        private void ConfigureSP()
        {
            dgwNhapHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwNhapHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgwNhapHang.Columns[0].Width = 100;
            dgwNhapHang.Columns[1].Width = 200;
            dgwNhapHang.Columns[2].Width = 150;
            dgwNhapHang.Columns[3].Width = 150;
            dgwNhapHang.Columns[4].Width = 150;

            dgwNhapHang.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwNhapHang.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void nhapHang_Load(object sender, EventArgs e)
        {
            

            dgwNhapHang.DataSource = bLLNhapHang.SelectNhapHang();
            ConfigureSP();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbTimKiemTheo.SelectedIndex == 0)
            {
                sp = new DTONhapHang(txtTimKiem.Text,"","","",0);
                dgwNhapHang.DataSource = bLLNhapHang.FindMaNhapHang(sp);
                ConfigureSP();
            }
            if (cbTimKiemTheo.SelectedIndex == 1)
            {
                sp = new DTONhapHang("", txtTimKiem.Text, "", "", 0);
                dgwNhapHang.DataSource = bLLNhapHang.FindTenNhanVien(sp);
                ConfigureSP();
            }
            if (cbTimKiemTheo.SelectedIndex == 2)
            {
                sp = new DTONhapHang("", "", txtTimKiem.Text, "", 0);
                dgwNhapHang.DataSource = bLLNhapHang.FindNgayNhapHang(sp);
                ConfigureSP();
            }
            if ((cbTimKiemTheo.Text == "" || cbTimKiemTheo.SelectedIndex == -1))
            {
                dgwNhapHang.DataSource = bLLNhapHang.SelectNhapHang();
                ConfigureSP();
            }
        }

        private void btnTaoNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHangThemMoi frmNhapHangThemMoi = new frmNhapHangThemMoi();
            frmNhapHangThemMoi.ShowDialog();

            dgwNhapHang.DataSource = bLLNhapHang.SelectNhapHang();
            ConfigureSP();
        }

        private void chiTietNhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dgwNhapHang.CurrentCell.RowIndex;

            maNhapHang = dgwNhapHang.Rows[rowIndex].Cells[0].Value.ToString().Trim();

            nhapHangChiTiet nhapHangChiTiet = new nhapHangChiTiet(maNhapHang);
            nhapHangChiTiet.ShowDialog();
        }
        private void capNhatThongTinNhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dgwNhapHang.CurrentCell.RowIndex;
            
            maNhapHang = dgwNhapHang.Rows[rowIndex].Cells[0].Value.ToString().Trim();
            tenNhanVien = dgwNhapHang.Rows[rowIndex].Cells[1].Value.ToString().Trim();
            ngayNhap = dgwNhapHang.Rows[rowIndex].Cells[2].Value.ToString().Trim();
            gioNhap = dgwNhapHang.Rows[rowIndex].Cells[3].Value.ToString().Trim();
            donGia = int.Parse(dgwNhapHang.Rows[rowIndex].Cells[4].Value.ToString().Trim());

            nhapHangCapNhat frmNhapHangCapNhat = new nhapHangCapNhat(maNhapHang, tenNhanVien, ngayNhap, gioNhap, donGia);
            frmNhapHangCapNhat.ShowDialog();

            dgwNhapHang.DataSource = bLLNhapHang.SelectNhapHang();
            ConfigureSP();
        }
        private void xoaThongTinNhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dgwNhapHang.CurrentCell.RowIndex;

            maNhapHang = dgwNhapHang.Rows[rowIndex].Cells[0].Value.ToString().Trim();

            var res = MessageBox.Show("Bạn có chắc chắn muốn xoá thông tin nhập hàng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (res == DialogResult.Yes)
            {
                sp = new DTONhapHang(maNhapHang,"","","",0);
                sp2 = new DTOChiTietNhapHang(maNhapHang, "", 0);
                if (bLLNhapHang.DeleteNhapHang(sp) && bLLNhapHang.DeleteChiTietNhapHang(sp2))
                {
                    var res1 = MessageBox.Show("Xóa thông tin nhập hàng thành công?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    dgwNhapHang.DataSource = bLLNhapHang.SelectNhapHang();
                    ConfigureSP();
                }
                else
                {
                    var res3 = MessageBox.Show("Xóa thông tin nhập hàng thất bại?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                }
            }
        }
    }
}
