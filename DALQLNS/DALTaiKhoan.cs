using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOQLNS;

namespace DALQLNS
{
    public class DALTaiKhoan : DBConnect
    {

        public bool InSertTaiKhoan(DTOTaiKhoan sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into TaiKhoan(TenDangNhap, MatKhau, HoTen, GioiTinh, NgaySinh, SDT, Email, DiaChi) values (@TenDangNhap, @MatKhau, @HoTen, @GioiTinh, @NgaySinh, @SoDienThoai, @Email, @DiaChi)", conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", sp.TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", sp.MatKhau);
                cmd.Parameters.AddWithValue("@HoTen", sp.HoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", sp.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", sp.NgaySinh);
                cmd.Parameters.AddWithValue("@SoDienThoai", sp.SoDienThoai);
                cmd.Parameters.AddWithValue("@Email", sp.Email);
                cmd.Parameters.AddWithValue("@DiaChi", sp.DiaChi);

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

        public bool UpdateTaiKhoan(DTOTaiKhoan sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update TaiKhoan set MatKhau = @MatKhau where TenDangNhap = @TenDangNhap", conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", sp.TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", sp.MatKhau);

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
        public bool LoginTaiKhoan(DTOTaiKhoan sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select TenDangNhap, MatKhau from TaiKhoan where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau", conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", sp.TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", sp.MatKhau);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    cmd.Dispose();
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
        public bool DoiMatKhau(DTOTaiKhoan sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select TenDangNhap, Email from TaiKhoan where TenDangNhap = @TenDangNhap and Email = @Email", conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", sp.TenDangNhap);
                cmd.Parameters.AddWithValue("@Email", sp.Email);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmd.Dispose();
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
