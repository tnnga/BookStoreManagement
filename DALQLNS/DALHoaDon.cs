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
    public class DALHoaDon : DBConnect
    {
        public bool InsertHoaDon(DTOHoaDon sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into HoaDon(MaHoaDon, TenKhachHang, NgayHoaDon, GioHoaDon, DonGia) values (@MaHoaDon, @TenKhachHang, @NgayHoaDon, @GioHoaDon, @DonGia)", conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", sp.MaHoaDon);
                cmd.Parameters.AddWithValue("@TenKhachHang", sp.TenKhachHang);
                cmd.Parameters.AddWithValue("@NgayHoaDon", sp.NgayHoaDon);
                cmd.Parameters.AddWithValue("@GioHoaDon", sp.GioHoaDon);
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
        public DataTable SelectSanPham()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select MaSach as 'Mã sách',TenSach as 'Tên sách', GiaTien as 'Giá tiền', SoLuongTon as 'Số lượng tồn' from SanPham", conn);
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
        public bool InSertChiTietHoaDon(DTOChiTietHoaDon sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into ChiTietHoaDon(MaHoaDon, TenSanPham, SoLuong) values (@MaHoaDon, @TenSanPham, @SoLuong)", conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", sp.MaHoaDon);
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
