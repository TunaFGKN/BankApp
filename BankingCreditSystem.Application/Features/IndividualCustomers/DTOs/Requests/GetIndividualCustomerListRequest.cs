namespace BankingCreditSystem.Application.Features.IndividualCustomers.DTOs.Requests;

public class GetIndividualCustomerListRequest
{
    public int PageIndex { get; set; } = 0;
    public int PageSize { get; set; } = 10;
} 