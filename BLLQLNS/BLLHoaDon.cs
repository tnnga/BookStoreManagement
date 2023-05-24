using DTOQLNS;
using DALQLNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
