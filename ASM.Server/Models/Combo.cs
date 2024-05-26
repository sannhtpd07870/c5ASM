
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM.Server.Models
{
    public class Combo
    {
        [Key]
        public int ComboId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        // Navigation property
        public ICollection<FoodItem> FoodItems { get; set; }
    }

}
