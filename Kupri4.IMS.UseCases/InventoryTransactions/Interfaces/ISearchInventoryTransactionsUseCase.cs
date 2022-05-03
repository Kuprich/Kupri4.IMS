using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.UseCases.InventoryTransactions.Interfaces;

public interface ISearchInventoryTransactionsUseCase
{
    Task<IEnumerable<InventoryTransaction>> ExecuteAsync(SearchInventoryTransactionDto searchInventoryTransactionDto);
}
