public class 
{
    string kontoNr;
    int saldo;

    public int Saldo 
    {
        get { return saldo; }
    }

    public string KontoNr 
    {
        get { return kontoNr; }
        set { kontoNr = value; }
    }

    public void Einzahlen(int betrag)
    {
        if (betrag < 0) 
        {
            throw new Exception("Betrag darf nicht kleiner als 0 sein!");
        }
        saldo += betrag;
    }

    public void Abheben(int betrag)
    {
        if (saldo < betrag)
        {
            // Zusicherung  
            throw new Exception("Nicht erlaubt! Saldo darf nicht ins Minus!");
        }
        saldo -= betrag;
    }
}