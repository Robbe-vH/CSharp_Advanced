using System;
using System.Collections.Generic;
using System.IO;

namespace Oefeningen_Streams
{
    internal class Oefening_5
    {
        public static string RandomName()
        {
            using (StreamReader sr = new StreamReader("mensen.txt"))
            {
                List<string[]> voornamen = new List<string[]>();

                while (!sr.EndOfStream)
                {
                    voornamen.Add(sr.ReadLine().Split('-'));
                }
                Random rnd = new Random();
                return voornamen[rnd.Next(0, voornamen.Count - 1)][0];
            }
        }
    }
}
