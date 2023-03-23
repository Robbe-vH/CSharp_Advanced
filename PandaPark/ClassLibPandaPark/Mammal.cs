using System;

namespace ClassLibPandaPark
{
    public class Mammal : Animal
    {
        private bool isInfant;

        public Mammal(string name, string type, bool isDangerous, string diet, string gender, DateTime dayOfBirth, string country) : base(name, type, isDangerous, diet, gender, dayOfBirth, country)
        {
        }

        public bool IsInfant { get { return isInfant; } 
            set 
            {
                if ((DateTime.Now - DayOfBirth) > TimeSpan.FromDays(365)) isInfant = true;
                else isInfant = false;
            }
        }


        public override string Describe()
        {
            if (isInfant) return $"{Name} is een {Type}, {HijOfZij} is een baby en {ZijnOfHaar} geboorteland is {Country}.";
            else return $"{Name} is een {Type}, {HijOfZij} is volwassen en {ZijnOfHaar} geboorteland is {Country}.";

        }
    }
}
