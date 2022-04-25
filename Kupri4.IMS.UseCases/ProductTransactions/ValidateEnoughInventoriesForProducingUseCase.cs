using Kupri4.IMS.UseCases.PluginInterfaces;
using Kupri4.IMS.UseCases.ProductTransactions.Interfaces;

namespace Kupri4.IMS.UseCases.ProductTransactions;

public class ValidateEnoughInventoriesForProducingUseCase : IValidateEnoughInventoriesForProducingUseCase
{
    private readonly IProductRepository _productRepository;

    public ValidateEnoughInventoriesForProducingUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<int> ExecuteAsync(Guid productId)
    {
        int producingQuantity = 0;

        var product = await _productRepository.GetProductByIdAsync(productId);

        if (product == null)
        {
            return producingQuantity;
        }

        while (true)
        {
            foreach (var productInventory in product!.ProductInventories)
            {
                if (productInventory.Inventory!.Quantity < productInventory.InventoryQuantity * producingQuantity)
                {

                    return --producingQuantity;
                }
            }

            producingQuantity++;

        }

    }

}
