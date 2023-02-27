using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Artikel
    {
        #region properties
        public string DatumVanPublicatie { get; set; }
        public string ImagePath { get; set; }
        public string Inhoud { get; set; }
        public string Journalist { get; set; }
        public string Titel { get; set; }

        #endregion

        #region constructors
        public Artikel(string datumVanPublicatie, string imagePath, string inhoud, string journalist, string titel)
        {
            DatumVanPublicatie = datumVanPublicatie;
            ImagePath = imagePath;
            Inhoud = inhoud;
            Journalist = journalist;
            Titel = titel;
        }

        public Artikel(string datumVanPublicatie, string inhoud, string journalist, string titel)
        {
            DatumVanPublicatie = datumVanPublicatie;
            Inhoud = inhoud;
            Journalist = journalist;
            Titel = titel;
        }

        #endregion

    }
}
