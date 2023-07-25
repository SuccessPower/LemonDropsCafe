﻿using LemondropsCafe.Data.Base;
using LemondropsCafe.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LemondropsCafe.Data.Services
{
    public interface IMenuService
    {
        Task<IEnumerable<Menu>> GetAllMenuAsync();
    }
}
