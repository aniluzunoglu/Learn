using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Value and Reference Types are kept in two areas in memory.
             Int, double, decimal, boolean, enum, stack value types. 
             It is defined in the stack in the memory and the value is assigned in the stack.
             A change made to the value type is reflected in the stack and affects only that definition.
             */

            int number1 = 10;
            int number2 = number1;

            Console.WriteLine(number1);
            Console.WriteLine(number2);
         

            /*
             class, array, interface, abstract Class, string are reference types. However, string works as a value type.
             In reference types, variable values are kept in the heap.
             In the stack, the address information of those values in the heap is kept.
             */

            string[] cities1 = new string[] { "Ankara", "İstanbul", "İzmir" };
            string[] cities2 = new string[] { "Adana", "Bursa", "Bolu" };


            //When assignments are made between reference types            
            // only the address information kept by cities 2 in the stack becomes the address kept by cities 1.
            
            Console.WriteLine(cities1[0]);
            Console.WriteLine(cities2[0]);

            cities2 = cities1;

            Console.WriteLine(cities1[0]);
            Console.WriteLine(cities2[0]);

            cities2[0] = "Eskişehir";
            
            Console.WriteLine(cities1[0]);
            Console.WriteLine(cities2[0]);

            Console.ReadKey();

            // Garbage Collector is the structure that clears the record through the heap when there is no stack element holding an address in the heap.
        }
    }
}
