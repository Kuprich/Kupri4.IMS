using Kupri4.IMS.CoreBusiness;
using Kupri4.IMS.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

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
        InventoryTransaction transaction;
        Inventory? inventory = await _db.Inventories.FindAsync(inventoryTransactionDto.InventoryId);
        if (inventory != null)
        {
            transaction = new()
            {
                TransactionOrder = inventoryTransactionDto.PurchaseOrder,
                Inventory = inventory,
                InventoryQuantity = inventoryTransactionDto.InventoryQuantity,
                QuantityBefore = inventory.Quantity,
                TransactionType = InventoryTransactionType.PurchaseInventory,
                QuantityAfter = inventory.Quantity + inventoryTransactionDto.InventoryQuantity,
                TransactionDate = DateTime.Now,
                // TODO: сохранять данные пользователя при выполнении транзакции
                DoneBy = "Test User"
            };

            _db.InventoryTransactions.Add(transaction);
           await _db.SaveChangesAsync();

        }
    }

    public async Task<IEnumerable<InventoryTransaction>> GetInventoryTransactions(SearchInventoryTransactionDto searchInventoryTransactionDto)
    {
        var t = await _db.InventoryTransactions.Include(x => x.Inventory).ToListAsync();

        var inventoryTransactions = await _db.InventoryTransactions.Include(x => x.Inventory)
            .Where(x => searchInventoryTransactionDto.InventoryName == null || 
                x.Inventory!.Name!.ToLower().Contains(searchInventoryTransactionDto.InventoryName.ToLower()))
            .Where(x => searchInventoryTransactionDto.DateFrom == null ||
                x.TransactionDate!.Value.Date >= searchInventoryTransactionDto.DateFrom.Value.Date)
            .Where(x => searchInventoryTransactionDto.DateTo == null ||
                x.TransactionDate!.Value.Date <= searchInventoryTransactionDto.DateTo.Value.Date)
            .Where(x => searchInventoryTransactionDto.TransactionType == null ||
                x.TransactionType == searchInventoryTransactionDto.TransactionType)
            .ToListAsync();

        return inventoryTransactions;
    }
}
