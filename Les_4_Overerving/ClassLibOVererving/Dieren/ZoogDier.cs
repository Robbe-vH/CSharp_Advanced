namespace ClassLibOVererving.Dieren
{
    public class ZoogDier : Dier
    {
        public ZoogDier(string naam, int aantalPoten, bool heeftVacht) : 
            base(naam, aantalPoten, heeftVacht)
        {
        }

        public override string BeschrijfDier()
        {
            return base.BeschrijfDier();
        }

        public override string MaakGeluid()
        {
            return "Mihihihi";
        }

        public override string ToString()
        {
            return $"{Naam} heeft {AantalPoten}";
        }
    }
}
