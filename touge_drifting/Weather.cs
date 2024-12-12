namespace touge_drifting;

public class Weather
{
    
    public Weather(WeatherType type)
    {
        Type = type;
       
      
    }
    
    public WeatherType Type { get; set; }
    
    public override string ToString()
    {
        return $"{Type}";
    }
}


//Enum for the weather types
public enum WeatherType
{
    Rain,
    Clear,
    Fog,
    Snow
}