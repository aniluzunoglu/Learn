using System;

namespace AbstractClass
{
    class Program
    {

        static void Main(string[] args)
        {
            //ALegislation aLegislation = new ALegislation();
            //aLegislation.Save();
            //aLegislation.Evaluate();

            CLegislation cLegislation = new CLegislation();
            cLegislation.Save();
            Console.ReadLine();
        }
    }
}
