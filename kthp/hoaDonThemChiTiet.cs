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
    public partial class frmHoaDonThemChiTiet : Form
    {
        BLLHoaDon bLLHoaDon = new BLLHoaDon();
        DTOChiTietHoaDon sp = null;
        public string maHoaDon;

        public frmHoaDonThemChiTiet(string maHoaDon)
        {
            this.maHoaDon = maHoaDon;
            InitializeComponent();
        }

        private void ConfigureSP()
        {
            dgwHoaDonThemChiTiet.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwHoaDonThemChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwHoaDonThemChiTiet.Columns[0].Width = 150;
            dgwHoaDonThemChiTiet.Columns[1].Width = 150;
            dgwHoaDonThemChiTiet.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwHoaDonThemChiTiet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void frmHoaDonThemChiTiet_Load(object sender, EventArgs e)
        {
            lblMaHoaDon.Text = maHoaDon;

            sp = new DTOChiTietHoaDon(maHoaDon, "", 0);
            dgwHoaDonThemChiTiet.DataSource = bLLHoaDon.SelectChiTietHoaDon(sp);
            ConfigureSP();
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {

            HoaDonThemMoiChiTiet hoaDonThemMoiChiTiet = new HoaDonThemMoiChiTiet(maHoaDon);
            hoaDonThemMoiChiTiet.ShowDialog();

            sp = new DTOChiTietHoaDon(maHoaDon, "", 0);
            dgwHoaDonThemChiTiet.DataSource = bLLHoaDon.SelectChiTietHoaDon(sp);
            ConfigureSP();
        }
        private void btnHoanTat_Click_1(object sender, EventArgs e)
        {
            DialogResult resquest = MessageBox.Show("Hoàn tất thêm chi tiết hóa đơn, bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resquest == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
