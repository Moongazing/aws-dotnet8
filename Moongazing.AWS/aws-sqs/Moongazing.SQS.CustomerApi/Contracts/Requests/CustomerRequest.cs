namespace Customers.Api.Contracts.Requests;

public class CustomerRequest
{
    public string GitHubUsername { get; init; } = default!;

    public string FirstName { get; init; } = default!;
    public string LastName { get; init; } = default!;


    public string EmailAddress { get; init; } = default!;

    public DateTime DateOfBirth { get; init; } = default!;
}
