using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeManager shapeManager = new ShapeManager(new Triangle());
            ShapeManager Manager = new ShapeManager(new Rectangle());

            // shapeManager supports polymorphism
        }
    }
}
