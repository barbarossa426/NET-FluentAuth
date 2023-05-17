using BankID.Extensions;
using BankID.Provider;
using BankID.Provider.Extensions;
using BankID.Provider.Models;
using Microsoft.AspNetCore.Mvc;

try
{
    var builder = WebApplication.CreateBuilder(args);
    BankIdOptions bankIdOptions = builder.Configuration.GetSection("BankIdOptions").Get<BankIdOptions>()!;

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddBankIdClient(bankIdOptions.ClientName, bankIdOptions.BaseAddress);
    builder.Services.AddBankIdProvider();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
        //app.UseDeveloperExceptionPage();
    }

    app.UseHttpsRedirection();

    app.MapGet("/auth", ([FromBody] AuthRequest request, [FromServices] BankIdProvider service) =>
    {
        service.Auth(request);
    }).WithName("AuthenticateBankId").WithOpenApi();

    app.Run();
}
catch (Exception ex)
{

}
public partial class Program
{ }