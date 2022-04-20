using Kupri4.IMS.CoreBusiness;
using Kupri4.IMS.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

namespace Kupri4.IMS.Plugins.EFCore.Repositories;

public class ProductTransactRepository : IProductTransactRepository
{
    private readonly IMSDbContext _db;

    public ProductTransactRepository(IMSDbContext imsDbContext)
    {
        _db = imsDbContext;

    }
    public async Task ProduceAsync(ProductTransactionDto productTransactionDto)
    {

        Product? product = await _db.Products.Include(x => x.ProductInventories).ThenInclude(x => x.Inventory).FirstOrDefaultAsync();

        if (product == null) return;

        foreach (var productInventory in product.ProductInventories)
        {
            if (productInventory.Inventory != null)
            {
                productInventory.Inventory.Quantity -= productInventory.InventoryQuantity * productTransactionDto.Quantity;
            }
        }

        ProductTransaction transaction = new()
        {
            Product = product,
            ActivityType = ProductTransactionType.ProduceProduct,
            TransactionDate = DateTime.Now,
            ProductQuantity = productTransactionDto.Quantity,
            ProductionOrder = productTransactionDto.ProductionOrder,
            QuantityBefore = product.Quantity,
            QuantityAfter = product.Quantity + productTransactionDto.Quantity,
            DoneBy = "Peter"
            //TODO: сохранить данные пользователя при выполнении транзакции
        };


        product.Quantity += productTransactionDto.Quantity;

        _db.ProductTransactions.Add(transaction);
        await _db.SaveChangesAsync();
    }
}
