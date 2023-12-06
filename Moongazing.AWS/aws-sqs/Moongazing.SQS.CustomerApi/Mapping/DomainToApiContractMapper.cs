using Customers.Api.Contracts.Responses;
using Customers.Api.Domain;

namespace Customers.Api.Mapping;

public static class DomainToApiContractMapper
{
    public static CustomerResponse ToCustomerResponse(this Customer customer)
    {
        return new CustomerResponse
        {
            Id = customer.Id,
            EmailAddress = customer.EmailAddress,
            GitHubUsername = customer.GitHubUsername,
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            DateOfBirth = customer.DateOfBirth
        };
    }

    public static GetAllCustomersResponse ToCustomersResponse(this IEnumerable<Customer> customers)
    {
        return new GetAllCustomersResponse
        {
            Customers = customers.Select(x => new CustomerResponse
            {
                Id = x.Id,
                EmailAddress = x.EmailAddress,
                GitHubUsername = x.GitHubUsername,
                FirstName = x.FirstName,
                LastName = x.LastName,
                DateOfBirth = x.DateOfBirth
            })
        };
    }
}
