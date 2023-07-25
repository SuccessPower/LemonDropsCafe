using LemondropsCafe.Data.Base;
using LemondropsCafe.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LemondropsCafe.Data.Services
{
    public class MenuService : IMenuService
    {
        private readonly IEntityBaseRepository<Menu> _menuRepository;

        public MenuService(IEntityBaseRepository<Menu> entityBaseRepository)
        {
            _menuRepository = entityBaseRepository;
        }

        public async Task<IEnumerable<Menu>> GetAllMenuAsync()
        {
            return await _menuRepository.GetAllAsync();
        }
    }
}
