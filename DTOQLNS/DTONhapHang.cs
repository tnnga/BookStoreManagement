namespace DTOQLNS
{
    public class DTONhapHang
    {
        private string _MaNhapHang;
        private string _TenNhanVien;
        private string _NgayNhap;
        private string _GioNhap;
        private float _DonGia;

        public string MaNhapHang
        {
            get { return _MaNhapHang; }
            set { _MaNhapHang = value; }
        }
        public string TenNhanVien
        {
            set { _TenNhanVien = value; }
            get { return _TenNhanVien; }
        }
        public string NgayNhap
        {
            get { return _NgayNhap; }
            set { _NgayNhap = value; }
        }
        public string GioNhap
        {
            get { return _GioNhap; }
            set { _GioNhap = value; }
        }
        public float DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }


        public DTONhapHang()
        {
        }

        public DTONhapHang(string maNhapHang, string tenNhanVien, string ngayNhap, string gioNhap)
        {
            _MaNhapHang = maNhapHang;
            _TenNhanVien = tenNhanVien;
            _NgayNhap = ngayNhap;
            _GioNhap = gioNhap;
        }

        public DTONhapHang(string maNhapHang, string tenNhanVien, string ngayNhap, string gioNhap, float donGia)
        {
            _MaNhapHang = maNhapHang;
            _TenNhanVien = tenNhanVien;
            _NgayNhap = ngayNhap;
            _GioNhap = gioNhap;
            _DonGia = donGia;
        }
    }
    public class DTOChiTietNhapHang
    {
        private string _MaNhapHang;
        private string _MaSanPhamOld;
        private string _MaSanPham;
        private int _SoLuong;

        public string MaNhapHang { get => _MaNhapHang; set => _MaNhapHang = value; }
        public string MaSanPham { get => _MaSanPham; set => _MaSanPham = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public string MaSanPhamOld { get => _MaSanPhamOld; set => _MaSanPhamOld = value; }

        public DTOChiTietNhapHang(string maNhapHang, string maSanPhamOld, string maSanPham, int soLuong)
        {
            _MaNhapHang = maNhapHang;
            _MaSanPham = maSanPham;
            _SoLuong = soLuong;
            _MaSanPhamOld = maSanPhamOld;
        }
    }
}
