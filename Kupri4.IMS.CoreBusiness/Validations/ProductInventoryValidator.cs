using FluentValidation;

namespace Kupri4.IMS.CoreBusiness.Validations;

public class ProductInventoryValidator : AbstractValidator<ProductInventory>
{

    public ProductInventoryValidator()
    {
        RuleFor(x => x).Custom((productInventory, context) =>
        {
            string inventoryName = "";
            int quantity;

            if (productInventory != null)
            {
                inventoryName = productInventory.Inventory!.Name ?? string.Empty;
                quantity = productInventory.Inventory.Quantity;


                if (productInventory.InventoryQuantity > productInventory.Inventory.Quantity ||
                productInventory.InventoryQuantity < 1)
                {
                    context.AddFailure(nameof(productInventory.InventoryQuantity), $"{inventoryName}: Quantity, Must be between 1 and {quantity}");
                };

            }
        });
    }
}