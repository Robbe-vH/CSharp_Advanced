using System;
using System.Text;

namespace ClassLibPandaPark
{
    public abstract class Animal : ICSVAble
    {
        public string Country { get; set; }
        public DateTime DayOfBirth { get; set; }
        public string Diet { get; set; }
        public string Gender { get; set; }

        private string hijOfZij;
        internal string HijOfZij
        {
            get
            {
                return hijOfZij;
            }
            set
            {
                if (Gender == "Mannelijk") hijOfZij = "hij";
                else hijOfZij = "zij";
            }
        }
        public bool IsDangerous { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        private string zijnOfHaar;
        internal string ZijnOfHaar 
        { 
            get
            {
                return zijnOfHaar;
            }
            set 
            {
                if (Gender == "Mannelijk") zijnOfHaar = "zijn";
                else zijnOfHaar = "haar";
            } 
        }

        protected Animal(string name, string type, bool isDangerous, string diet, string gender, DateTime dayOfBirth, string country)
        {
            Country = country;
            DayOfBirth = dayOfBirth;
            Diet = diet;
            Gender = gender;
            IsDangerous = isDangerous;
            Name = name;
            Type = type;
        }

        public abstract string Describe();

        public string ToCSV()
        {
            StringBuilder csvSB = new StringBuilder();
            csvSB.Append(Country + ';');
            csvSB.Append(DayOfBirth + ";");
            csvSB.Append(Diet + ';');
            csvSB.Append(Gender + ";");
            csvSB.Append(HijOfZij + ";");
            csvSB.Append(IsDangerous + ";");
            csvSB.Append(Name + ";");
            csvSB.Append(Type + ";");
            csvSB.Append(ZijnOfHaar + ";");
            csvSB.Append('\n');

            return csvSB.ToString();
        }
    }
}
