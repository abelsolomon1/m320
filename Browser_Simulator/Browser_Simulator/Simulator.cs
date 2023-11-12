
using System;

namespace Browser_Simulator
{
    internal class Simulator
    {
        private StringStack historyStack;

        // Konstruktor, um den StringStack zu übergeben
        public Simulator(StringStack stack)
        {
            historyStack = stack;
        }

        public void Run()
        {
            while (true)
            {
                Console.Write("Geben Sie eine URL ein: ");
                string url = Console.ReadLine();

                if (url == "e")
                {
                    break;
                }

                BrowseURL(url);
            }
        }

        public void BrowseURL(string url)
        {
            Console.WriteLine($"Lade {url}");
            historyStack.Push(url);

        }
    }
}
