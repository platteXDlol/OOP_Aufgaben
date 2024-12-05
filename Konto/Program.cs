public class Konto
{
    public string KontoNr { get; set; }

    public int Saldo { get; private set; }

    public void Einzahlen(int betrag)
    {
        if (betrag < 0) throw new Exception("Betrag darf nicht kleiner als 0 sein!");
        Saldo += betrag;
    }

    public void Abheben(int betrag)
    {
        if (Saldo < betrag) throw new Exception("Nicht erlaubt! Saldo darf nicht ins Minus!");
        Saldo -= betrag;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Ein Konto erstellen
        var meinKonto = new Konto();

        // Kontonummer setzen
        meinKonto.KontoNr = "DE1234567890";
        Console.WriteLine($"Kontonummer: {meinKonto.KontoNr}");

        // Einzahlen
        meinKonto.Einzahlen(500);
        Console.WriteLine($"Saldo nach Einzahlung: {meinKonto.Saldo} EUR");

        // Abheben
        meinKonto.Abheben(200);
        Console.WriteLine($"Saldo nach Abhebung: {meinKonto.Saldo} EUR");

        // Ungültige Operationen testen
        try
        {
            meinKonto.Abheben(500); // Sollte eine Exception werfen
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fehler: {ex.Message}");
        }
    }
}