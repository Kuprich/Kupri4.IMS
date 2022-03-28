using FluentValidation;

namespace Kupri4.IMS.CoreBusiness.Validations;

public class ProductInventoryValidator : AbstractValidator<ProductInventory>
{
    public ProductInventoryValidator()
    {
        RuleFor(x => x.InventoryQuantity)
            .GreaterThanOrEqualTo(1);
    }
}
