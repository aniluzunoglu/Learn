using correct_use = InterfaceSegregation.Correct_Use;
using InterfaceSegregation.Interfaces;
using System;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            correct_use.Interfaces.IBankConnector connector = new correct_use.ABank();
            ((ABank)connector).Operation2();           
        }
    }
}
