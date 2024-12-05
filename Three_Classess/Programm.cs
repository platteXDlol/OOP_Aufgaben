namespace Three_Classess;

public class Programm
{
    private static void Main(string[] args)
    {
        var car = new Car("Toyota", "AE86", "white", 200, 4, UsedCondition.notWorking);
        car.printinfo();
        car.drive();
        car.StartEngine();
        car.StartEngine();
        car.StopEngine();
        car.StartEngine();
        car.honk();

        Console.WriteLine();

        var bike = new Mountanbike("Canyon", "Spectral", "black", true, UsedCondition.slightlyUsed);
        bike.printinfo();
        bike.drive();

        Console.WriteLine();

        var motorcycle = new Motorcycle("Kawasaki", "Ninja", "green", 2, UsedCondition.New);
        motorcycle.printinfo();
        motorcycle.drive();
        motorcycle.StopEngine();
        motorcycle.StartEngine();
    }
}