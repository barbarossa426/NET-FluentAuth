using BankID.Provider.Interfaces;
using BankID.Provider.Models;
using BankID.Tests.Base;
using FluentAssertions;

namespace BankID.Tests
{
    public class Tests : IntegrationTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("/auth")]
        public async Task ShouldRequestAuthAction(string endpoint)
        {
            //TODO clean up this test should not call lie 22 and expåected REquest should be valid
            var response = await HttpClient.GetAsync(endpoint);

            //Given
            GetRequiredService<IBankIdProvider>(out var service);
            AuthRequest expectedRequest = new("", "", "", ""); //TODO add test data

            //When
            AuthResponse outcome = await service.Auth(expectedRequest);

            //Then
            outcome.Success.Should().BeTrue();
            outcome.ErrorMessage.Should().BeNull();
            outcome.ApiCallResponse.Should().NotBeNull(); //TODO Add more validation here / Assertions
        }
    }
}