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
    public partial class frmNhapHangThemChiTiet : Form
    {
        BLLNhapHang bLLNhapHang = new BLLNhapHang();
        DTOChiTietNhapHang sp = null;
        public string maNhapHang;

        public frmNhapHangThemChiTiet(string maNhapHang)
        {
            this.maNhapHang = maNhapHang;
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
        private void frmNhapHangThemChiTiet_Load(object sender, EventArgs e)
        {
            lblMaHoaDon.Text = maNhapHang;

            sp = new DTOChiTietNhapHang(maNhapHang, "", 0);
            dgwNhapHangThemChiTiet.DataSource = bLLNhapHang.SelectChiTietNhapHang(sp);
            ConfigureSP();
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            nhapHangThemMoiChiTiet hoaDonThemMoiChiTiet = new nhapHangThemMoiChiTiet(maNhapHang);
            hoaDonThemMoiChiTiet.ShowDialog();

            sp = new DTOChiTietNhapHang(maNhapHang, "", 0);
            dgwNhapHangThemChiTiet.DataSource = bLLNhapHang.SelectChiTietNhapHang(sp);
            ConfigureSP();
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            DialogResult resquest = MessageBox.Show("Hoàn tất thêm chi tiết nhập hàng, bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resquest == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
