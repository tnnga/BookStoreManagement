using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOQLNS
{
    public class DTOSanPham
    {
        private string _MaSach;
        private string _TenSach;
        private int _SoLuongTon;
        private string _GiaTien;
        private string _LoaiSach;
        private string _NoiDungChinh;

        public string MaSach
        {
            get { return _MaSach; }
            set { _MaSach = value; }
        }
        public string TenSach
        {
            set { _TenSach = value; }
            get { return _TenSach; }
        }
        public int SoLuongTon
        {
            get { return _SoLuongTon; }
            set { _SoLuongTon = value; }
        }
        public string GiaTien
        {
            get { return _GiaTien; }
            set { _GiaTien = value; }
        }
        public string LoaiSach
        {
            get { return _LoaiSach; }
            set { _LoaiSach = value; }
        }
        public string NoiDungChinh
        {
            get { return _NoiDungChinh; }
            set { _NoiDungChinh = value; }
        }

        public DTOSanPham()
        {
        }
        public DTOSanPham(string maSach, string tenSach, int soLuongTon, string giaTien, string loaiSach, string noiDungChinh)
        {
            _MaSach = maSach;
            _TenSach = tenSach;
            _SoLuongTon = soLuongTon;
            _GiaTien = giaTien;
            _LoaiSach = loaiSach;
            _NoiDungChinh = noiDungChinh;
        }
    }
}
