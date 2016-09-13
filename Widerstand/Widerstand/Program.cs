using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Widerstand
{
    class Program
    {
        static void Main(string[] args)
        {
            string sR1, sR2, sR3;
            double dR1, dR2, dR3;
            Console.WriteLine("Widerstand R1:");
            sR1 = Console.ReadLine();
            if (!Double.TryParse(sR1, out dR1)) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            dR1 = Double.Parse(sR1);
            if (dR1 <= 1) { Console.WriteLine("Keine Null-Widerstände!\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            Console.WriteLine("Widerstand R2:");
            sR2 = Console.ReadLine();
            if (!Double.TryParse(sR2, out dR2)) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            dR2 = Double.Parse(sR2);
            if (dR2 <= 1) { Console.WriteLine("Keine Null-Widerstände!\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            Console.WriteLine("Widerstand R3:");
            sR3 = Console.ReadLine();
            if (!Double.TryParse(sR3, out dR3)) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            dR3 = Double.Parse(sR3);
            if (dR3 <= 1) { Console.WriteLine("Keine Null-Widerstände!\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            Console.WriteLine("Gesamtwiderstand: {0}", (1 / (dR1 + dR2)) + (1 / dR3));
            Console.Read();
        }
    }
}
