using touge_drifting; 
using System;
using System.Collections.Generic;
using System.Linq;

public class Race
{
    private Random _random;

    public Race()
    {
        _random = new Random();
    }

 
    public List<Cars> SimulateRace(List<Cars> cars)
    {
      
        foreach (var car in cars)
        {
            car.WinningChances = WinningChances.CalculateWinningChances(car, 
                car.Tires.Model == TireModels.Rain ? new Weather(WeatherType.Rain) : new Weather(WeatherType.Clear), 
                new Touge_Street(1500, 50, Touge_Difficulty.Medium, new Weather(WeatherType.Clear)));
        }

        
        var carsWithFinalChances = cars.Select(car =>
        {
            double randomFactor = _random.NextDouble() * 100; 
            double WinningChancesFinal = car.WinningChances + randomFactor - (100 - car.WinningChances); 

            
            return new
            {
                car,
                WinningChancesFinal
            };
        }).ToList();

        
        var sortedCars = carsWithFinalChances.OrderByDescending(c => c.WinningChancesFinal).ToList();

      
        for (int i = 0; i < sortedCars.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {sortedCars[i].car.Brand} {sortedCars[i].car.Model} - Winning Chances: {sortedCars[i].car.WinningChances}% | Final Adjusted: {sortedCars[i].WinningChancesFinal}%");
        }

     
        return sortedCars.Select(c => c.car).ToList();
    }
}
