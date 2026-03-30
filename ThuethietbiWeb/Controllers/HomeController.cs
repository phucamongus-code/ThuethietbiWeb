using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThuethietbiWeb.Models; // Đảm bảo gọi đúng thư mục Models

namespace ThuethietbiWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        // Kết nối với Database thông qua AppDbContext
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Lấy toàn bộ danh sách Thiết bị từ CSDL
            var dsThietBi = await _context.ThietBis.ToListAsync();

            // Gửi dữ liệu sang View (Giao diện)
            return View(dsThietBi);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}