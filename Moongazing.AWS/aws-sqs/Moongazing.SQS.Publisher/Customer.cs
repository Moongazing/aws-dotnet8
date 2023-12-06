namespace Moongazing.SQS.Publisher;

public class Customer
{
    public required Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string EmailAddress { get; set; }
    public required DateTime DateOfBirth { get; set; }
}
