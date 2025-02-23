using AutoMapper;
using BankingCreditSystem.Application.Features.IndividualCustomers.DTOs.Requests;
using BankingCreditSystem.Application.Features.IndividualCustomers.DTOs.Responses;
using BankingCreditSystem.Application.Services.Repositories;
using MediatR;

namespace BankingCreditSystem.Application.Features.IndividualCustomers.Queries.SearchIndividualCustomers;

public class SearchIndividualCustomersQuery : IRequest<List<IndividualCustomerResponse>>
{
    public SearchIndividualCustomersRequest Request { get; set; }

    public SearchIndividualCustomersQuery(SearchIndividualCustomersRequest request)
    {
        Request = request;
    }
}

public class SearchIndividualCustomersQueryHandler : 
    IRequestHandler<SearchIndividualCustomersQuery, List<IndividualCustomerResponse>>
{
    private readonly IIndividualCustomerRepository _customerRepository;
    private readonly IMapper _mapper;

    public SearchIndividualCustomersQueryHandler(
        IIndividualCustomerRepository customerRepository,
        IMapper mapper)
    {
        _customerRepository = customerRepository;
        _mapper = mapper;
    }

    public async Task<List<IndividualCustomerResponse>> Handle(
        SearchIndividualCustomersQuery request, 
        CancellationToken cancellationToken)
    {
        var customers = await _customerRepository.SearchAsync(
            firstName: request.Request.FirstName,
            lastName: request.Request.LastName,
            identityNumber: request.Request.IdentityNumber,
            email: request.Request.Email,
            phoneNumber: request.Request.PhoneNumber,
            dateOfBirth: request.Request.DateOfBirth,
            startDate: request.Request.StartDate,
            endDate: request.Request.EndDate,
            isActive: request.Request.IsActive,
            index: request.Request.PageIndex,
            size: request.Request.PageSize
        );

        var response = _mapper.Map<List<IndividualCustomerResponse>>(customers);
        return response;
    }
} 