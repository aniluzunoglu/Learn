using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class CLegislation : LegislationBase
    {
        public override void Evaluate()
        {
            Console.WriteLine("Evaluated by C Legislation");
        }

        public override void Save()
        {
            Console.WriteLine("Saved according to C Legislation");
            //base.Save();
        }
    }
}
