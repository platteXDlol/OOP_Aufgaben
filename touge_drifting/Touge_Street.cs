namespace touge_drifting;

public class Touge_Street
{
    
    public Touge_Street(int length, int corners, Touge_Difficulty difficulty, Weather weather)
    {
        Length = length;
        Corners = corners;
        Difficulty = difficulty;
        Condition = weather;

    }
    
    public int Length { get; set; }
    public int Corners { get; set; }
    public Touge_Difficulty Difficulty { get; set; }
    public Weather Condition { get; set; }
 
    
    public void printinfo()
    {
        Console.WriteLine($"Length: {Length}, Corners: {Corners}, Difficulty: {Difficulty}, Condition: {Condition}");
    }
}




//Enum for the difficulty of the touge
public enum Touge_Difficulty
{
    
    Easy,
    Medium,
    Hard,
    Extreme
    
}