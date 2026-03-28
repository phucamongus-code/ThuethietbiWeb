using Microsoft.EntityFrameworkCore;

namespace ThuethietbiWeb.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Khai báo các bảng sẽ được tạo trong SQL
        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<ThietBi> ThietBis { get; set; }
        // Sau này Hưng thêm class DonThue, ChiTietDonThue thì khai báo tiếp vào đây...
    }
}