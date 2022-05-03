using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.UseCases.PluginInterfaces;

public interface IInventoryTransactRepository
{
    Task PurchaseAsync(InventoryTransactionDto inventoryTransactionDto);
    Task<IEnumerable<InventoryTransaction>> GetInventoryTransactions(SearchInventoryTransactionDto searchInventoryTransactionDto);
}
