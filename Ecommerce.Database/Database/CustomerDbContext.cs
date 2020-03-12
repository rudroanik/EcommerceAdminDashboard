using Ecommerce.Model;
using ECommerce.Models;
using Microsoft.EntityFrameworkCore;


namespace ECommerce.Database
{
    public class CustomerDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connectionString = "Server = localhost; Database = CustomerDb; User Id=sa;Password=rudroanik";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
