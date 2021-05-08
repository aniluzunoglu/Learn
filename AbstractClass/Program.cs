using System;

namespace AbstractClass
{
    class Program
    {

        static void Main(string[] args)
        {
            ALegislation aLegislation = new ALegislation();
            aLegislation.Save();
            aLegislation.Evaluate();
            Console.ReadLine();
        }
    }
}
