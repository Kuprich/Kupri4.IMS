using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.UseCases.Products.Interfaces
{
    public interface IEditProductUseCase
    {
        Task ExecuteAsync(Product product);
    }
}