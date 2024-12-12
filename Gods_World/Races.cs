namespace Gods_World;


abstract class Races
{

    public Races(string name, string weapon, int attackdamage, int defense, double intelligence, int maxage, string standort)
    {
        Name = name;
        Weapon = weapon;
        Damage = attackdamage;
        Defense = defense;
        Intelligence = intelligence;
        MaxAge = maxage;
        Standort = standort;
    }

    public string Name { get; set; }
    public string Weapon { get; set; }
    public int Damage { get; set; }
    public int Defense { get; set; }
    public double Intelligence { get; set; }

    public int MaxAge { get; set; }
    public string Standort { get; set; }




    public virtual void DefaultAttack(Races target)
    {
        int finalDamage = Damage - target.Defense;
        finalDamage = finalDamage > 0 ? finalDamage : 0;

        Console.WriteLine($"{Name} attacks {target.Name} with {Weapon}, dealing {finalDamage} damage!");
    }

    
}
    
  



