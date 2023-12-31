﻿namespace Customers.Api.Contracts.Data;

public class CustomerDto
{
    public Guid Id { get; init; } = default!;

    public string GitHubUsername { get; init; } = default!;

    public string FirstName { get; init; } = default!;

    public string LastName { get; init; } = default!;

    public string EmailAddress { get; init; } = default!;

    public DateTime DateOfBirth { get; init; }
}
