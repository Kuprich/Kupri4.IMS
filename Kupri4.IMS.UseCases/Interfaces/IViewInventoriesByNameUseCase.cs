using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.UseCases.Interfaces
{
    public interface IViewInventoriesByNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name);
    }
}