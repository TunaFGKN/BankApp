namespace BankingCreditSystem.Application.Features.CorporateCustomers.DTOs.Requests;

public class GetCorporateCustomerListRequest
{
    public int PageIndex { get; set; } = 0;
    public int PageSize { get; set; } = 10;
} 