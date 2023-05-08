using System.Collections.Generic;

namespace Oefeningen_LINQ
{
    public class WareHouse
    {
        public string BuildingName { get; set; }
        public int WareHouseID { get; set; }
        public string City { get; set; }
        public int PostCode { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int StorageCapacity { get; set; }
        public List<int> EmployeeSatisfaction { get; set; }

    }
}