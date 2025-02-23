using AutoMapper;
using BankingCreditSystem.Application.Features.IndividualCustomers.DTOs.Requests;
using BankingCreditSystem.Application.Features.IndividualCustomers.DTOs.Responses;
using BankingCreditSystem.Domain.Entities;

namespace BankingCreditSystem.Application.Features.IndividualCustomers.Profiles;

public class IndividualCustomerMappingProfile : Profile
{
    public IndividualCustomerMappingProfile()
    {
        CreateMap<CreateIndividualCustomerRequest, IndividualCustomer>();
        CreateMap<IndividualCustomer, IndividualCustomerResponse>();
    }
} 