using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class FirstLegislation : ILegislation
    {
        public void Perform()
        {
            Console.WriteLine("customer added according to first legislation");
        }
    }
}
