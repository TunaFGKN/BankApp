namespace BankingCreditSystem.Application.Features.IndividualCustomers.DTOs.Requests;

public class SearchIndividualCustomersRequest
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? IdentityNumber { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public bool? IsActive { get; set; }
    public int PageIndex { get; set; } = 0;
    public int PageSize { get; set; } = 10;
} 