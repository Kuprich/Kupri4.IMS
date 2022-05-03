namespace Kupri4.IMS.CoreBusiness;

public class SearchInventoryTransactionDto
{
    public string? InventoryName { get; set; }
    public DateTime? DateFrom { get; set; }
    public DateTime? DateTo { get; set; }
    public InventoryTransactionType? TransactionType { get; set; }
}
