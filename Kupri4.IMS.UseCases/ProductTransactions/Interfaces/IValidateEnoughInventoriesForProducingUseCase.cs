namespace Kupri4.IMS.UseCases.ProductTransactions.Interfaces;

public interface IValidateEnoughInventoriesForProducingUseCase
{
    Task<bool> ExecuteAsync(Guid productId, int producingQuantity);
}
