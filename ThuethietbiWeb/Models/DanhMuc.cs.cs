using System.ComponentModel.DataAnnotations;

namespace ThuethietbiWeb.Models
{
    public class DanhMuc
    {
        [Key]
        public int MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }

        // Mối quan hệ 1-N: 1 Danh mục có nhiều Thiết bị
        public ICollection<ThietBi> ThietBis { get; set; }
    }
}