namespace Three_Classess;

public class Motorcycle
{
    public string Brand { get; }
    public string Model { get; }
    public string Color { get; set; }

    public Motorcycle(string brand, string model, string color)
    {
        Brand = brand;
        Model = model;
        Color = color;
    }
    
    public void printinfo()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Color: {Color}");
    }
    
    public void drive()
    {
        Console.WriteLine("Motorcycle is driving");
    }
}


    
