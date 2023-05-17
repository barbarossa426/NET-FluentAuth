using BankID.Provider.Interfaces;
using BankID.Provider.Models;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using System.Net.Http;
using System.Net.Http.Json;

namespace BankID.Provider;

public class BankIdProvider : IBankIdProvider
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly HttpClient _httpClient;

    public BankIdProvider(IHttpClientFactory httpClientFactory, IOptions<BankIdOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _httpClient = _httpClientFactory.CreateClient(options.Value.ClientName);
    }

    public async Task<AuthResponse> Auth(AuthRequest request, CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.PostAsJsonAsync("auth", request, cancellationToken);

        AuthResponse AuthResponse = new AuthResponse();
        return AuthResponse;
    }
}

