using System;
using System.Text;

namespace ClassLibPandaPark
{
    public class Bird : Animal
    {
        public Bird(string name, string type, bool isDangerous, string diet, string gender, DateTime dayOfBirth, string country, string nestType, int wingSpan) : base(name, type, isDangerous, diet, gender, dayOfBirth, country)
        {
            NestType = nestType;
            WingSpan = wingSpan;
        }

        public string NestType { get; set; }
        public int WingSpan { get; set; }

        public override string Describe()
        {
            return $"{Name} is een {Type} {HijOfZij} is van het nesttype {NestType} en {ZijnOfHaar} spanwijdte is {WingSpan}";
        }


    }
}
