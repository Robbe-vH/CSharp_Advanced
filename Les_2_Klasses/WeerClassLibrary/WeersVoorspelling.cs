using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_2_Klasses
{
    public class WeersVoorspelling
    {
        public static int currentId = 0;
        public static int GetNextId()
        {
            return currentId++;
        }
        public int Id { get; set; }
        public string Voorspelling { get; set; }
        public int Neerslag { get; set; } // cm3
        public int WindSnelheid { get; set; } //km/h
        public int Temperatuur { get; set; }

        public bool IsOrkaan { get; set; }
        public string StormCode { get; set; }

        public WeersVoorspelling() : this ( "Het gaat mooi weer worden", 0, 5, 20)
        {
        }

        public WeersVoorspelling(string voorspelling, int neerslag, int windSnelheid, int temperatuur)
        {
            Id = GetNextId();
            Voorspelling = voorspelling;
            Neerslag = neerslag;
            WindSnelheid = windSnelheid;
            Temperatuur = temperatuur;
        }

        public WeersVoorspelling(string voorspelling, int neerslag, int windSnelheid, int temperatuur, string stormCode) 
            : this(voorspelling, neerslag, windSnelheid, temperatuur)
        {
            StormCode = stormCode;
        }

        public WeersVoorspelling(int id, string voorspelling, int neerslag, int windSnelheid, int temperatuur, bool isOrkaan, string stormCode) 
            : this(voorspelling, neerslag, windSnelheid, temperatuur)
        {
            IsOrkaan = isOrkaan;
        }
    }
}
