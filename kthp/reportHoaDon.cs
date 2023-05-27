using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLQLNS;
using DTOQLNS;
using System.Data.SqlClient;


namespace kthp
{
    public partial class reportHoaDon : Form
    {
        private string cTHD_MaHoaDon;

        public reportHoaDon(string cTHD_MaHoaDon)
        {
            InitializeComponent();
            this.cTHD_MaHoaDon = cTHD_MaHoaDon;
        }

        

        private void crw_HoaDon_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=MSI\MS_SQLSERVER;Initial Catalog=KTHP;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT HoaDon.NgayHoaDon, HoaDon.GioHoaDon, HoaDon.DonGia, ChiTietHoaDon.MaHoaDon, ChiTietHoaDon.MaSanPham, ChiTietHoaDon.SoLuong, SanPham.TenSach, KhachHang.TenKhachHang, SanPham.GiaTien FROM ChiTietHoaDon INNER JOIN HoaDon ON ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon INNER JOIN KhachHang ON HoaDon.MaKhachHang = KhachHang.MaKhachHang INNER JOIN SanPham ON ChiTietHoaDon.MaSanPham = SanPham.MaSach WHERE ChiTietHoaDon.MaHoaDon = @MaHoaDon", conn);
            cmd.Parameters.AddWithValue("@MaHoaDon", cTHD_MaHoaDon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);

            crHoaDon rpHoaDon = new crHoaDon();
            rpHoaDon.SetDataSource(ds.Tables[0]);
            crw_HoaDon.ReportSource = rpHoaDon;

            
        }
    }
}
