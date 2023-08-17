using System.Net.Http;

namespace ResilienceWithPoly;

public class Client
{
    private int _count = 0;

    public void Request()
    {
        _count++;
        if (_count < 5)
        {
            Console.WriteLine("Failed");
            throw new HttpRequestException();
        }
        Console.WriteLine("Success");
    }

    public void Clear()
    {
        _count = 0;
    }
}
