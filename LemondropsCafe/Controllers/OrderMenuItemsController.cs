using LemondropsCafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LemondropsCafe.Controllers
{
    public class OrderMenuItemsController : Controller
    {
        private readonly AppDbContext _context;

        public OrderMenuItemsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var getAllOrderMenuItems = await _context.Orders.ToListAsync();
            return View();
        }
    }
}
