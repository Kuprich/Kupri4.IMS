using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.UseCases.Interfaces
{
    public interface IAddInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}