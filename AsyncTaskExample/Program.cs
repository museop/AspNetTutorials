namespace AsyncTaskExample;

public static class Example
{
    public static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("usage: dotnet run <exampleId>");
            Environment.Exit(exitCode: 1);
        }

        switch (args[0])
        {
            case "TaskInstantiation":
                Example01.Run();
                break;

            case "Waiting":
                Example02.Run();
                break;

            case "WaitingAll":
                Example03.Run();
                break;

            case "Cancellation":
                Example04.Run();
                break;
        }
    }
}