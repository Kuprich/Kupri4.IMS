using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.UseCases.ProductTransactions.Interfaces;

public interface IProduceProductUseCase
{
    Task ExecuteAsync(ProductTransactionDto productTransactionDto);
}
