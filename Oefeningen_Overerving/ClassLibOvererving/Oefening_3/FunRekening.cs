using System;

namespace ClassLibOvererving.Oefening_3
{
    internal class FunRekening : BankAccount
    {
        public FunRekening(Persoon eigenaar, int saldo) : base(eigenaar, saldo)
        {
        }

        public override void VerwerkInterest()
        {
            //1op10 kans om 100% rente
            Random rnd = new Random();
            if (rnd.Next(1,10) == 1)
            {
                Saldo += Saldo;
            }

        }

        public override void HaalAf(int bedrag)
        {
            //1op10 kans op geen bedrag aftrekken
            base.HaalAf(bedrag);
        }
    }
}
