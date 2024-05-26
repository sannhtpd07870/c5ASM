using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Azure.Core.HttpHeader;


namespace ASM.Server.Models
{
 
    public class FoodItem
    {
        [Key]
        public int FoodItemId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        [StringLength(100)]
        public string ImageUrl { get; set; }

        // Navigation property
        public ICollection<Combo> Combos { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }

}
