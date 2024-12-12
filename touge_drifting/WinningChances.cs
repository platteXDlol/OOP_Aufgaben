namespace touge_drifting;


public class WinningChances
{
    public static double CalculateWinningChances(Cars car, Weather weather, Touge_Street tougeStreet)
{
    double baseWinningChances = 0;
    
  
    baseWinningChances += car.Engine.PS * 0.1; 
    baseWinningChances += car.Engine.MaxGeschwindigkeit * 0.05;
    
    
    double tireWeatherMod = TireWeatherModifier(car.Tires, weather);
    baseWinningChances += tireWeatherMod;

   
    if (car.Spoiler)
    {
        baseWinningChances += 5;
    }


    baseWinningChances -= tougeStreet.Corners * 0.05; 
    baseWinningChances += 2000 / tougeStreet.Length; 
    
   
    baseWinningChances += tougeStreet.Difficulty switch
    {
        Touge_Difficulty.Easy => 10,
        Touge_Difficulty.Medium => 5,
        Touge_Difficulty.Hard => 0,
        Touge_Difficulty.Extreme => -10,
        _ => 0
    };

    
    baseWinningChances = Math.Clamp(baseWinningChances, 0, 100);
    
    return baseWinningChances;
}

    
    

    private static double TireWeatherModifier(Tires tires, Weather weather)
    {
        return (tires.Model, weather.Type) switch
        {
            (TireModels.Drift, WeatherType.Clear) => +15,
            (TireModels.Drift, WeatherType.Rain) => -20,
            (TireModels.Drift, WeatherType.Fog) => -10,
            (TireModels.Drift, WeatherType.Snow) => -25,

            (TireModels.Rain, WeatherType.Clear) => -10,
            (TireModels.Rain, WeatherType.Rain) => +20,
            (TireModels.Rain, WeatherType.Fog) => +10,
            (TireModels.Rain, WeatherType.Snow) => +5,

            (TireModels.Normal, WeatherType.Clear) => +5,
            (TireModels.Normal, WeatherType.Rain) => -5,
            (TireModels.Normal, WeatherType.Fog) => 0,
            (TireModels.Normal, WeatherType.Snow) => -10,

            (TireModels.Slick, WeatherType.Clear) => +20,
            (TireModels.Slick, WeatherType.Rain) => -15,
            (TireModels.Slick, WeatherType.Fog) => -5,
            (TireModels.Slick, WeatherType.Snow) => -30,

            _ => 0
        };
    } 

    } 

    