namespace Three_Classess;

public class Car : Vehicle, IMotorizedVehicle
{
    public Car(string brand, string model, string color, int maxSpeed, int doors, UsedCondition usedCondition) : base(
        brand, model, color, usedCondition)
    {
        MaxSpeed = maxSpeed;
        Doors = doors;
    }

    public bool IsStarted { get; set; }


    public int MaxSpeed { get; set; }
    public int Doors { get; set; }

    public void StartEngine()
    {
        if (!IsStarted)
        {
            Console.WriteLine("The engine is starting");
            IsStarted = true;
        }
        else
        {
            Console.WriteLine("The engine is already started");
        }
    }

    public void StopEngine()
    {
        if (IsStarted)
        {
            Console.WriteLine("The engine is stopping");
            IsStarted = false;
        }
        else
        {
            Console.WriteLine("The engine is already stopped");
        }
    }

    public void honk()
    {
        Console.WriteLine("Tuut Tuut");
    }

    public override void drive()
    {
        Console.WriteLine("The car is driving");
    }

    public override void printinfo()
    {
        base.printinfo();
        Console.WriteLine($"MaxSpeed: {MaxSpeed}, Doors: {Doors}");
    }
}