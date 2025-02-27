using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BankingCreditSystem.Application.Services.Repositories;
using BankingCreditSystem.Persistence.Contexts;
using BankingCreditSystem.Persistence.Repositories;

namespace BankingCreditSystem.Persistence;

public static class ServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // DbContext
        services.AddDbContext<BaseDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        // Repositories
        services.AddScoped<IIndividualCustomerRepository, IndividualCustomerRepository>();
        services.AddScoped<ICorporateCustomerRepository, CorporateCustomerRepository>();

        return services;
    }
} 