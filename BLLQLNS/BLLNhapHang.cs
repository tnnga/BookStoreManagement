using DALQLNS;
using DTOQLNS;
using System.Data;

namespace BLLQLNS
{
    public class BLLNhapHang
    {
        DALNhapHang dALNhapHang = new DALNhapHang();
        public DataTable SelectNhapHang()
        {
            DataTable dt = dALNhapHang.SelectNhapHang();
            return dt;
        }
        public bool InSertNhapHang(DTONhapHang sp)
        {
            return dALNhapHang.InSertNhapHang(sp);
        }
        public DataTable FindMaNhapHang(DTONhapHang sp)
        {
            DataTable dt = dALNhapHang.FindMaNhapHang(sp);
            return dt;
        }
        public DataTable FindTenNhanVien(DTONhapHang sp)
        {
            DataTable dt = dALNhapHang.FindTenNhanVien(sp);
            return dt;
        }
        public DataTable FindNgayNhapHang(DTONhapHang sp)
        {
            DataTable dt = dALNhapHang.FindNgayNhapHang(sp);
            return dt;
        }
        public bool UpdateNhapHang(DTONhapHang sp)
        {
            return dALNhapHang.UpdateNhapHang(sp);
        }
        public bool DeleteNhapHang(DTONhapHang sp)
        {
            return dALNhapHang.DeleteNhapHang(sp);
        }
        public bool InsertChiTietNhapHang(DTOChiTietNhapHang sp)
        {
            return dALNhapHang.InSertChiTietNhapHang(sp);
        }
        public DataTable SelectChiTietNhapHang(DTOChiTietNhapHang sp)
        {
            DataTable dt = dALNhapHang.SelectChiTietNhapHang(sp);
            return dt;
        }
        public bool DeleteChiTietNhapHang(DTOChiTietNhapHang sp)
        {
            return dALNhapHang.DeleteChiTietNhapHang(sp);
        }
        public bool UpdateChiTietNhapHang(DTOChiTietNhapHang sp)
        {
            return dALNhapHang.UpdateChiTietNhapHang(sp);
        }
        public bool DeleteChiTietNhapHangAll(DTOChiTietNhapHang sp)
        {
            return dALNhapHang.DeleteChiTietNhapHangAll(sp);
        }
    }
}
