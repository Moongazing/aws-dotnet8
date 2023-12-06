
using Amazon.SQS;
using Amazon.SQS.Model;
using Moongazing.SQS.Publisher;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

var sqsClient = new AmazonSQSClient(new AmazonSQSConfig());

var customer = new Customer
{
    Id = Guid.NewGuid(),
    FirstName = "Tunahan",
    LastName = "Ozturk",
    EmailAddress = "tunahan.ali.ozturk@outlook.com",
    DateOfBirth = new DateTime(2000, 21, 2)
};


var queueUrlResponse = await sqsClient.GetQueueUrlAsync("customers");

var sendMessageRequest = new SendMessageRequest
{
    QueueUrl = queueUrlResponse.QueueUrl,
    MessageBody = JsonSerializer.Serialize(customer),
    MessageAttributes = new Dictionary<string, MessageAttributeValue>
    {
        {
            "MessageType", new MessageAttributeValue
            {
                DataType = "String",
                StringValue = nameof(Customer)
            }
        }
    }
};
var response = await sqsClient.SendMessageAsync(sendMessageRequest);

Console.WriteLine();