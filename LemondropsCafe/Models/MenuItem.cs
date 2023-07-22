using LemondropsCafe.Data.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LemondropsCafe.Models
{
    public class MenuItem
    {
        [Key]
        public int MenuItemId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public MenuSection Section { get; set; }
        // Other menu item-related properties

        public int MenuId { get; set; } // Foreign key to Menu
        [ForeignKey(nameof(MenuId))]
        public virtual Menu Menu { get; set; }
        public virtual List<OrderMenuItem> OrderMenuItems { get; set; }
    }
}
