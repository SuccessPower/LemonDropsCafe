using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LemondropsCafe.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        // Other user-related properties, such as email, address, etc.

        public virtual List<Order> Orders { get; set; }
    }
}
