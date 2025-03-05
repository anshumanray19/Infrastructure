using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace Infrastructure.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
