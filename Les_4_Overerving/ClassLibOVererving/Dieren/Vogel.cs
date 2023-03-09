namespace ClassLibOVererving.Dieren
{
    public class Vogel : Dier
    {
        public bool IsRoofVogel { get; set; }
        public int SpanWijdte { get; set; }
        public bool KanVliegen { get; set; }
        public Vogel(string naam, int aantalPoten, bool heeftVacht, bool isRoofVogel, int spanWijdte, bool kanVliegen) :
            base(naam, aantalPoten, heeftVacht)
        {
            IsRoofVogel = isRoofVogel;
            SpanWijdte = spanWijdte;
            KanVliegen = kanVliegen;
        }

        public override string BeschrijfDier()
        {
            string beschrijving = base.BeschrijfDier();
            beschrijving += $", heeft een spanwijdte van {SpanWijdte}cm";
            if (IsRoofVogel) beschrijving += " en is een roofvogel";
            else beschrijving += " en het is geen roofvogel";

            return beschrijving;
        }

        public override string MaakGeluid()
        {
            return "Pew pew";
        }

        public override string ToString()
        {
            return $"{Naam} Heeft {AantalPoten}";
        }
    }
}
