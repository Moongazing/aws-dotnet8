using Customers.Api.Contracts.Requests;
using Customers.Api.Domain;

namespace Customers.Api.Mapping;

public static class ApiContractToDomainMapper
{
    public static Customer ToCustomer(this CustomerRequest request)
    {
        return new Customer
        {
            Id = Guid.NewGuid(),
            EmailAddress = request.EmailAddress,
            GitHubUsername = request.GitHubUsername,
            FirstName = request.FirstName,
            LastName = request.LastName,

            DateOfBirth = request.DateOfBirth
        };
    }

    public static Customer ToCustomer(this UpdateCustomerRequest request)
    {
        return new Customer
        {
            Id = request.Id,
            EmailAddress = request.Customer.EmailAddress,
            GitHubUsername = request.Customer.GitHubUsername,
            FirstName = request.Customer.FirstName,
            LastName = request.Customer.LastName,
            DateOfBirth = request.Customer.DateOfBirth
        };
    }
}
