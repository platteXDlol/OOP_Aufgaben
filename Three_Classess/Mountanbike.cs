namespace Three_Classess;

public class Mountanbike : Vehicle
{
    public Mountanbike(string brand, string model, string color, bool isElectric, UsedCondition usedCondition) : base(brand, model, color, usedCondition)
    {
        IsElectric = isElectric;
    }
    

    public bool IsElectric { get; set; }

    public override void drive()
    {
        Console.WriteLine("The mountanbike is driving");
    }
}