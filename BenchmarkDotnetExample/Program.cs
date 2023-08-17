using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace BenchmarkDotnetExample;

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<Md5VsSha256>();
    }
}
