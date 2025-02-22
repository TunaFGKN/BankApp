namespace BankingCreditSystem.Application.Features.CorporateCustomers.Queries.GetCorporateCustomerList;

public class GetCorporateCustomerListQuery : IRequest<List<CorporateCustomerResponse>>
{
    public GetCorporateCustomerListRequest Request { get; set; }

    public GetCorporateCustomerListQuery(GetCorporateCustomerListRequest request)
    {
        Request = request;
    }
}

public class GetCorporateCustomerListQueryHandler : 
    IRequestHandler<GetCorporateCustomerListQuery, List<CorporateCustomerResponse>>
{
    private readonly ICorporateCustomerRepository _customerRepository;
    private readonly IMapper _mapper;

    public GetCorporateCustomerListQueryHandler(
        ICorporateCustomerRepository customerRepository,
        IMapper mapper)
    {
        _customerRepository = customerRepository;
        _mapper = mapper;
    }

    public async Task<List<CorporateCustomerResponse>> Handle(
        GetCorporateCustomerListQuery request, 
        CancellationToken cancellationToken)
    {
        var customers = await _customerRepository.GetListAsync(
            index: request.Request.PageIndex,
            size: request.Request.PageSize
        );

        var response = _mapper.Map<List<CorporateCustomerResponse>>(customers);
        return response;
    }
} 