using FluentValidation;

namespace Kupri4.IMS.CoreBusiness
{
    public class Inventory
    {

        public Guid Id { get; set; }

        public string? Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public ICollection<ProductInventory> ProductInventories { get; set; } = new List<ProductInventory>();
    }

    public class InventoryValidator : AbstractValidator<Inventory>
    {
        public InventoryValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage($"\"{nameof(Inventory.Name)}\": Field is required")
                .MinimumLength(3).WithMessage($"\"{nameof(Inventory.Name)}\": Minimal length is 3");

            RuleFor(x => x.Quantity)
               .ExclusiveBetween(1, 999).WithMessage($"\"{nameof(Inventory.Quantity)}\": Must be between 1 and 999");

            RuleFor(x => x.Price)
               .ExclusiveBetween(0.01m, 999999m).WithMessage($"\"{nameof(Inventory.Price)}\": Must be positive");
        }
    }
}