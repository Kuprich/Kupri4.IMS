using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.UseCases.Products.Interfaces;

public interface IViewProductsByNameUseCase
{
    Task<List<Product>> ExecuteAsync(string name = "");
}
