using System.Collections.Generic;

namespace ClassLibUSACars
{
    public class Brand
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public double TotalPrice { get; set; }
        //public List<string> Names { get; set; }

        public Brand(string name)
        {
            Name = name;
            Amount = 0;
        }

        public double GetAveragePrice()
        {
            return TotalPrice / Amount;
        }
    }
}