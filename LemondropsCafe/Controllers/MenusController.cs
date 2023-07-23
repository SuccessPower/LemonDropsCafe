using LemondropsCafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LemondropsCafe.Controllers
{
    public class MenusController : Controller
    {
        private readonly AppDbContext _context;

        public MenusController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMenus = await _context.Menus.ToListAsync();
            return View();
        }
    }
}
