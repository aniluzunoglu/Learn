using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class ALegislation : LegislationBase
    {
        public override void Evaluate() // Override!!
        {
            Console.WriteLine("Evaluated by A Legislation");
        }
    }
}
