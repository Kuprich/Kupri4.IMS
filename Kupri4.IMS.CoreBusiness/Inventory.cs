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
}