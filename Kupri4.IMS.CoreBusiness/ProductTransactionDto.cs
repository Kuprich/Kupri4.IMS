namespace Kupri4.IMS.CoreBusiness;

public class ProductTransactionDto
{
    public Guid ProductId { get; set; }
    public string? ProductionOrder { get; set; }
    public int Quantity { get; set; }
}
