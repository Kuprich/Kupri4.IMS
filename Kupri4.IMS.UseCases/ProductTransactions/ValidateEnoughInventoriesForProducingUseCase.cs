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

    public async Task<bool> ExecuteAsync(Guid productId, int producingQuantity)
    {

        var product = await _productRepository.GetProductByIdAsync(productId);

        if (product != null)
        {
            foreach (var productInventory in product.ProductInventories)
            {
                if (productInventory.Inventory!.Quantity < productInventory.InventoryQuantity * producingQuantity)
                {
                    return false;
                }

                return true;
            }
        }

        return false;
    }
}
