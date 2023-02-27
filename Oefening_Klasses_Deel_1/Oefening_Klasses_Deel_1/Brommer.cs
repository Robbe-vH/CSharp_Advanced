using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Klasses_Deel_1
{
    internal class Brommer
    {
        // properties en variabelen
        private int aantalWielen;

        public int AantalWielen
        {
            get { return aantalWielen; }
            set { aantalWielen = value; }
        }

        private string merk;

        public string Merk
        {
            get { return merk; }
            set { merk = value; }
        }

        string rijbewijs;
        int maxSnelheid;

        //constructor
        public Brommer(int aantalWielen, string merk, string rijbewijs, int maxSnelheid)
        {
            this.aantalWielen = aantalWielen;
            this.merk = merk;
            this.rijbewijs = rijbewijs;
            this.maxSnelheid = maxSnelheid;
        }



        public string BeschrijfVoertuig()
        {
            return  $"Aantal wielen: {this.aantalWielen} wielen\r" +
                    $"merk: {this.merk}\r" +
                    $"Rijbewijs: {this.rijbewijs}\r" +
                    $"Max Snelheid: {this.maxSnelheid} ";
        }

        public string Rij()
        {
                return "brrrrrr";
        }
    }
}
