namespace Three_Classess;

public class Car : Vehicle, IMotorizedVehicle
{
    public bool IsStarted { get; set; }
    public Car(string brand, string model, string color, int maxSpeed, int doors, UsedCondition usedCondition) : base(brand, model, color, usedCondition)
    {
        MaxSpeed = maxSpeed;
        Doors = doors;
    }



    public int MaxSpeed { get; set; }
    public int Doors { get; set; }

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