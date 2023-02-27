using ClassLibraryDemo;
using Les1_Klassen;
// Declaratie & Initialisatie
Auto auto = new Auto(4,4,"groen",250,"Tesla");
Persoon persoon = new Persoon("Robbe", "van Hoppe", true, auto);

House huis = new House();
huis.Huisnummer = 19;

int aantalWielen = 4;
auto.AantalWielen = aantalWielen;   // setter aanspreken
Console.WriteLine(auto.AantalWielen);
// auto.HeeftOpenDak = true;        // setter verwijderd

auto.Rij();
auto.VerfAuto("rood");

Console.WriteLine(persoon.PersoonsWagen.AantalWielen);