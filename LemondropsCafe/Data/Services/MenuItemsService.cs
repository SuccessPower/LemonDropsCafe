using LemondropsCafe.Data.Base;
using LemondropsCafe.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LemondropsCafe.Data.Services
{
    public class MenuItemsService : EntityBaseRepository<MenuItem>,  IMenuItemsService
    {
        public MenuItemsService(AppDbContext context) : base(context) { }
    }
}
