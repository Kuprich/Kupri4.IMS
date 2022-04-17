namespace Kupri4.IMS.CoreBusiness;

public class InvenoryTransaction
{
    public Guid Id { get; set; }
    public Inventory? Inventory { get; set; }
    public int InventoryQuantity { get; set; }
    public string? PurchaseOrder { get; set; }
    public int QuantityBefore { get; set; }
    public InventoryTransactionType? InventoryTransactionType { get; set; }
    public int QuantityAfter { get; set; }
    public DateTime? TransactionDate { get; set; }
    public string? DoneBy { get; set; }
}
