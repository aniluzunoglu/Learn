using InterfaceSegregation.Correct_Use.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.Correct_Use
{
    public class CBank : IBankConnector
    {
        public void Operation1()
        {
            //used
        }

        public void Operation2()
        {
            // not needed ? !
        }
    }
}
