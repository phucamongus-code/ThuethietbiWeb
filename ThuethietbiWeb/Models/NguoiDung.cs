using System.ComponentModel.DataAnnotations;

namespace ThuethietbiWeb.Models
{
    public class NguoiDung
    {
        [Key]
        public int MaNguoiDung { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public bool TrangThai { get; set; }

        // Phân loại người dùng (KhachHang, NhanVien, QuanLy)
        public string VaiTro { get; set; }
    }
}