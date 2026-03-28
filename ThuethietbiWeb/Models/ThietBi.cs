using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThuethietbiWeb.Models
{
    public class ThietBi
    {
        [Key]
        public int MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public decimal GiaThueNgay { get; set; }
        public int SoLuongTon { get; set; }
        public string TrangThai { get; set; }

        // Khóa ngoại liên kết với DanhMuc
        public int MaDanhMuc { get; set; }
        [ForeignKey("MaDanhMuc")]
        public DanhMuc DanhMuc { get; set; }
    }
}