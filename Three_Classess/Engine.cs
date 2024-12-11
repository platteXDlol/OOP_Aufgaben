namespace Three_Classess;

public class Engine
{
    public Engine(double amountLiters, int horsePower)
    {
        AmountLiters = amountLiters;
        HorsePower = horsePower;
        IsStarted = false;
    }

    public double AmountLiters { get; }
    public int HorsePower { get; }
    public bool IsStarted { get; set; }

    protected bool Equals(Engine other)
    {
        return AmountLiters.Equals(other.AmountLiters) && HorsePower == other.HorsePower;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        Engine other = (Engine) obj;
        return AmountLiters.Equals(other.AmountLiters) && HorsePower == other.HorsePower;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(AmountLiters, HorsePower);
    }
}