using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework6.ShapeDraw
{
    public static class ShapeManager
    {
       public static void PrintShapePerimeter(Shape shape)
        {
            Console.WriteLine($"Perimeter of {shape.GetType().Name} is {shape.GetPerimeter()}");
        }
        public static void PrintShapeSquare(Shape shape)
        {
            Console.WriteLine($"Square of {shape.GetType().Name} is {shape.GetSquare()}");
        }

    }
}
