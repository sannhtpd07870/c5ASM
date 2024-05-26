using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM.Server.Models
{

    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int FoodItemId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        // Navigation properties
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [ForeignKey("FoodItemId")]
        public FoodItem FoodItem { get; set; }
    }

}
