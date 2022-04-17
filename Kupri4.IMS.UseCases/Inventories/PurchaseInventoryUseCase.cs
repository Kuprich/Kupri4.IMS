using Kupri4.IMS.CoreBusiness;
using Kupri4.IMS.UseCases.Inventories.Interfaces;
using Kupri4.IMS.UseCases.PluginInterfaces;

namespace Kupri4.IMS.UseCases.Inventories;

public class PurchaseInventoryUseCase : IPurchaseInventoryUseCase
{
    private readonly IInventoryTransactRepository _inventoryTransactRepository;
    private readonly IInventoryRepository _inventoryRepository;

    public PurchaseInventoryUseCase(IInventoryTransactRepository inventoryTransactRepository, IInventoryRepository inventoryRepository)
    {
        _inventoryTransactRepository = inventoryTransactRepository;
        _inventoryRepository = inventoryRepository;
    }

    public async Task ExecuteAsync(InventoryTransactionDto inventoryTransactionDto)
    {
        await _inventoryTransactRepository.PurchaseAsync(inventoryTransactionDto);

        Inventory inventory = await _inventoryRepository.GetInventoryAsync(inventoryTransactionDto.InventoryId);

        if (inventory != null)
        {
            inventory.Quantity += inventoryTransactionDto.InventoryQuantity;
            await _inventoryRepository.UpdateInventoryAsync(inventory);
        }

    }
}
