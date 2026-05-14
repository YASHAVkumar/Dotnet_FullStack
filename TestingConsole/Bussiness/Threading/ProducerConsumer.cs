public class ProducerConsumer
{
    static Queue<int> buffer = new Queue<int>();

    static object obj = new object();

    static int capacity = 5;
    public static void Producer()
    {
        int item = 1;

        while (true)
        {
            lock (obj)
            {
                // Wait if buffer full
                while (buffer.Count == capacity)
                {
                    Monitor.Wait(obj);
                }

                buffer.Enqueue(item);

                Console.WriteLine("Produced: " + item);

                item++;

                // Notify consumer
                Thread.Sleep(500);
                Monitor.Pulse(obj);
            }

            
        }
    }

    public static void Consumer()
    {
        while (true)
        {
            lock (obj)
            {
                // Wait if buffer empty
                while (buffer.Count == 0)
                {
                     System.Console.WriteLine("Waiting for producer..");
                    Monitor.Wait(obj);
                }

                int item = buffer.Dequeue();

                Console.WriteLine("Consumed: " + item);

                // Notify producer
                Monitor.Pulse(obj);
                Thread.Sleep(2000);
            }

            
        }
    }

  public static void CurrentItem()
{
    while (true)
    {
        lock (obj)
        {
            if (buffer.Count > 0)
            {
                Console.Write("Items in buffer: ");

                foreach (var item in buffer)
                {
                    Console.Write(item + ", ");
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Buffer Empty");
            }
        }

        // Important
        Thread.Sleep(1000);
    }
}
}