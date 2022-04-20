using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.UseCases.PluginInterfaces;

public interface IProductTransactRepository
{
    Task ProduceAsync(ProductTransactionDto inventoryTransactionDto);
}
