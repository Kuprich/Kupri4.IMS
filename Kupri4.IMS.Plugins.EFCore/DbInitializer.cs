using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.Plugins.EFCore
{
    public static class DbInitializer
    {
        private static List<Inventory> _inventories = GetSomeInventories();
        private static List<Product> _products = GetSomeProducts();
        private static List<ProductInventory> _productInventories = GetSomeProductInventories();
        private static List<InventoryTransaction> _inventoryTransactions = GetSomeInventoryTransactions();


        public async static void Initialize(IMSDbContext dbContext)
        {
            await dbContext.Database.EnsureDeletedAsync();
            await dbContext.Database.EnsureCreatedAsync();

            await dbContext.Products.AddRangeAsync(_products);
            await dbContext.Inventories.AddRangeAsync(_inventories);
            await dbContext.ProductInventories.AddRangeAsync(_productInventories);
            await dbContext.InventoryTransactions.AddRangeAsync(_inventoryTransactions);

            await dbContext.SaveChangesAsync();
        }
        private static List<InventoryTransaction> GetSomeInventoryTransactions() =>
            new()
            {
                new InventoryTransaction
                {
                    Inventory = _inventories[2],
                    InventoryQuantity = 2,
                    QuantityBefore = 6,
                    QuantityAfter = 8,
                    TransactionDate = DateTime.Now.AddDays(-3),
                    TransactionOrder = "transaction order 1",
                    TransactionType = InventoryTransactionType.PurchaseInventory,
                    DoneBy = "Peter"
                },

                new InventoryTransaction
                {
                    Inventory = _inventories[4],
                    InventoryQuantity = 4,
                    QuantityBefore = 6,
                    QuantityAfter = 2,
                    TransactionDate = DateTime.Now.AddDays(-2),
                    TransactionOrder = "transaction order 2",
                    TransactionType = InventoryTransactionType.PurchaseInventory,
                    DoneBy = "Kolya"
                },

                new InventoryTransaction
                {
                    Inventory = _inventories[1],
                    InventoryQuantity = 1,
                    QuantityBefore = 2,
                    QuantityAfter = 1,
                    TransactionDate = DateTime.Now.AddDays(-1),
                    TransactionOrder = "transaction order 3",
                    TransactionType = InventoryTransactionType.ProduceProduct,
                    DoneBy = "Kolya"
                },
            };

        private static List<ProductInventory> GetSomeProductInventories() =>
            new()
            {
                new ProductInventory() { Id = Guid.NewGuid(), Product = _products[0], Inventory = _inventories[0], InventoryQuantity = 4 },
                new ProductInventory() { Id = Guid.NewGuid(), Product = _products[0], Inventory = _inventories[1], InventoryQuantity = 1 },
                new ProductInventory() { Id = Guid.NewGuid(), Product = _products[0], Inventory = _inventories[5], InventoryQuantity = 3 },

                new ProductInventory() { Id = Guid.NewGuid(), Product = _products[1], Inventory = _inventories[0], InventoryQuantity = 3 },
                new ProductInventory() { Id = Guid.NewGuid(), Product = _products[1], Inventory = _inventories[2], InventoryQuantity = 1 },
                new ProductInventory() { Id = Guid.NewGuid(), Product = _products[1], Inventory = _inventories[5], InventoryQuantity = 3 },
            };

        private static List<Product> GetSomeProducts() =>
            new()
            {
                new Product() { Id = Guid.NewGuid(), Name = "Gas Car", Description = "Gas Car description", Price = 10000m, Quantity = 1 },
                new Product() { Id = Guid.NewGuid(), Name = "Electric Car", Description = "Product2 descr", Price = 20000m, Quantity = 1 }
            };

        private static List<Inventory> GetSomeInventories() =>
            new()
            {
                new Inventory() { Id = Guid.NewGuid(), Name = "Wheel", Quantity = 320, Price = 30m },
                new Inventory() { Id = Guid.NewGuid(), Name = "Gas Engine", Quantity = 230, Price = 2000m },
                new Inventory() { Id = Guid.NewGuid(), Name = "Electric Engine", Quantity = 232, Price = 5000m },
                new Inventory() { Id = Guid.NewGuid(), Name = "Battery", Quantity = 243, Price = 1000m },
                new Inventory() { Id = Guid.NewGuid(), Name = "Helmet", Quantity = 53, Price = 20m },
                new Inventory() { Id = Guid.NewGuid(), Name = "Seat", Quantity = 21, Price = 35m }
            };

    }
}
