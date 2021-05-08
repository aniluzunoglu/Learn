using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.Correct_Use.Interfaces
{
    interface IPublicBankConnector : IBankConnector
    {
        void Operation3();
    }
}
