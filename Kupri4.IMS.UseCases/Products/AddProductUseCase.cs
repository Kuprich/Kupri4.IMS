using Kupri4.IMS.CoreBusiness;
using Kupri4.IMS.UseCases.PluginInterfaces;
using Kupri4.IMS.UseCases.Products.Interfaces;

namespace Kupri4.IMS.UseCases.Products;

public class AddProductUseCase : IAddProductUseCase
{
    private readonly IProductRepository _productRepository;

    public AddProductUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task ExecuteAsync(Product product)
    {
        await _productRepository.AddProduct(product);
    }
}