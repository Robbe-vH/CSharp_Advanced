using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Klasses_Woordenboek
{
    internal static class Woordenboek
    {
        public static Dictionary<string, string> woordenboek = new Dictionary<string, string>()
        {
            { "memory", "geheugen"},
            { "file", "bestand" },
            { "clipboard", "klembord" }
        };
    }
}
