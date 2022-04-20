namespace Kupri4.IMS.CoreBusiness;

public class ProductTransaction
{
    public Guid Id { get; set; }
    public Product? Product { get; set; }
    public int ProductQuantity { get; set; }
    public string? ProductionOrder { get; set; }
    public int QuantityBefore { get; set; }
    public ProductTransactionType? ActivityType { get; set; }
    public int QuantityAfter { get; set; }
    public DateTime? TransactionDate { get; set; }
    public string? DoneBy { get; set; }
}
