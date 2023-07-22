using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace LemondropsCafe.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public string OrderNumber { get; set; }
        public string OrderDetails { get; set; }
        // Other order-related properties

        public virtual User User { get; set; }
        public virtual List<OrderMenuItem> OrderMenuItems { get; set; }
    }
}
