using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kupri4.IMS.CoreBusiness
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Minimal length is 3 characters")]
        public string? Name { get; set; }

        public string? Description { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }
    }
}
