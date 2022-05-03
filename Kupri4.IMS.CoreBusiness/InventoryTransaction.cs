namespace Kupri4.IMS.CoreBusiness;

public class InventoryTransaction
{
    public Guid Id { get; set; }
    public Inventory? Inventory { get; set; }
    public int InventoryQuantity { get; set; }
    public string? TransactionOrder { get; set; }
    public int QuantityBefore { get; set; }
    public InventoryTransactionType? TransactionType { get; set; }
    public int QuantityAfter { get; set; }
    public DateTime? TransactionDate { get; set; }
    public string? DoneBy { get; set; }
}
