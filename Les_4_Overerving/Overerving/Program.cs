using ClassLibOVererving.Dieren;
using System;
using System.Collections.Generic;

namespace Overerving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZoogDier paard = new ZoogDier("Paard", 4, true);
            Vogel vliegVlieg = new Vogel("Kanari", 1, true, false, 20, true);
            Vogel plons = new Vogel("Pinguin", 2, true, true, 80, false);

            List<Dier> dieren = new List<Dier>();
            Dier grootEi = new Vogel("Struisvoggel", 2, true, false, 200, true);

            dieren.Add(grootEi);
            dieren.Add(paard);
            dieren.Add(plons);
            dieren.Add(new ZoogDier("PensPony", 2, false));
            foreach (Dier dier in dieren)
            {
                Console.WriteLine(dier.BeschrijfDier());
                Console.WriteLine(dier.MaakGeluid());
                
            }
            Console.Read();
        }
    }
}
