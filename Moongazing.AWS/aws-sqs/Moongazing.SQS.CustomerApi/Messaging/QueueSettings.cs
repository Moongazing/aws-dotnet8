﻿namespace Moongazing.SQS.CustomersApi.Messaging;

public class QueueSettings
{
    public const string Key = "Queue";
    public required string Name { get; init; }
}
