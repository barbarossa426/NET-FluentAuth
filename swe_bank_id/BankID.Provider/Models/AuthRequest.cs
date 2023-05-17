using System.ComponentModel.DataAnnotations;

namespace BankID.Provider.Models;

public class AuthRequest
{
    public AuthRequest(string userName, string password, string companyApiGuid, string endUserIp)
    {
        ApiUser = userName ?? throw new ArgumentNullException(nameof(userName));
        Password = password ?? throw new ArgumentNullException(nameof(password));
        CompanyApiGuid = companyApiGuid ?? throw new ArgumentNullException(nameof(companyApiGuid));
        EndUserIp = endUserIp ?? throw new ArgumentNullException(nameof(endUserIp));
    }

    /// <summary>
    /// Username given by BankSignering
    /// </summary>
    [Required]
    public string ApiUser { get; set; }

    /// <summary>
    /// Password guid given by BankSignering
    /// </summary>
    [Required]
    public string Password { get; set; }

    /// <summary>
    /// Company guid given by BankSignering
    /// </summary>
    public string CompanyApiGuid { get; set; }
    /// <summary>
    /// The end user device IP
    /// </summary>
    public string EndUserIp { get; set; }

}