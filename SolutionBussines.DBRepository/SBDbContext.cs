using Microsoft.EntityFrameworkCore;
using SolutionBussines.Models.Db;

namespace SolutionBussines.DBRepository
{
    public class SBDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Provider> Providers { get; set; }

        public SBDbContext(DbContextOptions<SBDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Provider>().HasData(
                new Provider { Id = 1, Name = "Provider_1" },
                new Provider { Id = 2, Name = "Provider_21" },
                new Provider { Id = 3, Name = "Provider_3" },
                new Provider { Id = 4, Name = "Provider_4" },
                new Provider { Id = 5, Name = "Provider_5" },
                new Provider { Id = 6, Name = "Provider_6" },
                new Provider { Id = 7, Name = "Provider_7" },
                new Provider { Id = 8, Name = "Provider_8" },
                new Provider { Id = 9, Name = "Provider_9" },
                new Provider { Id = 10, Name = "Provider_10" },
                new Provider { Id = 11, Name = "Provider_11" },
                new Provider { Id = 12, Name = "Provider_12" },
                new Provider { Id = 13, Name = "Provider_13" }
                );
            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, Number = "10-1", Date = DateTime.Now, ProviderId = 1 },
                new Order { Id = 2, Number = "10-2", Date = DateTime.Now, ProviderId = 1 },
                new Order { Id = 3, Number = "10-3", Date = DateTime.Now, ProviderId = 2 },
                new Order { Id = 4, Number = "10-41", Date = DateTime.Now, ProviderId = 1 },
                new Order { Id = 5, Number = "10-51", Date = DateTime.Now, ProviderId = 3 },
                new Order { Id = 6, Number = "10-6", Date = DateTime.Now, ProviderId = 5 },
                new Order { Id = 7, Number = "10-7", Date = DateTime.Now, ProviderId = 6 },
                new Order { Id = 8, Number = "10-8", Date = DateTime.Now, ProviderId = 6 },
                new Order { Id = 9, Number = "10-9", Date = DateTime.Now, ProviderId = 6 },
                new Order { Id = 10, Number = "10-11", Date = DateTime.Now, ProviderId = 7 }

                );
            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem { Id = 1, Name = "Product_1", OrderId = 1, Quantity = 13, Unit = "unit_1" },
                new OrderItem { Id = 2, Name = "Product_11", OrderId = 1, Quantity = 13, Unit = "unit_1" },
                new OrderItem { Id = 3, Name = "Product_111", OrderId = 2, Quantity = 13, Unit = "unit_1" },
                new OrderItem { Id = 4, Name = "Product_12", OrderId = 2, Quantity = 13, Unit = "unit_1" },
                new OrderItem { Id = 5, Name = "Product_122", OrderId = 2, Quantity = 13, Unit = "unit_1" },
                new OrderItem { Id = 6, Name = "Product_13", OrderId = 4, Quantity = 13, Unit = "unit_1" },
                new OrderItem { Id = 7, Name = "Product_133", OrderId = 4, Quantity = 13, Unit = "unit_1" },
                new OrderItem { Id = 8, Name = "Product_14", OrderId = 5, Quantity = 13, Unit = "unit_1" },
                new OrderItem { Id = 9, Name = "Product_144", OrderId = 5, Quantity = 13, Unit = "unit_1" },
                new OrderItem { Id = 10, Name = "Product_15", OrderId = 6, Quantity = 13, Unit = "unit_1" },
                new OrderItem { Id = 11, Name = "Product_155", OrderId = 6, Quantity = 13, Unit = "unit_1" },
                new OrderItem { Id = 12, Name = "Product_16", OrderId = 7, Quantity = 13, Unit = "unit_1" },
                new OrderItem { Id = 13, Name = "Product_166", OrderId = 7, Quantity = 13, Unit = "unit_1" },
                new OrderItem { Id = 14, Name = "Product_17", OrderId = 8, Quantity = 13, Unit = "unit_1" },
                new OrderItem { Id = 15, Name = "Product_177", OrderId = 8, Quantity = 13, Unit = "unit_1" },
                new OrderItem { Id = 16, Name = "Product_18", OrderId = 9, Quantity = 13, Unit = "unit_1" },
                new OrderItem { Id = 17, Name = "Product_188", OrderId = 9, Quantity = 13, Unit = "unit_1" },
                new OrderItem { Id = 18, Name = "Product_19", OrderId = 9, Quantity = 13, Unit = "unit_1" },
                new OrderItem { Id = 19, Name = "Product_199", OrderId = 10, Quantity = 13, Unit = "unit_1" },
                new OrderItem { Id = 20, Name = "Product_10", OrderId = 10, Quantity = 13, Unit = "unit_1" }
                );
        }
    }
}