using BankID.Provider.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BankID.Provider.Extensions;

public static class ProviderExtension
{
    public static void AddBankIdProvider(this IServiceCollection services)
    {
        services.AddScoped<IBankIdProvider, BankIdProvider>();
    }
}