using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.UseCases.PluginInterfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsByNameAsync(string name);
        Task AddProductAsync(Product product);
        Task<Product> GetProductByIdAsync(Guid id);
        Task UpdateProductAsync(Product product);
        Task RemoveProductAsync(Guid productId);
    }
}
