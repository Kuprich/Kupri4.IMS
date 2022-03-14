using Kupri4.IMS.CoreBusiness;
using Kupri4.IMS.UseCases.Inventories.Interfaces;
using Kupri4.IMS.UseCases.PluginInterfaces;

namespace Kupri4.IMS.UseCases.Inventories;

public class ViewInventoryByIdUseCase : IViewInventoryByIdUseCase
{
    private readonly IInventoryRepository _inventoryRepository;

    public ViewInventoryByIdUseCase(IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository;
    }

    public async Task<Inventory> ExecuteAsync(Guid id)
    {
        return await _inventoryRepository.GetInventory(id);
    }
}
