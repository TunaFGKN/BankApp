namespace BankingCreditSystem.Application.Features.IndividualCustomers.Queries.GetIndividualCustomerList;

public class GetIndividualCustomerListQuery : IRequest<List<IndividualCustomerResponse>>
{
    public GetIndividualCustomerListRequest Request { get; set; }

    public GetIndividualCustomerListQuery(GetIndividualCustomerListRequest request)
    {
        Request = request;
    }
}

public class GetIndividualCustomerListQueryHandler : 
    IRequestHandler<GetIndividualCustomerListQuery, List<IndividualCustomerResponse>>
{
    private readonly IIndividualCustomerRepository _customerRepository;
    private readonly IMapper _mapper;

    public GetIndividualCustomerListQueryHandler(
        IIndividualCustomerRepository customerRepository,
        IMapper mapper)
    {
        _customerRepository = customerRepository;
        _mapper = mapper;
    }

    public async Task<List<IndividualCustomerResponse>> Handle(
        GetIndividualCustomerListQuery request, 
        CancellationToken cancellationToken)
    {
        var customers = await _customerRepository.GetListAsync(
            index: request.Request.PageIndex,
            size: request.Request.PageSize
        );

        var response = _mapper.Map<List<IndividualCustomerResponse>>(customers);
        return response;
    }
} 