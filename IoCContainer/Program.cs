using System;
using Ninject;

namespace IoCContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            //IoC container 
            // we put instances into kernel box
            var kernel = new StandardKernel();
            kernel.Bind<ILegislation>().To<SecondLegislation>().InSingletonScope();
            // if someone wants ILegislation give him SecondLecislation.
            // it is usually used in transaction between layers

            CustomerManager customerManager = new CustomerManager(kernel.Get<ILegislation>());
            customerManager.Add();
            Console.ReadLine();
        }
    }
}
