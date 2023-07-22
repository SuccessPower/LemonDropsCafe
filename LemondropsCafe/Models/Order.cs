using System.Collections.Generic;
using System;

namespace LemondropsCafe.Models
{
    public class Order
    {
        public Order()
        {
            OrderMenuItems = new List<OrderMenuItem>(); // Ensure the collection is initialized in the constructor
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public string OrderNumber { get; set; }

        // Navigation properties
        public virtual User User { get; set; }
        public virtual OrderDetail OrderDetail { get; set; }
        public virtual List<OrderMenuItem> OrderMenuItems { get; set; }
    }
}
