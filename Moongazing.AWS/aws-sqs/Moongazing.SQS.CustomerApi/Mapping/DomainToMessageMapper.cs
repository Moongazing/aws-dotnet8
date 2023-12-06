using Customers.Api.Domain;
using Moongazing.SQS.CustomersApi.Contracts.Messages;

namespace Moongazing.SQS.CustomersApi.Mapping;

public static class DomainToMessageMapper
{
    public static CustomerCreated ToCustomerCreatedMessage(this Customer customer)
    {
        return new CustomerCreated
        {
            Id = customer.Id,
            EmailAddress = customer.EmailAddress,
            DateOfBirth = customer.DateOfBirth,
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            GitHubUsername = customer.GitHubUsername,

        };
    }

    public static CustomerUpdated ToCustomerUpdatedMessage(this Customer customer)
    {
        return new CustomerUpdated
        {
            Id = customer.Id,
            EmailAddress = customer.EmailAddress,
            DateOfBirth = customer.DateOfBirth,
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            GitHubUsername = customer.GitHubUsername,

        };
    }




}
