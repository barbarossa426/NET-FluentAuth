namespace BankID.Provider.Models;

/// <summary>
/// More info at: https://banksignering.se/bankidapi#prices_view:~:text=1)-,Auth%20endpoint,-(POST)
/// </summary>
public class AuthResponse
{
    /// <summary>
    /// Was the authentification with BankSignering successful?
    /// </summary>
    public bool Success { get; private set; } = false;

    /// <summary>
    /// If something went wrong, what went wrong?
    /// </summary>
    public string? ErrorMessage { get; private set; } = null;

    public ApiCallResponse? ApiCallResponse { get; private set; } = null;
}

/// <summary>
/// Null if authentification fails
/// </summary>
public class ApiCallResponse
{
    /// <summary>
    /// Was the send successful?
    /// </summary>
    public bool Success { get; private set; } = false;

    /// <summary>
    /// How did the call go? And if something went wrong, what went wrong?
    /// </summary>
    public string StatusMessage { get; private set; } = string.Empty;

    public Response Response { get; private set; }
}

public class Response
{
    /// <summary>
    /// The guid to use when getting the auth status later
    /// </summary>
    public string OrderRef { get; private set; } = string.Empty;

    /// <summary>
    /// Open the BankID app with bankid:///?autostarttoken=[TOKEN]&redirect=[RETURNURL]
    /// </summary>
    public string AutoStartToken { get; private set; } = string.Empty;
}