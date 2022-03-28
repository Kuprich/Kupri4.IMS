using System.ComponentModel.DataAnnotations;

namespace Kupri4.IMS.CoreBusiness;

public class ProductInventory
{
    [Key]
    public Guid Id { get; set; }

    public int InventoryQuantity { get; set; }

    public Product? Product { get; set; }

    public Inventory? Inventory { get; set; }

}
