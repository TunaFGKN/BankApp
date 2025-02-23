namespace BankingCreditSystem.Application.Features.IndividualCustomers.DTOs.Responses;

public class CreatedIndividualCustomerResponse
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string IdentityNumber { get; set; }
    public string Email { get; set; }
    public DateTime CreatedDate { get; set; }
    public string Message { get; internal set; }
} 