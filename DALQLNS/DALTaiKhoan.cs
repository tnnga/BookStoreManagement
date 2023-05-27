using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOQLNS;

namespace DALQLNS
{
    public class DALTaiKhoan : DBConnect
    {
        public bool InSertSanPham(DTOTaiKhoan sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into TaiKhoan(TenDangNhap, MatKhau, HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, DiaChi) values (@TenDangNhap, @MatKhau, @HoTen, @GioiTinh, @NgaySinh, @SoDienThoai, @Email, @DiaChi)", conn);
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
    }
}
