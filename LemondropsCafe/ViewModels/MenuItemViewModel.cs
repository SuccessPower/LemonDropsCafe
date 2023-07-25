using LemondropsCafe.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LemondropsCafe.ViewModels
{
    public class MenuItemViewModel
    {
        public List<Menu> MenuList { get; set; }
        [Required]
        public int MenuId { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
