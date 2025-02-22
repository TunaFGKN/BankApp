namespace BankingCreditSystem.Application.Features.CorporateCustomers.DTOs.Responses;

public class UpdatedCorporateCustomerResponse
{
    public Guid Id { get; set; }
    public string CompanyName { get; set; }
    public string Email { get; set; }
    public DateTime UpdatedDate { get; set; }
} 