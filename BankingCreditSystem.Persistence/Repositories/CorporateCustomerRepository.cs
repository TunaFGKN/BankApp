using BankingCreditSystem.Application.Services.Repositories;
using BankingCreditSystem.Core.Repositories;
using BankingCreditSystem.Domain.Entities;
using BankingCreditSystem.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BankingCreditSystem.Persistence.Repositories;

public class CorporateCustomerRepository : CustomerRepository<CorporateCustomer>, ICorporateCustomerRepository
{
    public CorporateCustomerRepository(BaseDbContext context) : base(context)
    {

    }

    public async Task<List<CorporateCustomer>> SearchAsync(
        string? companyName = null,
        string? taxNumber = null,
        string? email = null,
        string? phoneNumber = null,
        string? address = null,
        DateTime? startDate = null,
        DateTime? endDate = null,
        bool? isActive = null,
        int index = 0,
        int size = 10)
    {
        var query = Context.CorporateCustomers.AsQueryable();

        if (!string.IsNullOrWhiteSpace(companyName))
            query = query.Where(x => x.CompanyName.Contains(companyName));

        if (!string.IsNullOrWhiteSpace(taxNumber))
            query = query.Where(x => x.TaxNumber == taxNumber);

        if (!string.IsNullOrWhiteSpace(email))
            query = query.Where(x => x.Email.Contains(email));

        if (!string.IsNullOrWhiteSpace(phoneNumber))
            query = query.Where(x => x.PhoneNumber.Contains(phoneNumber));

        if (!string.IsNullOrWhiteSpace(address))
            query = query.Where(x => x.Address.Contains(address));

        if (startDate.HasValue)
            query = query.Where(x => x.CreatedDate >= startDate.Value);

        if (endDate.HasValue)
            query = query.Where(x => x.CreatedDate <= endDate.Value);
        
        if (isActive.HasValue)
            query = query.Where(x => x.IsActive == isActive.Value);

        return await query
            .Skip(index * size)
            .Take(size)
            .ToListAsync();
    }
} 