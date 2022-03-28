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

    public async Task<Product> GetProductByIdAsync(Guid id)
    {
        return await _db.Products.FindAsync(id) ?? new Product();
    }

    public async Task<List<Product>> GetProductsByNameAsync(string name)
    {
        var products = await _db.Products
            .Where(x => x.Name!.ToLower().Contains(name.ToLower()))
            .ToListAsync();

        return products;
    }
}
