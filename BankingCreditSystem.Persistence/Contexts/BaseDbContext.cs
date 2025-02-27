using BankingCreditSystem.Domain.Entities;
using BankingCreditSystem.Persistence.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BankingCreditSystem.Persistence.Contexts;

public class BaseDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<IndividualCustomer> IndividualCustomers { get; set; }
    public DbSet<CorporateCustomer> CorporateCustomers { get; set; }

    public BaseDbContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new CorporateCustomerConfiguration());
        modelBuilder.ApplyConfiguration(new IndividualCustomerConfiguration());
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
} 