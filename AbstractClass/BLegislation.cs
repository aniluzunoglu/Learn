using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class BLegislation : LegislationBase
    {
        public override void Evaluate() // Override!!
        {
            Console.WriteLine("Evaluated by B Legislation");
        }
    }
}
