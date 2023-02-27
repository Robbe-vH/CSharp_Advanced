using ClassLibraryDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les1_Klassen
{
    internal class Persoon
    {
        public string VoorNaam { get; set; }
        public string AchterNaam { get; set; }
        public bool IsMan { get; set; }

        public Auto PersoonsWagen { get; set; }

        public Persoon(string voorNaam, string achterNaam, bool isMan, Auto persoonsWagen)
        {
            VoorNaam = voorNaam;
            AchterNaam = achterNaam;
            IsMan = isMan;
            PersoonsWagen = persoonsWagen;
        }
    }
}
