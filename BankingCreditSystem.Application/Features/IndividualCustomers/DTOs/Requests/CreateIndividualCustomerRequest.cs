namespace BankingCreditSystem.Application.Features.IndividualCustomers.DTOs.Requests;

public class CreateIndividualCustomerRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string IdentityNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string NationalId { get; internal set; }
} 