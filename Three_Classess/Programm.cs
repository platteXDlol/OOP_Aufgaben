namespace Three_Classess;

public class Programm
{
    static void Main(string[] args)
    {
        Car car = new Car("Toyota", "AE86", "white");
        car.printinfo();
        car.drive();
        
        Console.WriteLine();
        
        Mountanbike bike = new Mountanbike("Canyon", "Spectral", "black");
        bike.printinfo();
        bike.drive();
        
        Console.WriteLine();
        
        Motorcycle motorcycle = new Motorcycle("Kawasaki", "Ninja", "green");
        motorcycle.printinfo();
        motorcycle.drive();
    }
}