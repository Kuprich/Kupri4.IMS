using Kupri4.IMS.CoreBusiness;
using Kupri4.IMS.UseCases.PluginInterfaces;

namespace Kupri4.IMS.Plugins.EFCore
{
    public class InventoryRepository : IInventoryRepository
    {
        public Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}