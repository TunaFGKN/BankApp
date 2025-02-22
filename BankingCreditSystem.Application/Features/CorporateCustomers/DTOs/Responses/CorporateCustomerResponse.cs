namespace BankingCreditSystem.Application.Features.CorporateCustomers.DTOs.Responses;

public class CorporateCustomerResponse
{
    public Guid Id { get; set; }
    public string CompanyName { get; set; }
    public string TaxNumber { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
} 