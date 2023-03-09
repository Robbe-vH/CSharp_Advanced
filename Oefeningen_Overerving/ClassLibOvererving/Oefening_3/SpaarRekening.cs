namespace ClassLibOvererving.Oefening_3
{
    internal class SpaarRekening : BankAccount
    {
        public SpaarRekening(Persoon eigenaar, int saldo) : base(eigenaar, saldo)
        {
        }

        public override void VerwerkInterest()
        {
            Saldo *= 1.01;
        }
    }
}
