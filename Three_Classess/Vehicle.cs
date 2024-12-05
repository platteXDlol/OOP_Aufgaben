namespace Three_Classess;

public abstract class Vehicle
{
    public Vehicle(string brand, string model, string color, UsedCondition usedCondition)
    {
        Brand = brand;
        Model = model;
        Color = color;
        UsedCondition = usedCondition;
    }

    public string Brand { get; }
    public string Model { get; }
    public string Color { get; set; }
    
    public UsedCondition UsedCondition { get; set; }

    public virtual void printinfo()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Color: {Color}, Condition: {UsedCondition}");
    }

    public abstract void drive();
}