namespace touge_drifting;

public class Cars
{
    
    public Cars(string brand, string model, string color, Engine engine, bool spoiler, Tires tires)
    {
        Brand = brand;
        Model = model;
        Color = color;
        Engine = engine;
        Spoiler = spoiler;
        Tires = tires;
        WinningChances = 0;

    }
    
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public Engine Engine { get; set; }
    public bool Spoiler { get; set; }
    public Tires Tires { get; set; }
    public double WinningChances { get; set; }
    
    
    public void printinfo()
    {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Color: {Color}, Engine: {Engine}, Spoiler: {Spoiler}, Tires: {Tires}");
    }
}