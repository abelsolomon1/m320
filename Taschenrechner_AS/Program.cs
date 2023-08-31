
using System;

namespace Calculator
{
    class Calculator
    {
        public static void MyCalculator()
        {
            // Deklaration
            double Zahl1;
            double Zahl2;

            double Addition;
            double Subtraktion;
            double Multiplikation;
            double Division;

            // Eingabe
            Console.Write("Geben Sie eine Zahl ein: ");
            Zahl1 = Convert.ToDouble(Console.ReadLine());
            

            Console.Write("Geben Sie noch eine Zahl ein: ");
            Zahl2 = Convert.ToDouble(Console.ReadLine());


            // Verarbeitung
            Addition = Zahl1 + Zahl2;
            Subtraktion = Zahl1 - Zahl2;
            Multiplikation = Zahl1 * Zahl2;
            Division = (double)Zahl1 / Zahl2;

            // Ausgabe
            Console.WriteLine("Resultat der Addition " + Addition);
            Console.WriteLine("Resultat der Subtraktion " + Subtraktion);
            Console.WriteLine("Resultat der Multiplikation " + Multiplikation);
            Console.WriteLine("Resultat der Division " + Division);

            // Warten, bis der Benutzer eine Taste drückt, bevor das Programm beendet wird
            Console.ReadKey();
        }
        // Variable zur Speicherung des Ergebnisses der letzten Operation
        public static double resultat = 0;

       public static void Addition()
        {
            Console.WriteLine("Geben Sie die erste Zahl ein: ");
            double zahl1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie die Zweite Zahl ein: ");
            double zahl2 = double.Parse(Console.ReadLine());

            resultat = zahl1 + zahl2;
        }
       public static void Subtraktion()
        {
            Console.WriteLine("Geben Sie die erste Zahl ein: ");
            double zahl1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie die zweite Zahl ein: ");
            double zahl2 = double.Parse(Console.ReadLine());

            resultat = zahl1 - zahl2;
        }
        static void Multiplikation()
        {
            Console.WriteLine("Geben Sie die erste Zahl ein: ");
            double zahl1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie die zweite Zahl ein: ");
            double zahl2 = double.Parse(Console.ReadLine());

            resultat = zahl1 * zahl2;
        }
        static void Division()
        {
            Console.WriteLine("Geben Sie die erste Zahl ein: ");
            double zahl1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie die zweite Zahl ein: ");
            double zahl2 = double.Parse(Console.ReadLine());

            resultat = zahl1 / zahl2;
        }
        static void Main(string[] args)
        {


            // Anzeige des Menüs und Abfrage der Benutzereingaben
            Console.WriteLine("Wähle eine Operation:");
            Console.WriteLine("0 - Alles auf einmal");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraktion");
            Console.WriteLine("3 - Multiplikation");
            Console.WriteLine("4 - Division");
            
            Console.WriteLine("5 - Schliessen");

            double option = double.Parse(Console.ReadLine());

            // Ausführen des ausgewählten Vorgangs
            switch (option)
            {
                case 0: MyCalculator();
                    break;
                case 1:
                    Addition();
                    break;
                case 2:
                    Subtraktion();
                    break;
                case 3:
                    Multiplikation();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    Console.WriteLine("Das Programm wird geschlossen...");
                    return;
                default:
                    Console.WriteLine("Ungültige Option ausgewählt.");
                    break;
            }

            // Anzeigen des Resultats und wiederholung des Vorgangs
            Console.WriteLine("Result: " + resultat);
            Main(args);
        }
    }
}