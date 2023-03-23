using System;
using System.Collections.Generic;

namespace Oefeningen_Streams
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Oefening_1.Groet();
            //Oefening_2.Wipe("groet.txt");
            Oefening_3.AddName();

            string achternaam = "jansens";
            List<string> voornamen = Oefening_4.ZoekAchterNaam(achternaam);
            if (voornamen.Count < 1)
            {
                for (int i = 5; i > 0; i--)
                {
                    Console.WriteLine($"Gelieve {i} nieuwe namen toe te voegen.");
                    Oefening_3.AddName();
                }
            }
            else
            {
                Console.WriteLine($"Familie {achternaam}:");
                foreach (string naam in voornamen)
                {
                    Console.WriteLine(naam);
                }
                Console.ReadLine();
            }

            Console.WriteLine("Willekeurige naam:");
            Console.WriteLine(Oefening_5.RandomName());
            Console.ReadLine();
        }


    }
}
