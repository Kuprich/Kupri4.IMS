using FluentValidation;

namespace Kupri4.IMS.CoreBusiness.Validations
{
    public class ProductValidator : AbstractValidator<Product>
    {

        public ProductValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage($"\"{nameof(Product.Name)}\": Field is required")
                .MinimumLength(3).WithMessage($"\"{nameof(Product.Name)}\": Minimal length is 3 characters");

            RuleFor(x => x.Description)
                .NotNull().WithMessage($"\"{nameof(Product.Description)}\": Field is required")
                .MinimumLength(5).WithMessage($"\"{nameof(Product.Description)}\": Minimal length is 5 characters");

            RuleFor(x => x.Price)
                .NotEmpty().WithMessage($"\"{nameof(Product.Price)}\": Field is requireds required")
                .GreaterThan(0).WithMessage($"\"{nameof(Product.Price)}\": Must be positive");

            RuleForEach(x => x.ProductInventories)
                .SetValidator(new ProductInventoryValidator());

            RuleFor(x => x.Price).GreaterThanOrEqualTo(x => x.ProductInventories.Sum(x => x.InventoryQuantity * x.Inventory!.Price))
                .WithMessage($"\"{nameof(Product.Price)}\": must be greater or equal the sum of the inventories of which it is composed");

        }
    }
}
