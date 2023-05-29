using DALQLNS;
using DTOQLNS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLQLNS
{
    public class BLLSanPham
    {
        DALSanPham dALSanPham = new DALSanPham();
        public DataTable SelectSanPham()
        {
            DataTable dt = dALSanPham.SelectSanPham();
            return dt;
        }
        public bool InSertSanPham(DTOSanPham sp)
        {
            return dALSanPham.InSertSanPham(sp);
        }
        public DataTable FindMaSanPham(DTOSanPham sp)
        {
            DataTable dt = dALSanPham.FindMaSanPham(sp);
            return dt;
        }
        public DataTable FindTenSanPham(DTOSanPham sp)
        {
            DataTable dt = dALSanPham.FindTenSanPham(sp);
            return dt;
        }
        public DataTable PhanLoaiSanPham(DTOSanPham sp)
        {
            DataTable dt = dALSanPham.PhanLoaiSanPham(sp);
            return dt;
        }
        public bool UpdateSanPham(DTOSanPham sp)
        {
            return dALSanPham.UpdateSanPham(sp);
        }
        public bool DeleteSanPham(DTOSanPham sp)
        {
            return dALSanPham.DeleteSanPham(sp);
        }

        public bool CheckSoLuongSanPhamConHang(DTOSanPham sp)
        {
            return dALSanPham.CheckSoLuongSanPhamConHang(sp);
        }

        public bool UpdateTangSoLuongSanPham(DTOChiTietNhapHang dTOChiTietNhapHang)
        {
            return dALSanPham.UpdateTangSoLuongSanPham(dTOChiTietNhapHang);
        }
        public bool UpdateGiamSoLuongSanPhamTang(DTOChiTietNhapHang dTOChiTietNhapHang)
        {
            return dALSanPham.UpdateGiamSoLuongSanPhamTang(dTOChiTietNhapHang);
        }

        public bool UpdateGiamSoLuongSanPham(DTOChiTietHoaDon dTOChiTietHoaDon)
        {
            return dALSanPham.UpdateGiamSoLuongSanPham(dTOChiTietHoaDon);
        }
        public bool UpdateTangSoLuongSanPhamGiam(DTOChiTietHoaDon dTOChiTietHoaDon)
        {
            return dALSanPham.UpdateTangSoLuongSanPhamGiam(dTOChiTietHoaDon);
        }
    }
}
