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
}
