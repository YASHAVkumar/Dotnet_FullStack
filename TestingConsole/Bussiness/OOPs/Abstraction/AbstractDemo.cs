namespace TestingConsole.Bussiness.OOPs.Encapsulation;
abstract class Animal
{
    public abstract void MakeSound();  // no implementation

    public static void Sleep()
    {
        Console.WriteLine("Sleeping...");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

interface IVehicle
{
    void Start();
    void Stop();
}

class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Car started");
    }

    public void Stop()
    {
        Console.WriteLine("Car stopped");
    }
}            