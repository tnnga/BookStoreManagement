using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOQLNS
{

    public class DTOTaiKhoan
    {
        private string _TenDangNhap;
        private string _MatKhau;
        private string _HoTen;
        private string _GioiTinh;
        private string _NgaySinh;
        private string _SoDienThoai;
        private string _Email;
        private string _DiaChi;

        public string TenDangNhap { get => _TenDangNhap; set => _TenDangNhap = value; }
        public string MatKhau { get => _MatKhau; set => _MatKhau = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string SoDienThoai { get => _SoDienThoai; set => _SoDienThoai = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }

        public DTOTaiKhoan(string tenDangNhap, string matKhau, string hoTen, string gioiTinh, string ngaySinh, string soDienThoai, string email, string diaChi)
        {
            _TenDangNhap = tenDangNhap;
            _MatKhau = matKhau;
            _HoTen = hoTen;
            _GioiTinh = gioiTinh;
            _NgaySinh = ngaySinh;
            _SoDienThoai = soDienThoai;
            _Email = email;
            _DiaChi = diaChi;
        }
        public DTOTaiKhoan(string tenDangNhap, string hoTen, string gioiTinh, string ngaySinh, string soDienThoai, string email, string diaChi)
        {
            _TenDangNhap = tenDangNhap;
            _HoTen = hoTen;
            _GioiTinh = gioiTinh;
            _NgaySinh = ngaySinh;
            _SoDienThoai = soDienThoai;
            _Email = email;
            _DiaChi = diaChi;
        }
    }
}
