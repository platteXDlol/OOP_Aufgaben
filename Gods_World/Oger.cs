namespace Gods_World;

class Oger : Races
{
    public Oger(string name, string weapon, int attackdamage, int defense, double intelligence, int maxage, string standort) :
        base(name, weapon, attackdamage, defense, intelligence, maxage, standort)
    {
        
    }
    
    public void Deafultattack(Races target)
    {
        int finalDamage = Damage - target.Defense;
        finalDamage = finalDamage > 0 ? finalDamage : 0;

        Console.WriteLine($"{Name} ferociously attacks {target.Name} with {Weapon}, dealing {finalDamage} damage!");
    }
}
    
    
