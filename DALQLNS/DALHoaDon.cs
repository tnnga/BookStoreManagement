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
                SqlCommand cmd = new SqlCommand("insert into HoaDon(MaHoaDon, MaKhachHang, NgayHoaDon, GioHoaDon, DonGia) values (@MaHoaDon, @MaKhachHang, @NgayHoaDon, @GioHoaDon, @DonGia)", conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", sp.MaHoaDon);
                cmd.Parameters.AddWithValue("@MaKhachHang", sp.MaKhachHang);
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
        public bool InSertChiTietHoaDon(DTOChiTietHoaDon sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into ChiTietHoaDon(MaHoaDon, MaSanPham, SoLuong) values (@MaHoaDon, @MaSanPham, @SoLuong)", conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", sp.MaHoaDon);
                cmd.Parameters.AddWithValue("@MaSanPham", sp.MaSanPham);
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

        public DataTable SelectChiTietHoaDon(DTOChiTietHoaDon sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select MaSanPham as 'Mã sản phẩm', SoLuong as 'Số lượng' from ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon", conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", sp.MaHoaDon);
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
        public bool DeleteChiTietHoaDon(DTOChiTietHoaDon sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM ChiTietHoaDon WHERE MaSanPham = @MaSanPham && MaHoaDon = @MaHoaDon", conn);
                cmd.Parameters.AddWithValue("@MaSanPham", sp.MaSanPham);
                cmd.Parameters.AddWithValue("@MaHoaDon", sp.MaHoaDon);

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
        public bool UpdateHoaDon(DTOHoaDon sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE HoaDon SET MaHoaDon = @MaHoaDon, MaKhachHang = @MaKhachHang, NgayHoaDon = @NgayHoaDon, GioHoaDon =  @GioHoaDon, DonGia = @DonGia WHERE MaHoaDon = @MaHoaDon", conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", sp.MaHoaDon);
                cmd.Parameters.AddWithValue("@MaKhachHang", sp.MaKhachHang);
                cmd.Parameters.AddWithValue("@NgayHoaDon", sp.NgayHoaDon);
                cmd.Parameters.AddWithValue("@GioHoaDon", sp.GioHoaDon);
                cmd.Parameters.AddWithValue("@DonGia", sp.DonGia);

                var kq = cmd.ExecuteNonQuery();

                if (kq > 0)
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
        public bool UpdateChiTietHoaDon(DTOChiTietHoaDon sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ChiTietHoaDon SET MaSanPham = @MaSanPham, SoLuong = @SoLuong WHERE MaSanPham = @MaSanPham AND MaHoaDon = @MaHoaDon", conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", sp.MaHoaDon);
                cmd.Parameters.AddWithValue("@MaSanPham", sp.MaSanPham);
                cmd.Parameters.AddWithValue("@SoLuong", sp.SoLuong);

                var kq = cmd.ExecuteNonQuery();

                if (kq > 0)
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
        public bool DeleteHoaDon(DTOHoaDon sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM HoaDon WHERE MaHoaDon = @MaHoaDon", conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", sp.MaHoaDon);

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
        public bool DeleteChiTietHoaDonAll(DTOChiTietHoaDon sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon", conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", sp.MaHoaDon);

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
