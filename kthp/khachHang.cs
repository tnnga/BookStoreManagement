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
    public partial class khachHang : Form
    {
        private string maKhachHang;
        private string tenKhachHang;
        private string gioiTinh;
        private string soDienThoai;
        private string diaChi;

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
        public bool UpdateKhachHang(string maKhachHang, string tenKhachHang, string gioiTinh, string soDienThoai, string diaChi)
        {
            dcKTHPDataContext data = new dcKTHPDataContext();

            KhachHang sp = (from khachHang in data.KhachHangs
                          where khachHang.MaKhachHang == maKhachHang.Trim()
                          select khachHang).Single<KhachHang>();

            sp.TenKhachHang = tenKhachHang;
            sp.GioiTinh = gioiTinh;
            sp.SDT = soDienThoai;
            sp.DiaChi = diaChi;

            data.SubmitChanges();
            return true;
        }
        public bool DeleteKhachHang(string maKhachHang)
        {
            dcKTHPDataContext data = new dcKTHPDataContext();

            KhachHang sp = (from khachHang in data.KhachHangs
                          where khachHang.MaKhachHang == maKhachHang.Trim()
                          select khachHang).Single<KhachHang>();
            data.KhachHangs.DeleteOnSubmit(sp);
            data.SubmitChanges();

            return true;
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

        private void capNhatThongTinKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dgwKhachHang.CurrentCell.RowIndex;

            maKhachHang = dgwKhachHang.Rows[rowIndex].Cells[0].Value.ToString().Trim();
            tenKhachHang = dgwKhachHang.Rows[rowIndex].Cells[1].Value.ToString().Trim();
            gioiTinh = dgwKhachHang.Rows[rowIndex].Cells[2].Value.ToString().Trim();
            soDienThoai = dgwKhachHang.Rows[rowIndex].Cells[3].Value.ToString().Trim();
            diaChi = dgwKhachHang.Rows[rowIndex].Cells[4].Value.ToString().Trim();

            khachHangCapNhat frmKhachHangCapNhat = new khachHangCapNhat(maKhachHang, tenKhachHang, gioiTinh, soDienThoai, diaChi);
            frmKhachHangCapNhat.ShowDialog();

            dcKTHPDataContext data = new dcKTHPDataContext();

            var listKhachHang = from khachhang in data.KhachHangs
                                select new { khachhang.MaKhachHang, khachhang.TenKhachHang, khachhang.GioiTinh, khachhang.SDT, khachhang.DiaChi };

            dgwKhachHang.DataSource = listKhachHang;
            ConfigureSP();
        }

        private void xoaThongTinKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dgwKhachHang.CurrentCell.RowIndex;

            maKhachHang = dgwKhachHang.Rows[rowIndex].Cells[0].Value.ToString().Trim();

            var res = MessageBox.Show("Bạn có chắc chắn muốn xoá thông tin khách hàng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                if (DeleteKhachHang(maKhachHang))
                {
                    MessageBox.Show("Xóa thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dcKTHPDataContext data = new dcKTHPDataContext();

                    var listKhachHang = from khachhang in data.KhachHangs
                                        select new { khachhang.MaKhachHang, khachhang.TenKhachHang, khachhang.GioiTinh, khachhang.SDT, khachhang.DiaChi };

                    dgwKhachHang.DataSource = listKhachHang;
                    ConfigureSP();
                }
                else
                {
                    MessageBox.Show("Xóa thông tin khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
