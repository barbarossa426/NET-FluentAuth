namespace BankID.Extensions;

public static class BankIdExtension
{
    public static void AddBankIdClient(this IServiceCollection services, string clientName, string basAddress)
    {
        services.AddHttpClient(clientName, httpClient =>
        {
            httpClient.BaseAddress = new Uri(basAddress);
        });
    }
}