using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Klasses_Deel_1
{
    internal class Auto
    {
		private int aantalWielen;
		private int aantalDeuren;
		private string merk;
		private string rijbewijs;
		private int maxSnelheid;

        public string BeschrijfVoertuig()
        {
            return  $"Aantal wielen: {this.aantalWielen} wielen\r" +
                    $"Aantal Dueren: {this.aantalDeuren}\r" +
                    $"merk: {this.merk}\r" +
                    $"Rijbewijs: {this.rijbewijs}\r" +
                    $"Max Snelheid: {this.maxSnelheid} ";
        }

        public string Rij()
        {
            return "Brrrrrrrrrr";
        }



    }
}
