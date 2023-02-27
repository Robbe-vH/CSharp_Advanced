using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_2_Klasses
{
    public partial class Employee
    {
        public double CalculateIncome()
        {
            // een of andere complexe berekening
            double income = (DateTime.Now.Year - BirthDate.Year) * 2000;
            return income;
        }
    }
}
