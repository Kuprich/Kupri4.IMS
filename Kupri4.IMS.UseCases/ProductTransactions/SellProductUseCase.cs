using Kupri4.IMS.CoreBusiness;
using Kupri4.IMS.UseCases.PluginInterfaces;
using Kupri4.IMS.UseCases.ProductTransactions.Interfaces;

namespace Kupri4.IMS.UseCases.ProductTransactions;

public class SellProductUseCase : ISellProductUseCase
{

    private readonly IProductTransactRepository _productTransactRepository;

    public SellProductUseCase(IProductTransactRepository productTransactRepository)
    {
        _productTransactRepository = productTransactRepository;
    }

    public async Task ExecuteAsync(ProductTransactionDto productTransactionDto)
    {
        await _productTransactRepository.SellAsync(productTransactionDto);
    }
}