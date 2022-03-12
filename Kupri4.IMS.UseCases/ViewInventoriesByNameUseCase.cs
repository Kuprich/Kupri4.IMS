using Kupri4.IMS.CoreBusiness;
using Kupri4.IMS.UseCases.Interfaces;
using Kupri4.IMS.UseCases.PluginInterfaces;

namespace Kupri4.IMS.UseCases
{
    public class ViewInventoriesByNameUseCase : IViewInventoriesByNameUseCase
    {
        private readonly IInventoryRepository _inventoryRepository;

        public ViewInventoriesByNameUseCase(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }
        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await _inventoryRepository.GetInventoriesByNameAsync(name);
        }
    }
}