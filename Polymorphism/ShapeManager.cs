using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class ShapeManager
    {
        private IShape _shape;
        public ShapeManager(IShape shape)
        {
            _shape = shape;
        }
        public void Draw()
        {
            _shape.Draw();
        }
    }
}
