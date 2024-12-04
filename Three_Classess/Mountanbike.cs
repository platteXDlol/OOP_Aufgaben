namespace Three_Classess;

public class Mountanbike
{
    
    public string Brand { get; }
    public string Model { get; }
    public string Color { get; set; }

    public Mountanbike(string brand, string model, string color)
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
        Console.WriteLine("Mountanbike is driving");
    }
}