using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.UseCases.ProductTransactions.Interfaces;

public interface ISellProductUseCase
{
    Task ExecuteAsync(ProductTransactionDto productTransactionDto);
}
