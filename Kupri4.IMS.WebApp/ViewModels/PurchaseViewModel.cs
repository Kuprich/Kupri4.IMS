using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.WebApp.ViewModels;

public class PurchaseViewModel
{
    public Guid Id { get; set; }
    public string? PurchaseOrder { get; set; }
    public Inventory? Inventory { get; set; }
    public int QuantityToPurchase { get; set; } = 1;
}
