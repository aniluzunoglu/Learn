using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("The rectangle is drawn");
        }
    }
}
