using Kupri4.IMS.UseCases.PluginInterfaces;
using Kupri4.IMS.UseCases.Products.Interfaces;

namespace Kupri4.IMS.UseCases.Products;

public class DeleteProductUseCase : IDeleteProductUseCase
{
    private readonly IProductRepository _productRepository;

    public DeleteProductUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task ExecuteAsync(Guid productId)
    {
        await _productRepository.RemoveProductAsync(productId);
    }
}