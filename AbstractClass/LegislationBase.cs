using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    abstract class LegislationBase
    {
        protected LegislationBase()
        {
            // It will be fired when the child class instance created with new keyword.
        }
        public abstract void Evaluate();

        public void Save()
        {
            Console.WriteLine("Saved");
        }
    }
}
