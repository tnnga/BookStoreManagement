using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALQLNS
{
    public class DALNhapHang : DBConnect
    {
        public DataTable SelectNhapHang()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select MaNhapHang as 'Mã nhập hàng',TenNhanVien as 'Tên nhân viên', NgayNhap as 'Ngày nhập hàng', DonGia as 'Đơn giá' from NhapHang", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool InSertNhapHang(DTONhapHang sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into NhapHang(MaNhapHang, TenNhanVien, NgayNhap, GioNhap, DonGia) values (@MaNhapHang, @TenNhanVien, @NgayNhap, @GioNhap, @DonGia)", conn);
                cmd.Parameters.AddWithValue("@MaNhapHang", sp.MaNhapHang);
                cmd.Parameters.AddWithValue("@TenNhanVien", sp.TenNhanVien);
                cmd.Parameters.AddWithValue("@NgayNhap", sp.NgayNhap);
                cmd.Parameters.AddWithValue("@GioNhap", sp.GioNhap);
                cmd.Parameters.AddWithValue("@DonGia", sp.DonGia);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public DataTable FindMaNhapHang(DTONhapHang sp)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("select MaNhapHang as 'Mã nhập hàng',TenNhanVien as 'Tên nhân viên', NgayNhap as 'Ngày nhập hàng', DonGia as 'Đơn giá' from NhapHang WHERE MaNhapHang LIKE @MaNhapHang", conn);
                cmd.Parameters.AddWithValue("@MaNhapHang", "%" + sp.MaNhapHang + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public DataTable FindTenNhanVien(DTONhapHang sp)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("select MaNhapHang as 'Mã nhập hàng',TenNhanVien as 'Tên nhân viên', NgayNhap as 'Ngày nhập hàng', DonGia as 'Đơn giá' from NhapHang WHERE TenNhanVien LIKE @TenNhanVien", conn);
                cmd.Parameters.AddWithValue("@TenNhanVien", "%" + sp.TenNhanVien + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public DataTable FindNgayNhapHang(DTONhapHang sp)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("select MaNhapHang as 'Mã nhập hàng',TenNhanVien as 'Tên nhân viên', NgayNhap as 'Ngày nhập hàng', DonGia as 'Đơn giá' from NhapHang WHERE NgayNhap LIKE @NgayNhap", conn);
                cmd.Parameters.AddWithValue("@NgayNhap", sp.NgayNhap + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public bool InSertChiTietNhapHang(DTOChiTietNhapHang sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into ChiTietNhapHang(MaNhapHang, TenSanPham, SoLuong) values (@MaNhapHang, @TenSanPham, @SoLuong)", conn);
                cmd.Parameters.AddWithValue("@MaNhapHang", sp.MaNhapHang);
                cmd.Parameters.AddWithValue("@TenSanPham", sp.TenSanPham);
                cmd.Parameters.AddWithValue("@SoLuong", sp.SoLuong);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
