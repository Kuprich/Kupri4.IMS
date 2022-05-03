using System.ComponentModel.DataAnnotations;

namespace Kupri4.IMS.CoreBusiness;

public enum InventoryTransactionType
{
    [Display(Name = "Purchase Inventory")]
    PurchaseInventory = 1,

    [Display(Name = "Produce Product")]
    ProduceProduct = 2
}
