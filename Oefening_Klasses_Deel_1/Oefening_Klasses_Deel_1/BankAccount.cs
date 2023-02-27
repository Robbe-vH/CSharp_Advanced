using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Klasses_Deel_1
{
    internal class BankAccount
    {
        #region properties
        public Persoon Eigenaar { get; set; }
        private string rekeningNummer;

        public string RekeningNummer
        {
            get { return rekeningNummer; }
            set
            {
                // beginnen met BE en voor de rest enkel getallen
                bool containsLetter = false;
                for (int i = 2; i < value.Length; i++)
                {
                    if (0 <= value[i] && value[i] <= 9 ) containsLetter = true;
                }

                if (value.StartsWith("BE") && !containsLetter) rekeningNummer = value;
                else throw new Exception("Het rekenening nummer klopt niet.");
                // Slechts 1 rekening
            }
        }

        public List<Transactie> Transacties { get; }

        #endregion

        #region constructor
        public BankAccount(Persoon eigenaar, string rekeningNummer)
        {
            Eigenaar = eigenaar;
            RekeningNummer = rekeningNummer;
            Transacties = new List<Transactie>();
        }

        #endregion

        #region methodes
        public void VoegTransactieToe(Transactie transactie)
        {
            Transacties.Add(transactie);
        }

        public int Saldo()
        {
            int kapitaal = 0;
            foreach (var transactie in Transacties)
            {
                kapitaal += transactie.Bedrag;
            }
            return kapitaal;
        }

        #endregion
    }
}
