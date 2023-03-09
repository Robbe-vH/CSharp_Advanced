namespace ClassLibOvererving.Oefening_3
{
    internal class ZichtRekening : BankAccount
    {
        public ZichtRekening(Persoon eigenaar, int saldo) : base(eigenaar, saldo)
        {
        }

        public override void VerwerkInterest()
        {
            saldo *= 1.005;
        }
    }
}
