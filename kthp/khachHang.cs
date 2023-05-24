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
    public partial class khachHang : Form
    {
        public khachHang()
        {
            InitializeComponent();
        }

        
        public void ConfigureSP()
        {
            dgwKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgwKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgwKhachHang.Columns[2].HeaderText = "Giới tính";
            dgwKhachHang.Columns[3].HeaderText = "Số điện thoại";
            dgwKhachHang.Columns[4].HeaderText = "Địa chỉ";

            dgwKhachHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwKhachHang.Columns[0].Width = 100;
            dgwKhachHang.Columns[1].Width = 200;
            dgwKhachHang.Columns[2].Width = 100;
            dgwKhachHang.Columns[3].Width = 150;
            dgwKhachHang.Columns[4].Width = 180;

            dgwKhachHang.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwKhachHang.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void khachHang_Load(object sender, EventArgs e)
        {

            dcKTHPDataContext data = new dcKTHPDataContext();

            var listKhachHang = from khachhang in data.KhachHangs
                                select new {khachhang.MaKhachHang, khachhang.TenKhachHang, khachhang.GioiTinh, khachhang.SDT, khachhang.DiaChi};

            dgwKhachHang.DataSource = listKhachHang;
            ConfigureSP();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbTimKiemTheo.SelectedIndex == 1)
            {
                dcKTHPDataContext data = new dcKTHPDataContext();

                var query = data.KhachHangs.Where(s => s.MaKhachHang.Contains(txtTimKiem.Text));
                dgwKhachHang.DataSource = query;
                dgwKhachHang.Refresh();
                ConfigureSP();
            }
            else if (cbTimKiemTheo.SelectedIndex == 2)
            {
                dcKTHPDataContext data = new dcKTHPDataContext();

                var query = data.KhachHangs.Where(s => s.TenKhachHang.Contains(txtTimKiem.Text));
                dgwKhachHang.DataSource = query;
                dgwKhachHang.Refresh();
                ConfigureSP();
            }
            else if (cbTimKiemTheo.SelectedIndex == 3)
            {
                dcKTHPDataContext data = new dcKTHPDataContext();

                var query = data.KhachHangs.Where(s => s.SDT.Contains(txtTimKiem.Text));
                dgwKhachHang.DataSource = query;
                dgwKhachHang.Refresh();
                ConfigureSP();
            }
            else if ((cbTimKiemTheo.SelectedIndex == 0 && txtTimKiem.Text == "") || (cbTimKiemTheo.Text == "" && txtTimKiem.Text == ""))
            {
                if (cbBoLoc.SelectedIndex == 1)
                {
                    dcKTHPDataContext data = new dcKTHPDataContext();

                    var query = data.KhachHangs.Where(s => s.GioiTinh.Equals("Nam"));
                    dgwKhachHang.DataSource = query;
                    dgwKhachHang.Refresh();
                    ConfigureSP();
                }
                else if (cbBoLoc.SelectedIndex == 2)
                {
                    dcKTHPDataContext data = new dcKTHPDataContext();

                    var query = data.KhachHangs.Where(s => s.GioiTinh.Equals("Nữ"));
                    dgwKhachHang.DataSource = query;
                    dgwKhachHang.Refresh();
                    ConfigureSP();
                }
                else if (cbBoLoc.SelectedIndex == 3)
                {
                    dcKTHPDataContext data = new dcKTHPDataContext();

                    var query = from khachhang in data.KhachHangs
                                orderby khachhang.TenKhachHang ascending
                                select khachhang;

                    dgwKhachHang.DataSource = query;
                    dgwKhachHang.Refresh();
                    ConfigureSP();
                }
            }
            if ((cbTimKiemTheo.Text == "" && cbBoLoc.Text == "") ||
                (cbTimKiemTheo.SelectedIndex == 0 && cbBoLoc.Text == "") ||
                (cbBoLoc.SelectedIndex == 0 && cbTimKiemTheo.Text == "") ||
                (cbTimKiemTheo.SelectedIndex == 0 && cbBoLoc.Text == "(Lựa chọn)"))
            {
                dcKTHPDataContext data = new dcKTHPDataContext();

                var listKhachHang = from khachhang in data.KhachHangs
                                    select new { khachhang.MaKhachHang, khachhang.TenKhachHang, khachhang.GioiTinh, khachhang.SDT, khachhang.DiaChi};

                dgwKhachHang.DataSource = listKhachHang;
                ConfigureSP();
            }
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            frmKhachHangThemMoi frmKhachHangThemMoi = new frmKhachHangThemMoi();
            frmKhachHangThemMoi.ShowDialog();

            dcKTHPDataContext data = new dcKTHPDataContext();

            var listKhachHang = from khachhang in data.KhachHangs
                                select new { khachhang.MaKhachHang, khachhang.TenKhachHang, khachhang.GioiTinh, khachhang.SDT, khachhang.DiaChi};

            dgwKhachHang.DataSource = listKhachHang;
            ConfigureSP();
        }
    }
}
