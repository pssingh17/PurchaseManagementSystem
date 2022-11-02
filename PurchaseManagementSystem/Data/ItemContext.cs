using PurchaseManagementSystem.Models;
using Microsoft.EntityFrameworkCore;



namespace PurchaseManagementSystem.Data
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().ToTable("Item");

        }
    }
}