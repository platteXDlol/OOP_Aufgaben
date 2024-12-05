internal class Program
{
    public static void Main()
    {
        // Creating an instance of Car and initializing values using constructor
        var AE86 = new Car("Toyota", 1983, "White/Panda", 200, 130);

        // Outputting the car details
        Console.WriteLine($"Brand: {AE86.Brand}");
        Console.WriteLine($"Year: {AE86.Year}");
        Console.WriteLine($"Color: {AE86.Color}");
        Console.WriteLine($"Max Speed: {AE86.MaxSpeed} km/h");
        Console.WriteLine($"PS: {AE86.PS} PS");
    }
}

internal class Car
{
    // Constructor to initialize the Car object with values
    public Car(string brand, int year, string color, int maxSpeed, int ps)
    {
        Brand = brand;
        Year = year;
        Color = color;
        MaxSpeed = maxSpeed;
        PS = ps;
    }

    // Auto-implemented properties for encapsulation
    public string Brand { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public int MaxSpeed { get; set; }
    public int PS { get; set; }
}