using System;
using System.IO;

namespace Oefeningen_Streams
{
    internal class Oefening_1
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Geef uw naam");
            string input = Console.ReadLine();

            using (StreamWriter streamWriter = new StreamWriter("groet.txt"))
            {
                if (System.DateTime.Now.Hour < 12) streamWriter.WriteLine($"Goedemorgen {input}");
                if (System.DateTime.Now.Hour > 12 && System.DateTime.Now.Hour < 18) streamWriter.WriteLine($"Goedendag {input}");
                if (System.DateTime.Now.Hour > 18) streamWriter.WriteLine($"Goedenavond {input}");
            }
        }
    }
}