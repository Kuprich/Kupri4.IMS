namespace Kupri4.IMS.CoreBusiness;

public class InventoryTransactionDto
{
    public Guid InventoryId { get; set; }
    public string? PurchaseOrder { get; set; }
    public int InventoryQuantity { get; set; }
}
