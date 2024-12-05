namespace Three_Classess;

public class Motorcycle : Vehicle, IMotorizedVehicle
{
    public bool IsStarted { get; set; }
    public Motorcycle(string brand, string model, string color, int wheels, UsedCondition usedCondition) : base(brand, model, color, usedCondition)
    {
        this.wheels = wheels;
    }
    
    public int wheels { get; set; }

    public override void drive()
    {
        Console.WriteLine("The motorcycle is driving");
    }
    
    public void StartEngine()
    {
        if (!this.IsStarted)
        {
            Console.WriteLine("The engine is starting");
            this.IsStarted = true;
        }
        else
        {
            Console.WriteLine("The engine is already started");
        }
    }
    
    public void StopEngine()
    {
        if (this.IsStarted)
        {
            Console.WriteLine("The engine is stopping");
            this.IsStarted = false;
        }
        else
        {
            Console.WriteLine("The engine is already stopped");
        }
    }
}