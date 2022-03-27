using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace Kupri4.IMS.CoreBusiness;

public class ProductInventory
{
    [Key]
    public Guid Id { get; set; }

    public int InventoryQuantity { get; set; }

    public Product? Product { get; set; }

    public Inventory? Inventory { get; set; }

}

public class ProductInventoryValidator : AbstractValidator<ProductInventory>
{
    public ProductInventoryValidator()
    {
        RuleFor(x => x.InventoryQuantity)
            .GreaterThanOrEqualTo(1);
    }
}
