using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM.Server.Models
{
   
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }

        // Navigation properties
        [ForeignKey("UserId")]
        public User User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }

}
