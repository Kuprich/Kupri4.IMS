namespace Kupri4.IMS.UseCases.Products.Interfaces;

public interface IDeleteProductUseCase
{
    Task ExecuteAsync(Guid productId);
}
