using System.Collections.Generic;
using System.IO;

namespace Oefeningen_Streams
{
    public class Oefening_4
    {
        public static List<string> ZoekAchterNaam(string achternaam)
        {
            using (StreamReader sr = new StreamReader("mensen.txt"))
            {
                List<string> voornamen = new List<string>();
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split('-');
                    if (achternaam.ToUpper().Equals(line[1].ToString())) voornamen.Add(line[0]);
                }

                return voornamen;
            }
        }
    }
}