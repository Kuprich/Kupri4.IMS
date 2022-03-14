using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.UseCases.PluginInterfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsByName(string name);
    }
}
