using DALQLNS;
using DTOQLNS;
using System.Data;

namespace BLLQLNS
{
    public class BLLTaiKhoan
    {
        DALTaiKhoan dALTaiKhoan = new DALTaiKhoan();
        public bool InSertTaiKhoan(DTOTaiKhoan sp)
        {
            return dALTaiKhoan.InSertTaiKhoan(sp);
        }
        public bool LoginTaiKhoan(DTOTaiKhoan sp)
        {
            return dALTaiKhoan.LoginTaiKhoan(sp);
        }
        public bool DoiMatKhau(DTOTaiKhoan sp)
        {
            return dALTaiKhoan.DoiMatKhau(sp);
        }
        public bool UpdateTaiKhoan(DTOTaiKhoan sp)
        {
            return dALTaiKhoan.UpdateTaiKhoan(sp);
        }
        public bool UpdateTaiKhoanAll(DTOTaiKhoan sp)
        {
            return dALTaiKhoan.UpdateTaiKhoanAll(sp);
        }
        public DataTable SelectTaiKhoan(DTOTaiKhoan sp)
        {
            DataTable dt = dALTaiKhoan.SelectTaiKhoan(sp);
            return dt;
        }
    }
}
