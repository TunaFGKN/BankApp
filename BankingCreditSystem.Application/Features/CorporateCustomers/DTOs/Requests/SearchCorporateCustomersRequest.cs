namespace BankingCreditSystem.Application.Features.CorporateCustomers.DTOs.Requests;

public class SearchCorporateCustomersRequest
{
    public string? CompanyName { get; set; }
    public string? TaxNumber { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool? IsActive { get; set; }
    public int PageIndex { get; set; } = 0;
    public int PageSize { get; set; } = 10;
} 