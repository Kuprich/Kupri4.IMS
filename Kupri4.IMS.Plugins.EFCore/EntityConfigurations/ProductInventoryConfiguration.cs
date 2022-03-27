using Kupri4.IMS.CoreBusiness;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kupri4.IMS.Plugins.EFCore.EntityConfigurations;

public class ProductInventoryConfiguration : IEntityTypeConfiguration<ProductInventory>
{
    public void Configure(EntityTypeBuilder<ProductInventory> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.HasOne(x => x.Product).WithMany(p => p.ProductInventories).IsRequired();

        builder.HasOne(x => x.Inventory).WithMany(p => p.ProductInventories).IsRequired();

        builder.Property(x => x.InventoryQuantity).IsRequired();
    }
}
