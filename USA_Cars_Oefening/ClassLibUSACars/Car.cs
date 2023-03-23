using System;

namespace ClassLibUSACars
{
    public class Car
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public string Color { get; set; }
        public string Vin { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public Car(string[] carData)
        {
            Id = Convert.ToInt32(carData[0]);
            Price = Convert.ToDouble(carData[1]);
            Brand = carData[2];
            Model = carData[3];
            Year = Convert.ToInt32(carData[4]);
            Mileage = Convert.ToDouble(carData[5]);
            Color = carData[6];
            Vin = carData[7];
            State = carData[8];
            Country = carData[9];
        }
    }
}