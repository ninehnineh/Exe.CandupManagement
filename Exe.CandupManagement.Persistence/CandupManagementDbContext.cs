using Exe.CandupManagement.Domain.Common;
using Exe.CandupManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Persistence
{
    public class CandupManagementDbContext : DbContext
    {
        public CandupManagementDbContext(DbContextOptions<CandupManagementDbContext> options)
            : base(options)
        {

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
            {
                entry.Entity.ModifiedDate = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedDate = DateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Inventory> Inventories { get; set; }

        public DbSet<Shop> Shops { get; set; }

        public DbSet<Discount> Discounts { get; set; }

        public DbSet<OrderPaymentInformation> OrderPaymentInformation { get; set; }

        public DbSet<UserPaymentInformation> UserPaymentInformation { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ShopProduct> ShopProducts { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<CartItem> CartItems { get; set; }


    }
}
