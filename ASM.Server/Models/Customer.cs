using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM.Server.Models
{
 
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(15)]
        public string PhoneNumber { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        // Navigation properties
        public ICollection<Order> Orders { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }

}
