using BankingCreditSystem.Application.Services.Repositories;
using BankingCreditSystem.Core.Repositories;
using BankingCreditSystem.Domain.Entities;
using BankingCreditSystem.Persistence.Contexts;

namespace BankingCreditSystem.Persistence.Repositories;

public class CustomerRepository<T> : EfRepositoryBase<T, Guid, BaseDbContext>, ICustomerRepository<T> where T : Customer
{
    public CustomerRepository(BaseDbContext context) : base(context)
    {

    }
}