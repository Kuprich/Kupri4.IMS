using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.UseCases.Interfaces
{
    public interface IViewInventoryByIdUseCase
    {
        Task<Inventory> ExecuteAsync(Guid id);
    }
}