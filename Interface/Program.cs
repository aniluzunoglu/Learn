using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new SecondLegislation());
            customerManager.Add();
            Console.ReadLine();
        }
    }
}
