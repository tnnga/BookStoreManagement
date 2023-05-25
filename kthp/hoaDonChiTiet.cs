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
    public partial class hoaDonChiTiet : Form
    {
        BLLHoaDon bLLHoaDon = new BLLHoaDon();
        DTOChiTietHoaDon sp = null;
        private string maHoaDon;
        public hoaDonChiTiet(string maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
        }
        private void ConfigureSP()
        {
            dgwChiTietHoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwChiTietHoaDon.Columns[0].Width = 200;
            dgwChiTietHoaDon.Columns[1].Width = 150;
            dgwChiTietHoaDon.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwChiTietHoaDon.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
        private void hoaDonChiTiet_Load(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = maHoaDon;
            sp = new DTOChiTietHoaDon(txtMaHoaDon.Text, "", 0);
            dgwChiTietHoaDon.DataSource = bLLHoaDon.SelectChiTietHoaDon(sp);
            ConfigureSP();
        }
    }
}
