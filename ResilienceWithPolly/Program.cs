using Polly;
using Polly.Retry;

namespace ResilienceWithPoly;

public class Program
{
    public static void Main(string[] args)
    {
        var client = new Client();

        // Retry 5
        var retryPolicy = Policy
            .Handle<HttpRequestException>()
            .Retry(
                3,
                onRetry: (exception, retryCount, context) =>
                {
                    Console.WriteLine($"{retryCount}th retry, exception: {exception}");
                    Console.WriteLine($"context: {context}");
                }
            );

        //retryPolicy.Execute(() => client.Request());

        //client.Clear();

        var fallbackPolicy = Policy
            .Handle<HttpRequestException>()
            .Fallback(() => Console.WriteLine("Fallback executed!"));
        //fallbackPolicy.Execute(() => client.Request());

        //client.Clear();
        var combinedPolicy = Policy.Wrap(retryPolicy, fallbackPolicy);
        combinedPolicy.Execute(() =>
        {
            Console.WriteLine("Request");
            client.Request();
        });

    }
}
