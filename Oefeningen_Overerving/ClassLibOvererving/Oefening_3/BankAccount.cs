namespace ClassLibOvererving.Oefening_3
{
    public abstract class BankAccount
    {
        public Persoon Eigenaar { get; set; }

        private int saldo;
        public int Saldo { get { return saldo; } }

        protected BankAccount(Persoon eigenaar, int saldo)
        {
            Eigenaar = eigenaar;
            this.saldo = saldo;
        }

        public virtual void HaalAf(int bedrag)
        {
            saldo -= bedrag;
        }
        public void Stort(int bedrag)
        {
            saldo += bedrag;
        }
        public int LaadSaldoZien()
        {
            return saldo;
        }
        public string Beschrijf()
        {
            return $"{Eigenaar.Voornaam} {Eigenaar.Achternaam} heeft {saldo} Euro";
        }
        public abstract void VerwerkInterest();
    }
}
