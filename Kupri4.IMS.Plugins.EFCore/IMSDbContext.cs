using Kupri4.IMS.CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace Kupri4.IMS.Plugins.EFCore
{
    public class IMSDbContext : DbContext
    {
        public IMSDbContext(DbContextOptions<IMSDbContext> options) : base(options)
        { }

        public DbSet<Inventory> Inventories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory>().HasData(
                new Inventory() { Id = Guid.NewGuid(), Name = "Wheel", Quantity = 3, Price = 30m },
                new Inventory() { Id = Guid.NewGuid(), Name = "Engine", Quantity = 1, Price = 300m },
                new Inventory() { Id = Guid.NewGuid(), Name = "Helmet", Quantity = 5, Price = 20m },
                new Inventory() { Id = Guid.NewGuid(), Name = "Seat", Quantity = 2, Price = 35m }
            );
        }

    }

}
