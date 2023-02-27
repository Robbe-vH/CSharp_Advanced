using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_2_Klasses
{
    public partial class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public string BeschrijfEmployee()
        {
            return $"{FirstName} {LastName} is {DateTime.Now.Year - BirthDate.Year} years old";
        }
    }
}
