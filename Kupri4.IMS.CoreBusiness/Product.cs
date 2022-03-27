using FluentValidation;

namespace Kupri4.IMS.CoreBusiness
{
    public class Product
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public ICollection<ProductInventory> ProductInventories { get; set; } = new List<ProductInventory>();
    }

    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage($"\"{nameof(Product.Name)}\": Field is required")
                .MinimumLength(3).WithMessage($"\"{nameof(Product.Name)}\": Minimal length is 3 characters");

            RuleFor(x => x.Description)
                .NotNull().WithMessage($"\"{nameof(Product.Description)}\": Field is required")
                .MinimumLength(3).WithMessage($"\"{nameof(Product.Description)}\": Minimal length is 5 characters");

            RuleFor(x => x.Price)
                .NotEmpty().WithMessage($"\"{nameof(Product.Price)}\": Field is requireds required")
                .GreaterThan(0).WithMessage($"\"{nameof(Product.Price)}\": Must be positive");

            RuleForEach(x => x.ProductInventories)
                .SetValidator(new ProductInventoryValidator());
        }
    }
}
