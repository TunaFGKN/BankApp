using BankingCreditSystem.Core.Repositories;
using BankingCreditSystem.Domain.Entities;

namespace BankingCreditSystem.Application.Services.Repositories;

public interface IIndividualCustomerRepository : ICustomerRepository<IndividualCustomer>
{
    Task<List<IndividualCustomer>> SearchAsync(
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
        int size = 10);
} 