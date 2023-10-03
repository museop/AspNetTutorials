namespace SyncAndAsync;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Program Begin (Sync)");
        DoAsSync();
        Console.WriteLine("Program End (Sync)");
        Console.ReadLine();

        Console.WriteLine("Program Begin (Async)");
        DoAsAsync();
        Console.WriteLine("Program End (Async)");
        Console.ReadLine();
    }

    public static void DoAsSync()
    {
        Console.WriteLine("1 - Starting");
        var t = Task.Factory.StartNew(DoSomethingThatTaksTime);
        Console.WriteLine("2 - Task started");
        t.Wait();
        Console.WriteLine("3 - Task completed with result: " + t.Result);
    }

    public static async void DoAsAsync()
    {
        Console.WriteLine("1 - Starting");
        var t = Task.Factory.StartNew(DoSomethingThatTaksTime);
        Console.WriteLine("2 - Task started");
        var result = await t;
        Console.WriteLine("3 - Task completed with result: " + t.Result);
    }

    public static int DoSomethingThatTaksTime()
    {
        Console.WriteLine("A - Started something");
        Thread.Sleep(1000);
        Console.WriteLine("B - Completed something");
        return 123;
    }
}