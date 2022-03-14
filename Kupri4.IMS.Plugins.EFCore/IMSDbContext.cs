using Kupri4.IMS.CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace Kupri4.IMS.Plugins.EFCore
{
    public class IMSDbContext : DbContext
    {
        public IMSDbContext(DbContextOptions<IMSDbContext> options) : base(options)
        { }

        public DbSet<Inventory> Inventories => Set<Inventory>();
        public DbSet<Product> Products => Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory>().HasData(
                new Inventory() { Id = Guid.NewGuid(), Name = "Wheel", Quantity = 3, Price = 30m },
                new Inventory() { Id = Guid.NewGuid(), Name = "Gas Engine", Quantity = 2, Price = 2000m },
                new Inventory() { Id = Guid.NewGuid(), Name = "Electric Engine", Quantity = 2, Price = 5000m },
                new Inventory() { Id = Guid.NewGuid(), Name = "Battery", Quantity = 2, Price = 1000m },
                new Inventory() { Id = Guid.NewGuid(), Name = "Helmet", Quantity = 5, Price = 20m },
                new Inventory() { Id = Guid.NewGuid(), Name = "Seat", Quantity = 2, Price = 35m }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = Guid.NewGuid(), Name = "Gas Car", Description = "Gas Car description", Price = 10000m},
                new Product() { Id = Guid.NewGuid(), Name = "Electric Car", Description = "Product2 descr", Price = 20000m}   
            );
        }

    }

}
