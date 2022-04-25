using Kupri4.IMS.CoreBusiness;

namespace Kupri4.IMS.WebApp.ViewModels;

public class SellProductViewModel
{
    public Product? Product { get; set; }
    public int ProductQuantity { get; set; } = 1;
    public string? SellOrder { get; set; }
}


