using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework6.ShapeDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(
                new Point(0, 0),
                new Point(4, 4));

            var triangle = new Triangle(
                new Point(0, 0),
                new Point(0, 4),
                new Point(4, 4));

            var square = new Square(
                new Point(2, 0));

            var circle = new Circle(
                new Point(3, 2),
                new Point(2, 2));
            var rombus = new Rombus(
                new Point(2, 1),
                new Point(4, 4),
                new Point(8, 4),
                new Point(6, 1));

            ShapeManager.PrintShapePerimeter(rombus);
            ShapeManager.PrintShapeSquare(rombus);
            ShapeManager.PrintShapePerimeter(circle);
            ShapeManager.PrintShapeSquare(circle);
            ShapeManager.PrintShapePerimeter(square);
            ShapeManager.PrintShapeSquare(square);
            ShapeManager.PrintShapePerimeter(triangle);
            
            ShapeManager.PrintShapePerimeter(rectangle);
            ShapeManager.PrintShapeSquare(rectangle);
            Console.ReadKey();
        }
    }
}
