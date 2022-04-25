namespace Kupri4.IMS.UseCases.ProductTransactions.Interfaces;

public interface IValidateEnoughInventoriesForProducingUseCase
{
    Task<int> ExecuteAsync(Guid productId);
}
