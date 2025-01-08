using Microsoft.EntityFrameworkCore;
using MyStore.Domain.Entities;

namespace MyStore.Infrastructure.Persistence;

internal class MyStoreDbContext(DbContextOptions<MyStoreDbContext> options) : DbContext(options)
{
    internal DbSet<Product> Products { get; set; }
    internal DbSet<JobData> JobDatas { get; set; }
    internal DbSet<Item> Items { get; set; }
    internal DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
            .HasKey(p => p.Id);

        modelBuilder.Entity<Item>()
            .HasKey(i => i.Id);

        modelBuilder.Entity<Item>()
            .HasOne(i => i.Product)
            .WithMany()
            .HasForeignKey(i => i.ProductId);

        modelBuilder.Entity<Item>()
            .HasOne(i => i.JobData)
            .WithMany()
            .HasForeignKey(i => i.JobDataId);

        modelBuilder.Entity<JobData>()
           .HasKey(i => i.Id);

        modelBuilder.Entity<Order>()
           .HasKey(i => i.Id);

        modelBuilder.Entity<Order>()
            .HasMany(o => o.Items);
    }
}

