namespace ClassLibOVererving.Dieren
{
    // Klasse waarvan GEEN objecten kunnen aangemaakt worden
    public abstract class Dier
    {
        public string Naam { get; set; }
        public int AantalPoten { get; set; }
        public bool HeeftVacht { get; set; }

        public Dier(string naam, int aantalPoten, bool heeftVacht)
        {
            Naam = naam;
            AantalPoten = aantalPoten;
            HeeftVacht = heeftVacht;
        }

        //abstract method = methode zonder implementatie, waarvan subklasses de inhoud gaan overriden
        public abstract string MaakGeluid();

        public virtual string BeschrijfDier()
        {
            string beschrijving = $"Een {Naam} heeft {AantalPoten} poten ";
            if (HeeftVacht) beschrijving += "en heeft vacht";
            else beschrijving += "en geen vacht";
            return beschrijving;
        }


    }
}
