using LemondropsCafe.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace LemondropsCafe.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderMenuItem>().HasKey(om => new
            { 
                om.OrderId,
                om.MenuItemId
            });

            modelBuilder.Entity<OrderMenuItem>().HasOne(o => o.Order).WithMany(om => om.OrderMenuItems).HasForeignKey(o => o.OrderId);
            
            modelBuilder.Entity<OrderMenuItem>().HasOne(m => m.MenuItem).WithMany(om => om.OrderMenuItems).HasForeignKey(m => m.MenuItemId);

            // Specify store type for the 'Price' property in the 'MenuItem' entity
            modelBuilder.Entity<MenuItem>()
                .Property(m => m.Price)
                .HasColumnType("decimal(18, 2)"); // Adjust precision and scale as needed


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderMenuItem> OrderMenuItems { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
