using BankingCreditSystem.Core.Repositories;
using BankingCreditSystem.Domain.Entities;

namespace BankingCreditSystem.Application.Services.Repositories;

public interface ICorporateCustomerRepository : ICustomerRepository<CorporateCustomer>
{
} 