using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LemondropsCafe.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        public string Name { get; set; }
        // Other menu-related properties

        public virtual List<MenuItem> MenuItems { get; set; }
    }
}
