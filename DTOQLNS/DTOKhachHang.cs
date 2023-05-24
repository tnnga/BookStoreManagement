using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOQLNS
{
    public class DTOKhachHang
    {
        private string _MaKhachHang;
        private string _TenKhachHang;
        private string _GioiTinh;
        private string _SDT;
        private string _DiaChi;

        public string MaKhachHang { get => _MaKhachHang; set => _MaKhachHang = value; }
        public string TenKhachHang { get => _TenKhachHang; set => _TenKhachHang = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }

        public DTOKhachHang() { }

        public DTOKhachHang(string maKhachHang, string tenKhachHang, string gioiTinh, string sDT, string diaChi)
        {
            _MaKhachHang = maKhachHang;
            _TenKhachHang = tenKhachHang;
            _GioiTinh = gioiTinh;
            _SDT = sDT;
            _DiaChi = diaChi;
        }
    }
}
