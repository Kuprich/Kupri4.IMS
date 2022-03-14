using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.UseCases.Inventories.Interfaces
{
    public interface IViewInventoriesByNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name);
    }
}