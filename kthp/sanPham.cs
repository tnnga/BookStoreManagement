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
        private void ConfigureSP()
        {
            dgwSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwSanPham.Columns[0].Width = 100;
            dgwSanPham.Columns[1].Width = 300;
            dgwSanPham.Columns[2].Width = 200;
            dgwSanPham.Columns[3].Width = 150;
            dgwSanPham.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwSanPham.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
                sp = new DTOSanPham( "", txtTimKiem.Text, 0, "", "", "");
                dgwSanPham.DataSource = bLLSanPham.FindTenSanPham(sp);
                ConfigureSP();
            }
            if (cbTimKiem.SelectedIndex == 1)
            {
                sp = new DTOSanPham(txtTimKiem.Text, "", 0, "", "", "");
                dgwSanPham.DataSource = bLLSanPham.FindMaSanPham(sp);
                ConfigureSP();
            }
            if (cbLoaiSach.SelectedIndex != -1 && txtTimKiem.Text == "" )
            {
                sp = new DTOSanPham("", "", 0, "", cbLoaiSach.Text, "");
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
    }
}
