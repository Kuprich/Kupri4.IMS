using Kupri4.IMS.CoreBusiness;
using Kupri4.IMS.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

namespace Kupri4.IMS.Plugins.EFCore
{
    public class ProductRepository : IProductRepository
    {
        private readonly IMSDbContext _db;

        public ProductRepository(IMSDbContext iMSDbContext)
        {
            _db = iMSDbContext;
        }

        public async Task<List<Product>> GetProductsByName(string name)
        {
            var products = await _db.Products
                .Where(x => x.Name!.Contains(name.Trim(), StringComparison.OrdinalIgnoreCase))
                .ToListAsync();

            return products;
        }
    }
}
