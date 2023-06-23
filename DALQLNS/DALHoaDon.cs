using DTOQLNS;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DALQLNS
{
    public class DALHoaDon : DBConnect
    {
        public bool InsertDonGiaHoaDon(DTOHoaDon dTOHoaDon)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update HoaDon set DonGia =@DonGia WHERE MaHoaDon = @MaHoaDon", conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", dTOHoaDon.MaHoaDon);
                cmd.Parameters.AddWithValue("@DonGia", dTOHoaDon.DonGia);

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

        public bool InsertHoaDon(DTOHoaDon sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into HoaDon(MaHoaDon, MaKhachHang, NgayHoaDon, GioHoaDon) values (@MaHoaDon, @MaKhachHang, @NgayHoaDon, @GioHoaDon)", conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", sp.MaHoaDon);
                cmd.Parameters.AddWithValue("@MaKhachHang", sp.MaKhachHang);
                cmd.Parameters.AddWithValue("@NgayHoaDon", sp.NgayHoaDon);
                cmd.Parameters.AddWithValue("@GioHoaDon", sp.GioHoaDon);

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

        public DataTable TongThanhTien(DTOChiTietHoaDon sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select SUM(SP.GiaTien * CTHD.SoLuong) as 'Thành tiền' from ChiTietHoaDon CTHD INNER JOIN SanPham SP ON CTHD.MaSanPham = SP.MaSach WHERE CTHD.MaHoaDon = @MaHoaDon", conn);

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

        public DataTable SelectChiTietHoaDon(DTOChiTietHoaDon sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select SP.MaSach as 'Mã sách', SP.TenSach as 'Tên sản phẩm', SP.GiaTien as 'Đơn giá', CTHD.SoLuong as 'Số lượng', (SP.GiaTien * CTHD.SoLuong) as 'Thành tiền' from ChiTietHoaDon CTHD INNER JOIN SanPham SP ON CTHD.MaSanPham = SP.MaSach WHERE CTHD.MaHoaDon = @MaHoaDon", conn);
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
                SqlCommand cmd = new SqlCommand("DELETE FROM ChiTietHoaDon WHERE MaSanPham = @MaSanPham and MaHoaDon = @MaHoaDon", conn);
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
                SqlCommand cmd = new SqlCommand("UPDATE ChiTietHoaDon SET MaSanPham = @MaSanPham, SoLuong = @SoLuong WHERE MaSanPham = @MaSanPhamOld AND MaHoaDon = @MaHoaDon", conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", sp.MaHoaDon);
                cmd.Parameters.AddWithValue("@MaSanPham", sp.MaSanPham);
                cmd.Parameters.AddWithValue("@SoLuong", sp.SoLuong);
                cmd.Parameters.AddWithValue("@MaSanPhamOld", sp.MaSanPhamOld);

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
