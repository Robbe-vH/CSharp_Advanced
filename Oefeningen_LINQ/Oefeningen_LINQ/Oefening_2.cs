using System;
using System.Collections.Generic;
using System.Linq;

namespace Oefeningen_LINQ
{
    internal class Oefening_2
    {
        private List<WareHouse> warehouses = new List<WareHouse>()
        {
            new WareHouse()
            {
                BuildingName = "Delhaize",
                WareHouseID = 1,
                City = "Brussels",
                PostCode = 1000,
                Street = "Nieuwstraat",
                HouseNumber = 1,
                StorageCapacity = 1000,
                EmployeeSatisfaction = new List<int>() { 1, 2, 1, 3, 2 }
            },
            new WareHouse()
            {
                BuildingName = "Lidl",
                WareHouseID = 2,
                City = "Antwerp",
                PostCode = 2000,
                Street = "Meir",
                HouseNumber = 2,
                StorageCapacity = 2000,
                EmployeeSatisfaction = new List<int>() { 4, 3, 3, 4, 2 }
            }
            new WareHouse()
            {
                BuildingName = "Aldi",
                WareHouseID = 2,
                City = "Antwerp",
                PostCode = 2000,
                Street = "Meir",
                HouseNumber = 2,
                StorageCapacity = 2000,
                EmployeeSatisfaction = new List<int>() { 5, 5, 3, 4, 4 }
            },
            new WareHouse()
            {
                BuildingName = "Colruyt",
                WareHouseID = 2,
                City = "Antwerp",
                PostCode = 2000,
                Street = "Meir",
                HouseNumber = 2,
                StorageCapacity = 2000,
                EmployeeSatisfaction = new List<int>() { 1, 2, 3, 1, 4 }
            },
            new WareHouse()
            {
                BuildingName = "Carrefour",
                WareHouseID = 3,
                City = "Ghent",
                PostCode = 3000,
                Street = "Veldstraat",
                HouseNumber = 3,
                StorageCapacity = 3000,
                EmployeeSatisfaction = new List<int>() { 1, 1, 0, 2, 1 }
            }
        };

        private List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                ID = 1,
                FirstName = "John",
                LastName = "Doe",
                WareHouseID = 1
            },
            new Employee()
            {
                ID = 2,
                FirstName = "Jane",
                LastName = "Doe",
                WareHouseID = 2
            },
            new Employee()
            {
                ID = 3,
                FirstName = "John",
                LastName = "Smith",
                WareHouseID = 3
            },
            new Employee()
            {
                ID = 4,
                FirstName = "Jane",
                LastName = "Smith",
                WareHouseID = 4
            },
            new Employee()
            {
                ID = 5,
                FirstName = "John",
                LastName = "Wick",
                WareHouseID = 5
            },
            new Employee()
            {
                ID = 6,
                FirstName = "Jane",
                LastName = "Wick",
                WareHouseID = 1
            },
            new Employee()
            {
                ID = 7,
                FirstName = "John",
                LastName = "Doe",
                WareHouseID = 2
            }
        };

        public List<WareHouse> Oef_3a()
        {
            List<WareHouse> warehousesInBerchem = warehouses.Where(x => x.City.Equals("Berchem")).ToList();
            return warehousesInBerchem;
        }

        public Dictionary<string, string> Oef_3b()
        {
            Dictionary<string, string> namenEnSteden = warehouses.OrderBy(
                x => x.EmployeeSatisfaction.Count()).ToDictionary(w => w.City, w => w.BuildingName);
            // kon ook ipv dictionary
            // .Select(x => new { Name=x.BuildingName, City=x.City})
            return namenEnSteden;
        }

        public Dictionary<string, int> Oef_3c()
        {
            Dictionary<string, int> namenEnIds = employees.OrderBy(
                e => e.LastName).ToDictionary(e => $"{e.FirstName} {e.LastName}", e => e.ID);
            return namenEnIds;
        }

        public List<WareHouse> Oef_3d()
        {
            List<WareHouse> rankedWarehouses = warehouses.OrderByDescending(
                               w => w.EmployeeSatisfaction.Average()).ToList();

            return rankedWarehouses;
        }

        public List<WareHouse> Oef_3e()
        {
            List<WareHouse> wareHousesGroupedByCityUnder4000 = warehouses.GroupBy(
                w => w.City.Where(w => w.Postcode < 4000)) 


        }
        
        public List<WareHouse>
    }
}