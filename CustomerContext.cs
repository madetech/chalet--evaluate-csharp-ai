using Microsoft.EntityFrameworkCore;

public class CustomerContext : DbContext
{
    public CustomerContext(DbContextOptions<CustomerContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }
}

public class Customer
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string Surname { get; set; }
}