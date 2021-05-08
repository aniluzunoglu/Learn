using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class SecondLegislation : ILegislation
    {
        public void Perform()
        {
            Console.WriteLine("customer added according to second legislation");
        }
    }
}
