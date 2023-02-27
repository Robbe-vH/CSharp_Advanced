using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les1_Klassen
{
    internal class Auto
    {
        // variabelen
        private int aantalDeuren;   // access modifiers bijna altijd op private, tenzij dat je het ergens anders nodig hebt

        string kleur;
        int pk;
        string merk;

        // properties
        public int AantalDeuren { get; set; }
        private int aantalWielen;

        public int AantalWielen
        {
            get { return aantalWielen; }
            set 
            {
                if (value > 0) aantalWielen = value;
                else aantalWielen = 4;

            }
        }

        private bool heeftOpenDak;

        public bool HeeftOpenDak
        {
            get { return HeeftOpenDak; }
           // setter verwijderen: niet meer aanpassen na het initialiseren
        }



        public Auto(int aantalDeuren, int aantalWielen, string kleur, int pk, string merk)
        {
            this.aantalDeuren = aantalDeuren;
            this.aantalWielen = aantalWielen;
            this.kleur = kleur;
            this.pk = pk;
            this.merk = merk;
            this.heeftOpenDak = true;
        }

        public void Rij()
        {
            if (merk.Equals("Tesla")) Console.WriteLine("zzzzzzz");
            else Console.WriteLine("Brrrrrrrr");
        }

        public void RijVoorBepaaldeTijd(int tijd)
        {
            Console.WriteLine($"De wagen heeft {tijd*pk} kilometer afgelegd");
        }

        public void VerfAuto(string kleur)
        {
            this.kleur = kleur;
        }
    }
}
