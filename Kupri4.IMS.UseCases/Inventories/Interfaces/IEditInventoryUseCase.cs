using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.UseCases.Inventories.Interfaces
{
    public interface IEditInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}