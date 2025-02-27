using BankingCreditSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankingCreditSystem.Persistence.EntityConfigurations;

public class IndividualCustomerConfiguration : IEntityTypeConfiguration<IndividualCustomer>
{
    public void Configure(EntityTypeBuilder<IndividualCustomer> builder)
    {
        builder.ToTable("IndividualCustomers"); // Seperate table for individual customers.

        builder.HasBaseType<Customer>(); // Main table is customers.

        builder.Property(c => c.FirstName)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(c => c.LastName)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(c => c.NationalId)
            .HasMaxLength(11)
            .IsRequired();

        builder.HasIndex(c => c.NationalId)
            .IsUnique();
    }
}
