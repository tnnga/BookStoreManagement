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
    public partial class frmSanPhamChiTiet : Form
    {
        private string maSach;
        private string tenSach;
        private int soLuong;
        private int giaTien;

        public frmSanPhamChiTiet(string maSach, string tenSach, int soLuong, int giaTien)
        {
            InitializeComponent();
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.soLuong = soLuong;
            this.giaTien = giaTien;
        }     

        private void frmSanPhamChiTiet_Load(object sender, EventArgs e)
        {
            lblTenSach.Text = tenSach;
            lblSoLuongTon.Text = soLuong.ToString();
            lblGiaSach.Text = giaTien.ToString();
        }
    }
}
