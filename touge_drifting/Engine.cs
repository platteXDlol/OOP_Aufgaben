namespace touge_drifting;

public class Engine
{

    public Engine(double amountliters, int ps, int maxgeschwindigkeit, int turbos)
    {
        AmountLiters = amountliters;
        PS = ps;
        MaxGeschwindigkeit = maxgeschwindigkeit;
        Turbos = turbos;
    }
    
    public double AmountLiters { get; set; }
    public int PS { get; set; }
    public int MaxGeschwindigkeit { get; set; }
    public int Turbos { get; set; }
    
    
    public override string ToString()
    {
        return $"{AmountLiters + "L"}, {PS + "PS"}, {MaxGeschwindigkeit + "km/h"}, {Turbos + "Turbo(s)"}";
    }
}