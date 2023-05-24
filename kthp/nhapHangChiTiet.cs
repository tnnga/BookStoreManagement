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
    public partial class nhapHangChiTiet : Form
    {
        BLLNhapHang bLLNhapHang = new BLLNhapHang();
        DTOChiTietNhapHang sp = null;
        private string maNhapHang;

        public nhapHangChiTiet(string maNhapHang)
        {
            InitializeComponent();
            this.maNhapHang = maNhapHang;
        }
        private void ConfigureSP()
        {
            dgwChiTietNhapHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwChiTietNhapHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwChiTietNhapHang.Columns[0].Width = 200;
            dgwChiTietNhapHang.Columns[1].Width = 150;
            dgwChiTietNhapHang.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwChiTietNhapHang.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
        private void nhapHangChiTiet_Load(object sender, EventArgs e)
        {
            txtMaNhapHang.Text = maNhapHang;
            sp = new DTOChiTietNhapHang(txtMaNhapHang.Text, "", 0);
            dgwChiTietNhapHang.DataSource = bLLNhapHang.SelectChiTietNhapHang(sp);
            ConfigureSP();
        }
    }
}
