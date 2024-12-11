using System;
using System.Media;
using System.Windows;

namespace Auto_Simulator
{
    public class Autos
    {
        public int AktuelleGeschwindigkeit { get; private set; }
        public int AktuellerGang { get; private set; }
        public bool MotorGestartet { get; private set; }
        public string Marke { get; }
        public int PS { get; }
        public int Fuellstand { get; private set; }
        public int MaxGeschwindigkeit { get; }
        public double Benzinverbrauch { get; } 
        public int Beschleunigungsrate { get; } 

        public Autos(string marke, int ps)
        {
            PS = ps;
            Marke = marke;
            MotorGestartet = false;
            AktuellerGang = 1; 
            AktuelleGeschwindigkeit = 0;
            Fuellstand = 50; 

        
            MaxGeschwindigkeit = PS * 2; 
            Benzinverbrauch = Math.Max(0.1, 100.0 / PS); 
            Beschleunigungsrate = PS / 10; 
        }

        public void Auftanken()
        {
            Fuellstand = 100;
        }

        public void Bremsen()
        {
            if (!MotorGestartet)
            {
                MessageBox.Show("Der Motor ist aus. Du kannst nicht bremsen!");
                return;
            }

            if (AktuelleGeschwindigkeit > 0)
            {
                AktuelleGeschwindigkeit -= 10;
                if (AktuelleGeschwindigkeit < 0) AktuelleGeschwindigkeit = 0;
                AktualisiereGang();
            }
        }

        public void Beschleunigen()
        {
            if (!MotorGestartet)
            {
                MessageBox.Show("Motor ist nicht gestartet!");
                return;
            }

            if (Fuellstand <= 0)
            {
                MessageBox.Show("Tank ist leer!");
                return;
            }

            if (AktuellerGang > 0)
            {
                AktuelleGeschwindigkeit += Beschleunigungsrate;
                if (AktuelleGeschwindigkeit > MaxGeschwindigkeit)
                {
                    AktuelleGeschwindigkeit = MaxGeschwindigkeit;
                }

                Fuellstand -= (int)Math.Ceiling(Benzinverbrauch * AktuelleGeschwindigkeit / 100);
                if (Fuellstand < 0) Fuellstand = 0;

                AktualisiereGang();
            }
        }

        private void AktualisiereGang()
        {
           
            if (AktuelleGeschwindigkeit >= 0 && AktuelleGeschwindigkeit <= 20)
                AktuellerGang = 1;
            else if (AktuelleGeschwindigkeit <= 40)
                AktuellerGang = 2;
            else if (AktuelleGeschwindigkeit <= 60)
                AktuellerGang = 3;
            else if (AktuelleGeschwindigkeit <= 80)
                AktuellerGang = 4;
            else
                AktuellerGang = 5;
        }

        public void Hupe()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("horn.wav");
                player.Play();
            }
            catch
            {
                MessageBox.Show("Hupe konnte nicht abgespielt werden (Datei fehlt?)");
            }
        }

        public void SchalteMotorAus()
        {
            MotorGestartet = false;
            AktuelleGeschwindigkeit = 0; 
            AktuellerGang = 0; 
        }

        public void SchalteMotorEin()
        {
            if (Fuellstand > 0)
            {
                if (!MotorGestartet)
                {
                    MotorGestartet = true;
                }
                else
                {
                    MessageBox.Show("Motor läuft bereits");
                }
            }
            else
            {
                MessageBox.Show("Tank leer");
            }
        }

        public override string ToString()
        {
            return $"{Marke} ({PS} PS, Max: {MaxGeschwindigkeit} km/h)";
        }
    }
}
