using Kupri4.IMS.CoreBusiness;
using Kupri4.IMS.UseCases.InventoryTransactions.Interfaces;
using Kupri4.IMS.UseCases.PluginInterfaces;

namespace Kupri4.IMS.UseCases.InventoryTransactions;

public class SearchInventoryTransactionsUseCase : ISearchInventoryTransactionsUseCase
{
    private readonly IInventoryTransactRepository _inventoryTransactRepository;

    public SearchInventoryTransactionsUseCase(IInventoryTransactRepository inventoryTransactRepository)
    {
        _inventoryTransactRepository = inventoryTransactRepository;
    }

    public async Task<IEnumerable<InventoryTransaction>> ExecuteAsync(SearchInventoryTransactionDto searchInventoryTransactionDto)
    {
        return await _inventoryTransactRepository.GetInventoryTransactions(searchInventoryTransactionDto);
    }
}
