using Kupri4.IMS.CoreBusiness;
using Kupri4.IMS.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

namespace Kupri4.IMS.Plugins.EFCore
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly IMSDbContext _db;

        public InventoryRepository(IMSDbContext iMSDbContext)
        {
            _db = iMSDbContext;
        }

        public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
        {
            return await _db.Inventories
                .Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToListAsync();
        }

    }
}