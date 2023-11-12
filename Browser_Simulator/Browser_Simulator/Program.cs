
using System;

namespace Browser_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            StringStack historyStack = new StringStack(10);

            
            Simulator simulator = new Simulator(historyStack);

            // Ausführen des Simulators
            simulator.Run();
        }
    }
}
