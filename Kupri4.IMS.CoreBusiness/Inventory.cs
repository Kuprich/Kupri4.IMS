using System.ComponentModel.DataAnnotations;

namespace Kupri4.IMS.CoreBusiness
{
    public class Inventory
    {
        public Guid Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}