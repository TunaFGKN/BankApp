using BankingCreditSystem.Application.Services.Repositories;
using BankingCreditSystem.Core.Repositories;
using BankingCreditSystem.Domain.Entities;
using BankingCreditSystem.Persistence.Contexts;

namespace BankingCreditSystem.Persistence.Repositories;

public class IndividualCustomerRepository : CustomerRepository<IndividualCustomer>, IIndividualCustomerRepository
{
    public IndividualCustomerRepository(BaseDbContext context) : base(context)
    {
    }
} 