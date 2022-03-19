using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.UseCases.PluginInterfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsByNameAsync(string name);
        Task AddProduct(Product product);
    }
}
