using DTOQLNS;
using DALQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLLQLNS
{
    public class BLLHoaDon
    {
        DALHoaDon dALHoaDon = new DALHoaDon();
        public bool InsertHoaDon(DTOHoaDon sp)
        {
            return dALHoaDon.InsertHoaDon(sp);
        }
        public bool InsertChiTietHoaDon(DTOChiTietHoaDon sp)
        {
            return dALHoaDon.InSertChiTietHoaDon(sp);
        }
        public DataTable SelectChiTietHoaDon(DTOChiTietHoaDon sp)
        {
            DataTable dt = dALHoaDon.SelectChiTietHoaDon(sp);
            return dt;
        }
        public bool UpdateHoaDon(DTOHoaDon sp)
        {
            return dALHoaDon.UpdateHoaDon(sp);
        }
        public bool DeleteChiTietHoaDon(DTOChiTietHoaDon sp)
        {
            return dALHoaDon.DeleteChiTietHoaDon(sp);

        }
        public bool DeleteHoaDon(DTOHoaDon sp)
        {
            return dALHoaDon.DeleteHoaDon(sp);
        }
        public bool UpdateChiTietHoaDon(DTOChiTietHoaDon sp)
        {
            return dALHoaDon.UpdateChiTietHoaDon(sp);
        }
        public bool DeleteChiTietHoaDonAll(DTOChiTietHoaDon sp)
        {
            return dALHoaDon.DeleteChiTietHoaDonAll(sp);

        }
        public DataTable TongThanhTien(DTOChiTietHoaDon sp)
        {
            DataTable dt = dALHoaDon.TongThanhTien(sp);
            return dt;
        }
        public bool InsertDonGiaHoaDon(DTOHoaDon dTOHoaDon)
        {
            return dALHoaDon.InsertDonGiaHoaDon(dTOHoaDon);
        }


    }
}
