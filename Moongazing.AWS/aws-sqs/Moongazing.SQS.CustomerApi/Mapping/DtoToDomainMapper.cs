using Customers.Api.Contracts.Data;
using Customers.Api.Domain;

namespace Customers.Api.Mapping;

public static class DtoToDomainMapper
{
    public static Customer ToCustomer(this CustomerDto customerDto)
    {
        return new Customer
        {
            Id = customerDto.Id,
            EmailAddress = customerDto.EmailAddress,
            GitHubUsername = customerDto.GitHubUsername,
            FirstName = customerDto.FirstName,
            LastName = customerDto.LastName,
            DateOfBirth = customerDto.DateOfBirth
        };
    }
}
