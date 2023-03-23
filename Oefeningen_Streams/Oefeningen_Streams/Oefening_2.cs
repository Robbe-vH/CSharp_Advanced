using System.IO;

namespace Oefeningen_Streams
{
    public class Oefening_2
    {
        public static void Wipe(string fileName)
        {
            File.WriteAllText(fileName, string.Empty);
        }
    }
}