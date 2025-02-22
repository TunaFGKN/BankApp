namespace BankingCreditSystem.Application.Features.CorporateCustomers.Queries.SearchCorporateCustomers;

public class SearchCorporateCustomersQuery : IRequest<List<CorporateCustomerResponse>>
{
    public SearchCorporateCustomersRequest Request { get; set; }

    public SearchCorporateCustomersQuery(SearchCorporateCustomersRequest request)
    {
        Request = request;
    }
}

public class SearchCorporateCustomersQueryHandler : 
    IRequestHandler<SearchCorporateCustomersQuery, List<CorporateCustomerResponse>>
{
    private readonly ICorporateCustomerRepository _customerRepository;
    private readonly IMapper _mapper;

    public SearchCorporateCustomersQueryHandler(
        ICorporateCustomerRepository customerRepository,
        IMapper mapper)
    {
        _customerRepository = customerRepository;
        _mapper = mapper;
    }

    public async Task<List<CorporateCustomerResponse>> Handle(
        SearchCorporateCustomersQuery request, 
        CancellationToken cancellationToken)
    {
        var customers = await _customerRepository.SearchAsync(
            companyName: request.Request.CompanyName,
            taxNumber: request.Request.TaxNumber,
            email: request.Request.Email,
            phoneNumber: request.Request.PhoneNumber,
            address: request.Request.Address,
            startDate: request.Request.StartDate,
            endDate: request.Request.EndDate,
            isActive: request.Request.IsActive,
            index: request.Request.PageIndex,
            size: request.Request.PageSize
        );

        var response = _mapper.Map<List<CorporateCustomerResponse>>(customers);
        return response;
    }
} 