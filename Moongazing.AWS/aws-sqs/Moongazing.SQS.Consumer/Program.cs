﻿using Amazon.SQS;
using Amazon.SQS.Model;


var cts = new CancellationTokenSource();

var sqsClient = new AmazonSQSClient(new AmazonSQSConfig());

var queueUrlResponse = await sqsClient.GetQueueUrlAsync("customers");

var receivedMessageRequest = new ReceiveMessageRequest
{
    QueueUrl = queueUrlResponse.QueueUrl,
    AttributeNames = new List<string> { "All" },
    MessageAttributeNames = new List<string> { "All" },


};

while (!cts.IsCancellationRequested)
{
    var response = await sqsClient.ReceiveMessageAsync(receivedMessageRequest, cts.Token);

    foreach (var message in response.Messages)
    {
        Console.WriteLine($"Message Id: {message.MessageId}");
        Console.WriteLine($"Message Body: {message.Body}");

        await sqsClient.DeleteMessageAsync(queueUrlResponse.QueueUrl, message.ReceiptHandle);
    }
    await Task.Delay(1000);
}