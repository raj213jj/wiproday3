using Microsoft.EntityFrameworkCore;


namespace Day6P2_razorcrud.Models
{
    public class CustomerDbContext:DbContext 
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
    }
}
