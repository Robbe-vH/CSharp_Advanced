using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_7_Interfaces
{
    internal class BaseHelp
    {
        public string Help { get; set; }
        public BaseHelp()
        {
            Help = "Try google";
        }

        public virtual void DoSomethingAlmostPerfect()
        {
            //Do something
        }
    }
}
