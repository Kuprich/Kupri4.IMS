using Kupri4.IMS.CoreBusiness;
using System.ComponentModel;

namespace Kupri4.IMS.WebApp.ViewModels;

public class SearchInventoryTransactionViewModel
{
    public string? InventoryName { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public InventoryTransactionType? TransactionType { get; set; }
}
