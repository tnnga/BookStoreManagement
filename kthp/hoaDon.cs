using BLLQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kthp
{
    public partial class hoaDon : Form
    {
        public hoaDon()
        {
            InitializeComponent();
        }

        public void ConfigureSP()
        {
            dgwHoaDon.Columns[0].HeaderText = "Mã hoá đơn";
            dgwHoaDon.Columns[1].HeaderText = "Tên khách hàng";
            dgwHoaDon.Columns[2].HeaderText = "Ngày lập hoá đơn";
            dgwHoaDon.Columns[3].HeaderText = "Giờ lập hóa đơn";
            dgwHoaDon.Columns[4].HeaderText = "Đơn giá";

            dgwHoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwHoaDon.Columns[0].Width = 100;
            dgwHoaDon.Columns[1].Width = 200;
            dgwHoaDon.Columns[2].Width = 150;
            dgwHoaDon.Columns[3].Width = 150;
            dgwHoaDon.Columns[4].Width = 150;

            dgwHoaDon.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgwHoaDon.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void hoaDon_Load(object sender, EventArgs e)
        {
            // Khai bao du lieu
            dcKTHPDataContext data = new dcKTHPDataContext();

            var listHoaDon = from hoadon in data.HoaDons
                             select new {hoadon.MaHoaDon, hoadon.TenKhachHang, hoadon.NgayHoaDon, hoadon.GioHoaDon, hoadon.DonGia};   
            
            dgwHoaDon.DataSource = listHoaDon;
            ConfigureSP();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            if (cbTimKiemTheo.SelectedIndex == 1)
            {
                dcKTHPDataContext data = new dcKTHPDataContext();

                var query = data.HoaDons.Where(s => s.MaHoaDon.Contains(txtTimKiem.Text));
                dgwHoaDon.DataSource = query;
                dgwHoaDon.Refresh();
                ConfigureSP();
            }
            else if (cbTimKiemTheo.SelectedIndex == 2)
            {
                dcKTHPDataContext data = new dcKTHPDataContext();

                var query = data.HoaDons.Where(s => s.TenKhachHang.Contains(txtTimKiem.Text));
                dgwHoaDon.DataSource = query;
                dgwHoaDon.Refresh();
                ConfigureSP();
            }
            else if (cbTimKiemTheo.SelectedIndex == 3)
            {
                dcKTHPDataContext data = new dcKTHPDataContext();

                var query = data.HoaDons.Where(s => s.NgayHoaDon.Contains(txtTimKiem.Text));
                dgwHoaDon.DataSource = query;
                dgwHoaDon.Refresh();
                ConfigureSP();
            }
            else if ((cbTimKiemTheo.SelectedIndex == 0 && txtTimKiem.Text == "") || (cbTimKiemTheo.Text == "" && txtTimKiem.Text == ""))
            {
                if (cbBoLoc.SelectedIndex == 1)
                {
                    dcKTHPDataContext data = new dcKTHPDataContext();

                    var query = data.HoaDons.Where(s => s.DonGia == (data.HoaDons.Max(t => t.DonGia)));

                    dgwHoaDon.DataSource = query;
                    dgwHoaDon.Refresh();
                    ConfigureSP();
                }
                else if (cbBoLoc.SelectedIndex == 2)
                {
                    dcKTHPDataContext data = new dcKTHPDataContext();

                    var query = data.HoaDons.Where(s => s.DonGia == (data.HoaDons.Min(t => t.DonGia)));

                    dgwHoaDon.DataSource = query;
                    dgwHoaDon.Refresh();
                    ConfigureSP();
                }
                else if (cbBoLoc.SelectedIndex == 3)
                {
                    dcKTHPDataContext data = new dcKTHPDataContext();

                    // Neu tach ten ra thi cuc lam 
                    var query = from hd in data.HoaDons
                                orderby hd.TenKhachHang ascending
                                select hd;

                    dgwHoaDon.DataSource = query;
                    dgwHoaDon.Refresh();
                    ConfigureSP();
                }
                else if (cbBoLoc.SelectedIndex == 4)
                {
                    dcKTHPDataContext data = new dcKTHPDataContext();

                    var query = from hd in data.HoaDons
                                orderby hd.DonGia ascending
                                select hd;

                    dgwHoaDon.DataSource = query;
                    dgwHoaDon.Refresh();
                    ConfigureSP();
                }
                else if (cbBoLoc.SelectedIndex == 5)
                {
                    dcKTHPDataContext data = new dcKTHPDataContext();

                    var query = from hd in data.HoaDons
                                orderby hd.DonGia descending
                                select hd;

                    dgwHoaDon.DataSource = query;
                    dgwHoaDon.Refresh();
                    ConfigureSP();
                }
            }

            if ((cbTimKiemTheo.Text == "" && cbBoLoc.Text == "") ||
                (cbTimKiemTheo.Text == "(Lựa chọn)" && cbBoLoc.Text == "") ||
                (cbBoLoc.Text == "(Lựa chọn)" && cbTimKiemTheo.Text == "") ||
                (cbTimKiemTheo.Text == "(Lựa chọn)" && cbBoLoc.Text == "(Lựa chọn)"))
            {
                dcKTHPDataContext data = new dcKTHPDataContext();

                var listHoaDon = from hoadon in data.HoaDons
                                 select new { hoadon.MaHoaDon, hoadon.TenKhachHang, hoadon.NgayHoaDon, hoadon.GioHoaDon, hoadon.DonGia };

                dgwHoaDon.DataSource = listHoaDon;
                ConfigureSP();
            }
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDonThemMoi frmHoaDonThemMoi = new frmHoaDonThemMoi();
            frmHoaDonThemMoi.ShowDialog();

            dcKTHPDataContext data = new dcKTHPDataContext();

            var listHoaDon = from hoadon in data.HoaDons
                             select new { hoadon.MaHoaDon, hoadon.TenKhachHang, hoadon.NgayHoaDon, hoadon.GioHoaDon, hoadon.DonGia};

            dgwHoaDon.DataSource = listHoaDon;
            ConfigureSP();
        }
    }
}
