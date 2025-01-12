using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                    new Item { Id = 999, Name = "Microphone", Price = 40, SerialNumberId = 10 }
                );
            modelBuilder.Entity<SerialNumber>().HasData(
                    new SerialNumber { Id = 10, Name = "MIC123456", ItemId = 999  }
                );
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<SerialNumber> SerialNumbers { get; set; }
    }
}
