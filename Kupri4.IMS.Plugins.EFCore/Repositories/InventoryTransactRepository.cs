using Kupri4.IMS.CoreBusiness;
using Kupri4.IMS.UseCases.PluginInterfaces;

namespace Kupri4.IMS.Plugins.EFCore.Repositories;

public class InventoryTransactRepository : IInventoryTransactRepository
{
    public InventoryTransactRepository(IMSDbContext iMSDbContext)
    {
        _db = iMSDbContext;
    }

    private IMSDbContext _db;

    public async Task PurchaseAsync(InventoryTransactionDto inventoryTransactionDto)
    {
        InvenoryTransaction transaction;
        Inventory? inventory = await _db.Inventories.FindAsync(inventoryTransactionDto.InventoryId);
        if (inventory != null)
        {
            transaction = new()
            {
                PurchaseOrder = inventoryTransactionDto.PurchaseOrder,
                Inventory = inventory,
                InventoryQuantity = inventoryTransactionDto.InventoryQuantity,
                QuantityBefore = inventory.Quantity,
                InventoryTransactionType = InventoryTransactionType.PurchaseInventory,
                QuantityAfter = inventory.Quantity + inventoryTransactionDto.InventoryQuantity,
                TransactionDate = DateTime.Now,
                // TODO: сохранять данные польвателя при выполнении транзакции
                DoneBy = "Test User"
            };

            _db.InvenoriesTransactions.Add(transaction);
           await _db.SaveChangesAsync();
        }

        
    }
}
