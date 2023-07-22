using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LemondropsCafe.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        // Other order detail-related properties
        public string Name { get; set; }
        public string TelephoneNumber { get; set; }
        public string OrderNumber { get; set; } // Add this property

        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmount { get; set; }

        // Foreign key to link to Order
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
