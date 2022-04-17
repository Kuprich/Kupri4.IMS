using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.UseCases.Inventories.Interfaces;

public interface IViewInventoryByIdUseCase
{
    Task<Inventory> ExecuteAsync(Guid id);
}
