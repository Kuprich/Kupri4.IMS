namespace Kupri4.IMS.CoreBusiness;

public class InventoryTransactionDto
{
    public string? PurchaseOrder { get; set; }
    public Guid InventoryId { get; set; }
    public int InventoryQuantity { get; set; }
}
