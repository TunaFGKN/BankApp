namespace BankingCreditSystem.Application.Features.IndividualCustomers.DTOs.Responses;

public class UpdatedIndividualCustomerResponse
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime UpdatedDate { get; set; }
} 