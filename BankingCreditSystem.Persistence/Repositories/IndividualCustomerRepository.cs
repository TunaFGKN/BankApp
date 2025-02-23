using BankingCreditSystem.Application.Services.Repositories;
using BankingCreditSystem.Core.Repositories;
using BankingCreditSystem.Domain.Entities;
using BankingCreditSystem.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BankingCreditSystem.Persistence.Repositories;

public class IndividualCustomerRepository : CustomerRepository<IndividualCustomer>, IIndividualCustomerRepository
{
    public IndividualCustomerRepository(BaseDbContext context) : base(context)
    {

    }

    public async Task<List<IndividualCustomer>> SearchAsync(
        string? firstName = null,
        string? lastName = null,
        string? identityNumber = null,
        string? email = null,
        string? phoneNumber = null,
        DateTime? dateOfBirth = null,
        DateTime? startDate = null,
        DateTime? endDate = null,
        bool? isActive = null,
        int index = 0,
        int size = 10)
    {
        var query = Context.IndividualCustomers.AsQueryable();

        if (!string.IsNullOrWhiteSpace(firstName))
            query = query.Where(x => x.FirstName.Contains(firstName));

        if (!string.IsNullOrWhiteSpace(lastName))
            query = query.Where(x => x.LastName.Contains(lastName));

        if (!string.IsNullOrWhiteSpace(identityNumber))
            query = query.Where(x => x.NationalId == identityNumber);

        if (!string.IsNullOrWhiteSpace(email))
            query = query.Where(x => x.Email.Contains(email));

        if (!string.IsNullOrWhiteSpace(phoneNumber))
            query = query.Where(x => x.PhoneNumber.Contains(phoneNumber));

        if (dateOfBirth.HasValue)
            query = query.Where(x => x.DateOfBirth == dateOfBirth.Value);

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