using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.Correct_Use.Interfaces
{
    interface IPrivateBankConnector : IBankConnector
    {
        void Operation2();
    }
}
