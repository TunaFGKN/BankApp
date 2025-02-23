using BankingCreditSystem.Core.Repositories;
using BankingCreditSystem.Domain.Entities;

namespace BankingCreditSystem.Application.Services.Repositories;

public interface ICorporateCustomerRepository : ICustomerRepository<CorporateCustomer>
{
    Task<List<CorporateCustomer>> SearchAsync(
        string? companyName = null,
        string? taxNumber = null,
        string? email = null,
        string? phoneNumber = null,
        string? address = null,
        DateTime? startDate = null,
        DateTime? endDate = null,
        bool? isActive = null,
        int index = 0,
        int size = 10);
} 