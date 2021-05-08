using InterfaceSegregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    class CBank : IBankConnector
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
