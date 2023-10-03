namespace AsyncTaskExample;

public class Example03
{
    public static void Run()
    {
        var random = new Random();
        Task[] tasks = new Task[10];
        for (var i = 0; i < 10; i++)
        {
            tasks[i] = Task.Run(() =>
            {
                var x = random.Next(0, 10);
                if (x == 0)
                {
                    throw new Exception($"an Exception in task #{Task.CurrentId}");
                }
                else
                {
                    Thread.Sleep(2000);
                }
            });
        }

        try
        {
            Task.WaitAll(tasks);
        }
        catch (AggregateException ae)
        {
            Console.WriteLine("One or more exceptions occurred: ");
            foreach (var ex in ae.Flatten().InnerExceptions)
            {
                Console.WriteLine("    {0}", ex.Message);
            }
        }

        Console.WriteLine("Status of completed tasks:");
        foreach (var t in tasks)
        {
            Console.WriteLine("   Task #{0}: {1}", t.Id, t.Status);
        }
    }
}