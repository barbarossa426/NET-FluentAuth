using BankID.Provider.Models;

namespace BankID.Provider.Interfaces;

public interface IBankIdProvider
{
    Task<AuthResponse> Auth(AuthRequest request, CancellationToken cancellationToken = default);
}