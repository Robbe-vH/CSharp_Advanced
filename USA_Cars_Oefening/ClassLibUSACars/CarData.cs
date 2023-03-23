using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ClassLibUSACars
{
    public static class CarData
    {
        private static string headerFromFile = string.Empty;
        private static string bodyFromFile = string.Empty;
        public static List<Car> Cars = new List<Car>();

        public static string TextFromFile
        { get { return headerFromFile + '\n' + bodyFromFile; } }

        public static string GetCars()
        {
            OpenFileDialog ofd = new OpenFileDialog() { InitialDirectory = Directory.GetCurrentDirectory() };
            if (ofd.ShowDialog() == true)
            {
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    headerFromFile = sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        bodyFromFile += $"{sr.ReadLine()}\n";
                    }
                }
            }
            return TextFromFile;
        }

        public static List<Car> GetCarsFromFile()
        {
            string[] lines = bodyFromFile.Split('\n');

            foreach (string line in lines)
            {
                if (!String.IsNullOrEmpty(line))
                {
                    string[] carData = line.Split(';');
                    Car car = new Car(carData);
                    Cars.Add(car);
                }
            }
            return Cars;
        }

        //public static List<string> GetSummary()
        //{
        //    List<Brand> brands = new List<Brand>();

        //    foreach (Car car in Cars)
        //    {
        //        for (int i = 0; i < brands.Count; i++)
        //        {
        //            if (!brands.Select(b => (b.Name)).Contains(car.Brand)) brands.Add(new Brand(car.Brand));
        //            else brands[i].TotalPrice += car.Price; brands[i].Amount++;
        //        }
        //    }

        //    return;
        //}

        public static Dictionary<string, List<Car>> GroupCarsByName()
        {
            Dictionary<string, List<Car>> carsByBrandName = new Dictionary<string, List<Car>>();

            foreach (Car car in Cars)
            {
                if (!carsByBrandName.ContainsKey(car.Brand)) carsByBrandName.Add(car.Brand, new List<Car>() { car });
                else carsByBrandName[car.Brand].Add(car);
            }
            return carsByBrandName;
        }
    }
}