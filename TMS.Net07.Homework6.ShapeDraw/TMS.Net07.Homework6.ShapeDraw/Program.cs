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
            Console.WriteLine("Ведите фигуру : Circle / Rectangle / Rombu / Triangle / Square/");
            string figure = Console.ReadLine();
            int numberOfPoints = 0;
            String coordinate = String.Empty;
            var drawer = new ConsoleRusDescriptionDrawer();

            switch (figure.ToLower())
            {
                case "circle":
                    numberOfPoints = 2;
                    Point[] CirclePoints = new Point[2];
                    Console.WriteLine($"Ведите координаты ({numberOfPoints}) : X Y");
                    for (int coordinatesEntered = 0; coordinatesEntered < numberOfPoints; coordinatesEntered++)
                    {
                        coordinate = Console.ReadLine();
                        string[] numbers = coordinate.Split(' ');

                        CirclePoints[coordinatesEntered] = new Point (Convert.ToInt32(numbers[0]), Convert.ToInt32(numbers[1]));
                    }
                    var circle = new Circle(CirclePoints[0], CirclePoints[1]);
                    drawer.Draw(circle);
                    ShapeManager.PrintShapePerimeter(circle);
                    ShapeManager.PrintShapeSquare(circle);
                    break;
                case "rectangle":
                    numberOfPoints = 2;
                    Point[] rectanglePoints = new Point[2];
                    Console.WriteLine($"Ведите координаты ({numberOfPoints}) : X Y");
                    for (int coordinatesEntered = 0; coordinatesEntered < numberOfPoints; coordinatesEntered++)
                    {
                        coordinate = Console.ReadLine();
                        string[] numbers = coordinate.Split(' ');

                        rectanglePoints[coordinatesEntered] = new Point (Convert.ToInt32(numbers[0]), Convert.ToInt32(numbers[1]));
                    }
                    var rectangle = new Rectangle(rectanglePoints[0], rectanglePoints[1]);
                    drawer.Draw(rectangle);
                    ShapeManager.PrintShapePerimeter(rectangle);
                    ShapeManager.PrintShapeSquare(rectangle);
                    break;
                case "rombus":
                    numberOfPoints = 4;
                    Point[] rombusPoints = new Point[4];
                    Console.WriteLine($"Ведите координаты ({numberOfPoints}) : X Y");
                    for (int coordinatesEntered = 0; coordinatesEntered < numberOfPoints; coordinatesEntered++)
                    {
                        coordinate = Console.ReadLine();
                        string[] numbers = coordinate.Split(' ');

                        rombusPoints[coordinatesEntered] = new Point(Convert.ToInt32(numbers[0]), Convert.ToInt32(numbers[1]));
                    }
                    var rombus = new Rombus(rombusPoints[0], rombusPoints[1], 
                        rombusPoints[2], rombusPoints[3]);
                    drawer.Draw(rombus);
                    ShapeManager.PrintShapePerimeter(rombus);
                    ShapeManager.PrintShapeSquare(rombus);
                    break;
                case "square":
                    numberOfPoints = 1;
                    Point[] squarePoints = new Point[1];
                    Console.WriteLine($"Ведите координаты ({numberOfPoints}) : X Y");
                    for (int coordinatesEntered = 0; coordinatesEntered < numberOfPoints; coordinatesEntered++)
                    {
                        coordinate = Console.ReadLine();
                        string[] numbers = coordinate.Split(' ');

                        squarePoints[coordinatesEntered] = new Point(Convert.ToInt32(numbers[0]), Convert.ToInt32(numbers[1]));
                    }
                    var square = new Square(squarePoints[0]);
                    drawer.Draw(square);
                    ShapeManager.PrintShapePerimeter(square);
                    ShapeManager.PrintShapeSquare(square);
                    break;
                case "triangle":
                    numberOfPoints = 3;
                    Point[] trianglePoints = new Point[3];
                    Console.WriteLine($"Ведите координаты ({numberOfPoints}) : X Y");
                    for (int coordinatesEntered = 0; coordinatesEntered < numberOfPoints; coordinatesEntered++)
                    {
                        coordinate = Console.ReadLine();
                        string[] numbers = coordinate.Split(' ');

                        trianglePoints[coordinatesEntered] = new Point(Convert.ToInt32(numbers[0]), Convert.ToInt32(numbers[1]));
                    }
                    var triangle = new Triangle(trianglePoints[0], trianglePoints[1], trianglePoints[2]);
                    drawer.Draw(triangle);
                    ShapeManager.PrintShapePerimeter(triangle);
                    break;
                default:
                    {
                        Console.WriteLine("Такой фигуры нет !");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
