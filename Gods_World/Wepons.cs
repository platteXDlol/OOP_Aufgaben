namespace Gods_World;

public class Wepons
{
    public Wepons(int attackdamage, int defense, WaeponWeight weight)
    {
        AttackDamage = attackdamage;
        Defense = defense;
        WaeponWeight = weight;
    }
    
    public int AttackDamage { get; set; }
    public int Defense { get; set; }
    public WaeponWeight WaeponWeight { get; set; }
}



public enum WaeponWeight
{
    SuperLight,
    Light,
    Medium,
    Heavy,
}