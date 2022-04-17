using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.UseCases.PluginInterfaces;

public interface IInventoryTransactRepository
{
    public Task PurchaseAsync(InventoryTransactionDto inventoryTransactionDto);
}
