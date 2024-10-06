using Microsoft.EntityFrameworkCore;
using TechStore.Models;

namespace TechStore.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; } 
        public DbSet<ProductCategorie> ProductCategories { get; set; } 
        public DbSet<Product> Products { get; set; } 
        public DbSet<Order> Orders { get; set; } 
        public DbSet<OrderItem> OrderItems { get; set; } 

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
    }
}