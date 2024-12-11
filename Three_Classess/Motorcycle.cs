namespace Three_Classess;

public class Motorcycle : Vehicle, IMotorizedVehicle
{
    public Motorcycle(string brand, string model, string color, int wheels, UsedCondition usedCondition) : base(brand,
        model, color, usedCondition)
    {
        this.wheels = wheels;
    }

    public bool IsStarted { get; set; }

    public int wheels { get; set; }

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

    public override void drive()
    {
        Console.WriteLine("The motorcycle is driving");
    }
}