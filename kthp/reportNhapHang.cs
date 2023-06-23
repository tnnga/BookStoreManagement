using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kthp
{
    public partial class reportNhapHang : Form
    {
        private string cTHD_MaNhapHang;

        public reportNhapHang(string cTHD_MaNhapHang)
        {
            InitializeComponent();
            this.cTHD_MaNhapHang = cTHD_MaNhapHang;
        }

        private void crwNhapHang_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MSI\MS_SQLSERVER;Initial Catalog=KTHP;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT NhapHang.MaNhapHang, ChiTietNhapHang.MaSanPham, ChiTietNhapHang.SoLuong, SanPham.TenSach, NhapHang.TenNhanVien, NhapHang.NgayNhap, NhapHang.GioNhap, NhapHang.DonGia FROM ChiTietNhapHang INNER JOIN NhapHang ON ChiTietNhapHang.MaNhapHang = NhapHang.MaNhapHang INNER JOIN SanPham ON ChiTietNhapHang.MaSanPham = SanPham.MaSach WHERE ChiTietNhapHang.MaNhapHang = @MaNhapHang", conn);
            cmd.Parameters.AddWithValue("@MaNhapHang", cTHD_MaNhapHang);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);

            crNhapHang rpNhapHang = new crNhapHang();
            rpNhapHang.SetDataSource(ds.Tables[0]);
            crwNhapHang.ReportSource = rpNhapHang;
        }
    }
}
