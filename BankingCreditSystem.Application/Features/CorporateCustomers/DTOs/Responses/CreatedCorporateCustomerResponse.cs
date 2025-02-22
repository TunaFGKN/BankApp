namespace BankingCreditSystem.Application.Features.CorporateCustomers.DTOs.Responses;

public class CreatedCorporateCustomerResponse
{
    public Guid Id { get; set; }
    public string CompanyName { get; set; }
    public string TaxNumber { get; set; }
    public string Email { get; set; }
    public DateTime CreatedDate { get; set; }
} 