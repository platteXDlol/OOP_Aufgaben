namespace touge_drifting;

public class Tires
{
    
    public Tires(TireModels model)
    {
        Model = model;
      
    }
    
    public TireModels Model { get; set; }
    
    
    
    public override string ToString()
    {
        return $"{Model}";
    }
}





//Enum for the tire models
public enum TireModels
{
    Drift,
    Slick,
    Rain,
    Normal
}

