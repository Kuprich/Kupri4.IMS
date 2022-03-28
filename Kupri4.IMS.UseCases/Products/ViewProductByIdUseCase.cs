using Kupri4.IMS.CoreBusiness;
using Kupri4.IMS.UseCases.PluginInterfaces;
using Kupri4.IMS.UseCases.Products.Interfaces;

namespace Kupri4.IMS.UseCases.Products;

public class ViewProductByIdUseCase : IViewProductByIdUseCase
{
    private readonly IProductRepository _productRepository;

    public ViewProductByIdUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Product> ExecuteAsync(Guid Id)
    {
        return await _productRepository.GetProductByIdAsync(Id);
    }
}
