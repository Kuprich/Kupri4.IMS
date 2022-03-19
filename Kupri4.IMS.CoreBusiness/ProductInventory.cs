using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kupri4.IMS.CoreBusiness
{
    public class ProductInventory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Product? Product { get; set; }

        [Required]
        public Inventory? Inventory { get; set; }

        [Required]

        public int InventoryQuantity { get; set; }
    }
}
