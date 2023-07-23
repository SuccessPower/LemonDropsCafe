using LemondropsCafe.Data;
using LemondropsCafe.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LemondropsCafe.Controllers
{
    public class MenuItemsController : Controller
    {
        private readonly MenuItemsService _service;

        public MenuItemsController(MenuItemsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allMenuItems = await _service.GetAllAsync();
            return View(allMenuItems);
        }
    }
}
