using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_Klasses_Deel_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Brommer broem = new Brommer(2,"Vespa","B",160);
            Console.WriteLine(broem.Rij());
            Console.ReadLine();
        }
    }
}
