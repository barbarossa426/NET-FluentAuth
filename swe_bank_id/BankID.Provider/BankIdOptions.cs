namespace BankID.Provider;

public class BankIdOptions
{
    public string ClientName { get; set; } = string.Empty;
    public string BaseAddress { get; set; } = "https://appapi2.bankid.com/rp/v5.1/";
}