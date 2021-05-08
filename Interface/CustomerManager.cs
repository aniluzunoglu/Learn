using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class CustomerManager
    {
        private ILegislation _legislation;

        public CustomerManager(ILegislation legislation)
        {
            _legislation = legislation;
        }

        public void Add()
        {
            _legislation.Perform();

            /* // Single responsibility violation           
            int legislation = 1;
            if (legislation == 1)
            {
                Console.WriteLine("customer added according to first legislation");
            }
            else
            {
                Console.WriteLine("customer added according to second legislation");
            }   
            */
        }
    }
}
