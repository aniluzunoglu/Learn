using InterfaceSegregation.Correct_Use.Interfaces;
using InterfaceSegregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.Correct_Use
{
    public class ABank : IPrivateBankConnector
    {
        public void Operation1()
        {
            //used
        }

        public void Operation2()
        {
            //used
        }
    }
}
