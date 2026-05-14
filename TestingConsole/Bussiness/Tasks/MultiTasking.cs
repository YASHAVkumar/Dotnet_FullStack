using System.Threading.Tasks;
public static class TaskLib
{
    public static void Work()
    {
       Console.WriteLine("Task Started");

        Thread.Sleep(2000);

        Console.WriteLine("Task Completed");
    }
    public static int Add()
    { 
        Thread.Sleep(1000);
        return 10 + 20;
    }

    public static void DoWork(string taskName,
                       CancellationToken token)
    {
        for (int i = 1; i <= 10; i++)
        {
            // Check cancellation
            if (token.IsCancellationRequested)
            {
                Console.WriteLine(taskName +
                    " Cancelled");

                return;
            }

            Console.WriteLine(taskName +
                " Processing " + i);

            Thread.Sleep(1000);
        }

        Console.WriteLine(taskName +
            " Completed");
    }
}