using Kupri4.IMS.CoreBusiness;
using Kupri4.IMS.UseCases.PluginInterfaces;
using Kupri4.IMS.UseCases.Products.Interfaces;

namespace Kupri4.IMS.UseCases.Products;

public class ViewProductsByNameUseCase : IViewProductsByNameUseCase
{
    private readonly IProductRepository _productRepository;

    public ViewProductsByNameUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<List<Product>> ExecuteAsync(string name = "")
    {
        return await _productRepository.GetProductsByNameAsync(name);
    }
}
