using BankingCreditSystem.Application.Services.Repositories;
using BankingCreditSystem.Core.Repositories;
using BankingCreditSystem.Domain.Entities;
using BankingCreditSystem.Persistence.Contexts;

namespace BankingCreditSystem.Persistence.Repositories;

public class CorporateCustomerRepository : CustomerRepository<CorporateCustomer>, ICorporateCustomerRepository
{
    public CorporateCustomerRepository(BaseDbContext context) : base(context)
    {
    }
} 