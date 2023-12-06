using Amazon.SQS.Model;

namespace Moongazing.SQS.CustomersApi.Messaging;

public interface ISqsMessenger
{
    Task<SendMessageResponse> SendMessageAsync<T>(T message);
}
