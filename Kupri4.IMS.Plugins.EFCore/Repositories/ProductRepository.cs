using Kupri4.IMS.CoreBusiness;
using Kupri4.IMS.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

namespace Kupri4.IMS.Plugins.EFCore.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly IMSDbContext _db;

    public ProductRepository(IMSDbContext iMSDbContext)
    {
        _db = iMSDbContext;
    }

    public async Task AddProductAsync(Product product)
    {
        if (product != null)
        {
            _db.Products.Add(product);
            await _db.SaveChangesAsync();
        }
    }

    public async Task UpdateProductAsync(Product product)
    {
        var updatedProduct = await _db.Products.FindAsync(product.Id);

        if (updatedProduct != null)
        {
            updatedProduct.Name = product.Name;
            updatedProduct.Description = product.Description;
            updatedProduct.Price = product.Price;
            updatedProduct.ProductInventories = product.ProductInventories;

            await _db.SaveChangesAsync();
        }
    }

    public async Task<Product> GetProductByIdAsync(Guid productId)
    {
        var product = await _db.Products
            .Include(x => x.ProductInventories).ThenInclude(x => x.Inventory)
            .FirstOrDefaultAsync(x => x.Id == productId);

        return product ?? new Product();
    }

    public async Task<List<Product>> GetProductsByNameAsync(string name)
    {
        var products = await _db.Products
            .Include(x => x.ProductInventories).ThenInclude(x => x.Inventory)
            .Where(x => x.Name!.ToLower().Contains(name.ToLower()))
            .ToListAsync();

        return products;
    }

    public async Task RemoveProductAsync(Guid productId)
    {
        var product = await _db.Products.FindAsync(productId);

        if (product != null)
        {
            _db.Products.Remove(product);

            await _db.SaveChangesAsync();
        }
    }

}
