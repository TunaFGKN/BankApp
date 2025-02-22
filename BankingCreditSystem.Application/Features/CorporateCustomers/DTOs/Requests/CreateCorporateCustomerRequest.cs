namespace BankingCreditSystem.Application.Features.CorporateCustomers.DTOs.Requests;

public class CreateCorporateCustomerRequest
{
    public string CompanyName { get; set; }
    public string TaxNumber { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
} 