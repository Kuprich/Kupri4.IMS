using Kupri4.IMS.CoreBusiness;
using Kupri4.IMS.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

namespace Kupri4.IMS.Plugins.EFCore.Repositories;

public class InventoryRepository : IInventoryRepository
{
    private readonly IMSDbContext _db;

    public InventoryRepository(IMSDbContext iMSDbContext)
    {
        _db = iMSDbContext;
    }

    public async Task AddInventoryAsync(Inventory inventory)
    {
        if (inventory != null)
        {
            _db.Inventories.Add(inventory);
            await _db.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
    {
        var inventories = await _db.Inventories
            .Where(x => x.Name!.ToLower().Contains(name.ToLower()))
            .ToListAsync();

        return inventories;
    }

    public async Task<Inventory> GetInventoryAsync(Guid id)
    {
        return await _db.Inventories.FindAsync(id) ?? new Inventory();
    }

    public async Task UpdateInventoryAsync(Inventory inventory)
    {
        var inv = await _db.Inventories.FindAsync(inventory.Id);

        if (inv != null)
        {
            inv.Name = inventory.Name;
            inv.Price = inventory.Price;
            inv.Quantity = inventory.Quantity;

            await _db.SaveChangesAsync();
        }

    }

}
