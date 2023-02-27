using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Klasses_Deel_1
{
    internal class Bank
    {
        #region properties
        public List<BankAccount> Klanten { get; set; }
        public string Naam { get; set; }

        #endregion

        #region constructor
        public Bank(List<BankAccount> klanten, string naam)
        {
            Klanten = klanten;
            Naam = naam;
        }
        #endregion

        #region methodes
        public List<string> GetAlleKlanten()
        {
            List<string> klantenNamen = new List<string>();

            foreach (var klant in Klanten)
            {
                klantenNamen.Add($"{klant.Eigenaar.Voornaam} {klant.Eigenaar.Achternaam}");
            }

            return klantenNamen;
        }

        public void VoegKlantToe(BankAccount acc)
        {
            Klanten.Add(acc);
        }

        public int TotaalSaldo()
        {
            int totaal = 0;
            foreach (var klant in Klanten)
            {
                totaal += klant.Saldo();
            }
            return totaal;
        }

        #endregion
    }
}
