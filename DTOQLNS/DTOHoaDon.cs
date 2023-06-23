namespace DTOQLNS
{
    public class DTOHoaDon
    {
        private string _MaHoaDon;
        private string _MaKhachHang;
        private string _NgayHoaDon;
        private string _GioHoaDon;
        private float _DonGia;


        public string MaHoaDon { get => _MaHoaDon; set => _MaHoaDon = value; }
        public string MaKhachHang { get => _MaKhachHang; set => _MaKhachHang = value; }
        public string NgayHoaDon { get => _NgayHoaDon; set => _NgayHoaDon = value; }
        public string GioHoaDon { get => _GioHoaDon; set => _GioHoaDon = value; }
        public float DonGia { get => _DonGia; set => _DonGia = value; }


        public DTOHoaDon() { }

        public DTOHoaDon(string maHoaDon, string maKhachHang, string ngayHoaDon, string gioHoaDon)
        {
            _MaHoaDon = maHoaDon;
            _MaKhachHang = maKhachHang;
            _NgayHoaDon = ngayHoaDon;
            _GioHoaDon = gioHoaDon;
        }

        public DTOHoaDon(string maHoaDon, string maKhachHang, string ngayHoaDon, string gioHoaDon, float donGia)
        {
            _MaHoaDon = maHoaDon;
            _MaKhachHang = maKhachHang;
            _NgayHoaDon = ngayHoaDon;
            _GioHoaDon = gioHoaDon;
            _DonGia = donGia;
        }

    }
    public class DTOChiTietHoaDon
    {
        private string _MaHoaDon;
        private string _MaSanPhamOld;
        private string _MaSanPham;
        private int _SoLuong;

        public string MaHoaDon { get => _MaHoaDon; set => _MaHoaDon = value; }
        public string MaSanPham { get => _MaSanPham; set => _MaSanPham = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public string MaSanPhamOld { get => _MaSanPhamOld; set => _MaSanPhamOld = value; }

        public DTOChiTietHoaDon(string maHoaDon, string maSanPhamOld, string maSanPham, int SoLuong)
        {
            _MaHoaDon = maHoaDon;
            _MaSanPham = maSanPham;
            _MaSanPhamOld = maSanPhamOld;
            _SoLuong = SoLuong;
        }
    }
}
