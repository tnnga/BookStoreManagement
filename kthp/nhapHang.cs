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
    public partial class nhapHang : Form
    {
        BLLNhapHang bLLNhapHang = new BLLNhapHang();
        DTONhapHang sp = null;
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
            dgwNhapHang.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwNhapHang.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
    }
}
