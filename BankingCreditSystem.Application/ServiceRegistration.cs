using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using BankingCreditSystem.Application.Features.IndividualCustomers.Rules;

namespace BankingCreditSystem.Application;

public static class ServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        
        // Business Rules
        services.AddScoped<IndividualCustomerBusinessRules>();

        return services;
    }
} 