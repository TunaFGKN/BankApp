namespace BankingCreditSystem.Application.Features.IndividualCustomers.DTOs.Responses;

public class DeletedIndividualCustomerResponse
{
    public Guid Id { get; set; }
    public DateTime DeletedDate { get; set; }
    public object Message { get; internal set; }
} 