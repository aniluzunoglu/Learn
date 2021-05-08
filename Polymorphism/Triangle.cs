using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("The triangle is drawn");
        }
    }
}
