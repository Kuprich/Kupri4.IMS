using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kupri4.IMS.CoreBusiness
{
    public class Inventory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Minimal length is 3 characters")]
        public string? Name { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be greater or equal to {0}")]
        public int Quantity { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be greater or equal to {0}")]
        public decimal Price { get; set; }

        public List<ProductInventory> ProductInventories { get; set; } = new();
    }
}