namespace Customers.Api.Contracts.Responses;

public class CustomerResponse
{
    public Guid Id { get; init; }

    public string GitHubUsername { get; init; } = default!;

    public string FirstName { get; init; } = default!;

    public string LastName { get; init; } = default!;

    public string EmailAddress { get; init; } = default!;

    public DateTime DateOfBirth { get; init; }
}
