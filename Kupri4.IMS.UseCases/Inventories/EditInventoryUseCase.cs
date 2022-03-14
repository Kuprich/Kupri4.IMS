using Kupri4.IMS.CoreBusiness;
using Kupri4.IMS.UseCases.Inventories.Interfaces;
using Kupri4.IMS.UseCases.PluginInterfaces;

namespace Kupri4.IMS.UseCases.Inventories;

public class EditInventoryUseCase : IEditInventoryUseCase
{
    private readonly IInventoryRepository _inventoryRepository;

    public EditInventoryUseCase(IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository;
    }
    public async Task ExecuteAsync(Inventory inventory)
    {
        await _inventoryRepository.UpdateInventoryAsync(inventory);
    }
}
