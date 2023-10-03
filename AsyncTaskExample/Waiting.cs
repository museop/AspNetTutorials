namespace AsyncTaskExample;

public static class Example02
{
    public static void Run()
    {
        // Wait on a single task with no timeout specified.
        Task taskA = Task.Run( () => Thread.Sleep(2000) );
        Console.WriteLine("taskA Status: {0}", taskA.Status);

        try 
        {
            taskA.Wait();
            Console.WriteLine("taskA Status: {0}", taskA.Status);
        }
        catch (AggregateException)
        {
            Console.WriteLine("Exeption in taskA.");
        }
    }
}