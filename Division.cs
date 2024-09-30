using System;
using System.Diagnostics;

namespace ArbeitsblattSequenzen
{
    class Division
    {
        static void Main(string[] args)
        {
            Console.Write("Divident: ");
            byte zahl1 = lesenEingabe();
            Console.Write("Divisor: ");
            byte zahl2 = lesenEingabe();

            float ergebnis = dividieren(zahl1, zahl2);
            Console.WriteLine($"Das Ergebnis der Division {zahl1} / {zahl2} ist {ergebnis}");
        }


        // Methode zum Einlesen der Eingabe
        static byte lesenEingabe()
        {
            byte eingabe = Convert.ToByte(Console.ReadLine());
            return eingabe;
        }
        // Methode zum Berechnen der Division
        static float dividieren(byte divident, byte divisor)
        {
            // Explizites Typecast erforderlich 
            float division = (float) divident / divisor;
            return division;
        }

    }
}
