using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserPortal.Data;

namespace UserPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users);
        }

        public IActionResult About() => View();
        public IActionResult Contacts() => View();
    }
}