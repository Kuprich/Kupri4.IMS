using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.UseCases.InventoryTransactions.Interfaces;

public interface IPurchaseInventoryUseCase
{
    Task ExecuteAsync(InventoryTransactionDto inventoryTransactionDto);
}
