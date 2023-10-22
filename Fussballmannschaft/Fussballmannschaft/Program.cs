using System;
using System.Collections.Generic;



class Program
{
    class Spieler
    {
        public string Name { get; private set; }

        public Spieler(string name)
        {
            Name = name;
        }

        public void AufsTorSchiessen()
        {
            if (Program.Zufallszahl(0, 2) == 0)
                Console.WriteLine($"{Name} schießt aufs Tor!");
        }

        public void Graetschen()
        {
            if (Program.Zufallszahl(0, 2) == 0)
                Console.WriteLine($"{Name} macht eine Blutgrätsche!");
        }

        public void Dribbeln()
        {
            if (Program.Zufallszahl(0, 2) == 0)
                Console.WriteLine($"{Name} dribbelt den Gegner schwindlig!");
        }
    }

    class Torwart : Spieler
    {
        public Torwart(string name) : base(name) { }

        public void SchussHalten()
        {
            if (Program.Zufallszahl(0, 2) == 0)
                Console.WriteLine($"{Name} hält den Schuss vom Gegner!");
        }

        public void Abstoss()
        {
            if (Program.Zufallszahl(0, 2) == 0)
                Console.WriteLine($"{Name} macht einen Abstoß!");
        }
    }

    class Fussballmannschaft
    {
        public Torwart Torwart { get; private set; }
        public List<Spieler> Feldspieler { get; private set; }
        public int Tore { get; private set; }

        public Fussballmannschaft(string mannschaftName, Torwart torwart, List<Spieler> feldspieler)
        {
            Torwart = torwart;
            Feldspieler = feldspieler;
            Tore = 0;
            Console.WriteLine($"Die Mannschaft {mannschaftName} stellt sich vor:");
            Console.WriteLine($"Torwart: {Torwart.Name}");
            Console.WriteLine("Feldspieler:");
            foreach (var spieler in Feldspieler)
            {
                Console.WriteLine(spieler.Name);
            }
            Console.WriteLine();
        }

        public int Spielzug()
        {
            int tore = 0;

            foreach (var spieler in Feldspieler)
            {
                if (Program.Zufallszahl(0, 2) == 0)
                {
                    spieler.AufsTorSchiessen();
                    if (Program.Zufallszahl(0, 2) == 0)
                    {
                        Tore++;
                        tore++;
                        Console.WriteLine($"{spieler.Name} hat ein Tor erzielt!");
                    }
                }

                if (Program.Zufallszahl(0, 2) == 0)
                    spieler.Graetschen();

                if (Program.Zufallszahl(0, 2) == 0)
                    spieler.Dribbeln();
            }

            if (Program.Zufallszahl(0, 2) == 0)
            {
                Torwart.SchussHalten();
            }

            if (Program.Zufallszahl(0, 2) == 0)
            {
                Torwart.Abstoss();
            }

            return tore;
        }
    }

    class Spiel
    {
        public Fussballmannschaft Heimmannschaft { get; private set; }
        public Fussballmannschaft Auswaertsmannschaft { get; private set; }

        public Spiel(Fussballmannschaft heimmannschaft, Fussballmannschaft auswaertsmannschaft)
        {
            Heimmannschaft = heimmannschaft;
            Auswaertsmannschaft = auswaertsmannschaft;
        }

        public void Spielen()
        {
            Console.WriteLine("Spielbeginn!");

            int toreHeim = Heimmannschaft.Spielzug();
            int toreAuswaerts = Auswaertsmannschaft.Spielzug();

            Console.WriteLine($"Spiel beendet! Ergebnis: {Heimmannschaft.Tore} : {Auswaertsmannschaft.Tore}");
        }
    }
    static void Main(string[] args)
    {
        List<Spieler> fcStGallenSpieler = new List<Spieler>
        {
            new Spieler("F.Schubert"),
            new Spieler("J.Vonmoos"),
            new Spieler("C.Witzig"),
            new Spieler("B.Toma"),
            new Spieler("J.Quintilla"),
            new Spieler("B.Fazliji"),
            new Spieler("I.Schmidt"),
            new Spieler("P.Sutter"),
            new Spieler("A.Diaby"),
            new Spieler("A.Vallci")
        };

        Torwart fcStGallenTorwart = new Torwart("Zigi");

        List<Spieler> fcYoungBoysSpieler = new List<Spieler>
        {
            new Spieler("E.Meschack"),
            new Spieler("J.Nsame"),
            new Spieler("F.Ugrinic"),
            new Spieler("D.Males"),
            new Spieler("E.Colley"),
            new Spieler("S.Lauper"),
            new Spieler("N.Persson"),
            new Spieler("A.Amenda"),
            new Spieler("M.Camara"),
            new Spieler("S.Janko")
        };

        Torwart fcYoungBoysTorwart = new Torwart("Vonballmoos");

        Fussballmannschaft fcStGallen = new Fussballmannschaft("FC St. Gallen", fcStGallenTorwart, fcStGallenSpieler);
        Fussballmannschaft fcYoungBoys = new Fussballmannschaft("FC Young Boys", fcYoungBoysTorwart, fcYoungBoysSpieler);

        Spiel spiel = new Spiel(fcStGallen, fcYoungBoys);
        spiel.Spielen();
    }

    public static int Zufallszahl(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }
}
