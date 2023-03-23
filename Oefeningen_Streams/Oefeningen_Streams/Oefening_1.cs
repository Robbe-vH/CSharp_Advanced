using System;
using System.IO;

namespace Oefeningen_Streams
{
    public class Oefening_1
    {
        private static string input = string.Empty;
        public static void Groet()
        {
            Console.WriteLine("Geef uw naam");
            input = Console.ReadLine();


            using (StreamWriter sr = new StreamWriter("groet.txt"))
            {
                if (DateTime.Now.Hour< 12) sr.WriteLine($"Goedemorgen {input}");
                if (DateTime.Now.Hour > 12 && DateTime.Now.Hour< 18) sr.WriteLine($"Goedendag {input}");
                if (DateTime.Now.Hour > 18) sr.WriteLine($"Goedenavond {input}");
            }
}
    }
}