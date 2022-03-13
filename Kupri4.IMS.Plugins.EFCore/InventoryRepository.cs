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

        public async Task AddInventoryAsync(Inventory inventory)
        {
            _db.Inventories.Add(inventory);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
        {
            return await _db.Inventories
                .Where(x => x.Name!.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToListAsync();
        }

    }
}