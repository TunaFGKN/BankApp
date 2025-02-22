namespace BankingCreditSystem.Application.Features.CorporateCustomers.Profiles;

public class CorporateCustomerMappingProfile : Profile
{
    public CorporateCustomerMappingProfile()
    {
        CreateMap<CreateCorporateCustomerRequest, CorporateCustomer>();
        CreateMap<CorporateCustomer, CorporateCustomerResponse>();
        CreateMap<CorporateCustomer, CreatedCorporateCustomerResponse>();
        CreateMap<CorporateCustomer, UpdatedCorporateCustomerResponse>();
        CreateMap<CorporateCustomer, DeletedCorporateCustomerResponse>();
    }
} 