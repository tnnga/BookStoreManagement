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
    public class DALSanPham : DBConnect
    {
        public DataTable SelectSanPham()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select MaSach as 'Mã sách',TenSach as 'Tên sách', GiaTien as 'Giá tiền', SoLuongTon as 'Số lượng tồn', LoaiSach as 'Loại sách', NoiDungChinh as 'Nội dung chính' from SanPham", conn);
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

        public bool InSertSanPham(DTOSanPham sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into SanPham(MaSach, TenSach, SoLuongTon, GiaTien, LoaiSach, NoiDungChinh) values (@MaSach, @TenSach, @SoLuongTon, @GiaTien, @LoaiSach, @NoiDungChinh)", conn);
                cmd.Parameters.AddWithValue("@MaSach", sp.MaSach);
                cmd.Parameters.AddWithValue("@TenSach", sp.TenSach);
                cmd.Parameters.AddWithValue("@SoLuongTon", sp.SoLuongTon);
                cmd.Parameters.AddWithValue("@GiaTien", sp.GiaTien);
                cmd.Parameters.AddWithValue("@LoaiSach", sp.LoaiSach);
                cmd.Parameters.AddWithValue("@NoiDungChinh", sp.NoiDungChinh);

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

        public bool UpdateSanPham(DTOSanPham sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE SanPham SET MaSach = @MaSach, TenSach = @TenSach, SoLuongTon = @SoLuongTon, GiaTien =  @GiaTien, LoaiSach = @LoaiSach, NoiDungChinh = @NoiDungChinh WHERE MaSach = @MaSach", conn);
                cmd.Parameters.AddWithValue("@MaSach", sp.MaSach);
                cmd.Parameters.AddWithValue("@TenSach", sp.TenSach);
                cmd.Parameters.AddWithValue("@SoLuongTon", sp.SoLuongTon);
                cmd.Parameters.AddWithValue("@GiaTien", sp.GiaTien);
                cmd.Parameters.AddWithValue("@LoaiSach", sp.LoaiSach);
                cmd.Parameters.AddWithValue("@NoiDungChinh", sp.NoiDungChinh);

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

        public DataTable PhanLoaiSanPham(DTOSanPham sp)
        {
            if (sp.LoaiSach == "(Lựa chọn)")
            {
                SelectSanPham();
                return new DataTable();
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select MaSach as 'Mã sách',TenSach as 'Tên sách', GiaTien as 'Giá tiền', SoLuongTon as 'Số lượng tồn', LoaiSach as 'Loại sách', NoiDungChinh as 'Nội dung chính' from SanPham WHERE LoaiSach LIKE @LoaiSach", conn);
                    cmd.Parameters.AddWithValue("@LoaiSach", "%" + sp.LoaiSach + "%");
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
        }
        public DataTable FindMaSanPham(DTOSanPham sp)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT MaSach as 'Mã Sách', TenSach as 'Tên sách', GiaTien as 'Giá tiền', SoLuongTon as 'Số lượng tồn', LoaiSach as 'Loại sách', NoiDungChinh as 'Nội dung chính' FROM SanPham WHERE MaSach LIKE @MaSach", conn);
                cmd.Parameters.AddWithValue("@MaSach", "%" + sp.MaSach + "%");
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
        public DataTable FindTenSanPham(DTOSanPham sp)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT  MaSach as 'Mã Sách', TenSach as 'Tên sách', GiaTien as 'Giá tiền', SoLuongTon as 'Số lượng tồn', LoaiSach as 'Loại sách', NoiDungChinh as 'Nội dung chính' FROM SanPham WHERE TenSach LIKE @TenSach", conn);
                cmd.Parameters.AddWithValue("@TenSach", "%" + sp.TenSach + "%");
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
        public bool DeleteSanPham(DTOSanPham sp)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM SanPham WHERE MaSach = @MaSach", conn);
                cmd.Parameters.AddWithValue("@MaSach", sp.MaSach);

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
