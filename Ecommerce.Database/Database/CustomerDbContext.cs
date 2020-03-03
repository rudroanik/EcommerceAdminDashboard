using ECommerce.Models;
using Microsoft.EntityFrameworkCore;


namespace ECommerce.Database
{
    public class CustomerDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connectionString = "Server = localhost; Database = CustomerDb; Integrated Security = true";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
