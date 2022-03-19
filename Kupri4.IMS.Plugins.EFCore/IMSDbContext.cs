﻿using Kupri4.IMS.CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace Kupri4.IMS.Plugins.EFCore
{
    public class IMSDbContext : DbContext
    {
        public IMSDbContext(DbContextOptions<IMSDbContext> options) : base(options)
        { }

        public DbSet<Inventory> Inventories => Set<Inventory>();

        public DbSet<Product> Products => Set<Product>();

        public DbSet<ProductInventory> ProductInventories => Set<ProductInventory>();

    }

}
