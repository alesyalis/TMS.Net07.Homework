using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace TMS.Net07.Homework5.Shape
{
    class Program
    {

        enum Figure
        {
            Square =1,
            Rectangle,
            Triangle,
            Rhombus,
            Circle
        }
        static void Main(string[] args)
        {
            double _a, _b, _c, _d1, _d2, _r;
            Console.WriteLine("Введите фигуру : ");
            var values = Enum.GetValues(typeof(Figure));
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
            string str = Console.ReadLine();
            Figure figureGeom = (Figure)Enum.Parse(typeof(Figure), str, ignoreCase : true );
           
            Console.WriteLine(figureGeom);

            switch (figureGeom)
            {
                case Figure.Square:
                    Console.WriteLine("Введите размер : ");
                    _a = Convert.ToDouble(Console.ReadLine());
                    Shape figure = new Square(_a);

                    Console.WriteLine($"Figure's type is {figure.GetType().Name}");
                    Console.WriteLine($"Figure's square is {figure.squareShape()}");
                    Console.WriteLine($"Figure's perimeter is {figure.perimeterShape()}");
                    break;
                case Figure.Rectangle:
                    Console.WriteLine("Введите размер a : ");
                    _a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите размер b : ");
                    _b = Convert.ToDouble(Console.ReadLine());
                    Shape figureRectangrl = new Rectangle(_a, _b);

                    Console.WriteLine($"Figure's type is {figureRectangrl.GetType().Name}");
                    Console.WriteLine($"Figure's square is {figureRectangrl.squareShape()}");
                    Console.WriteLine($"Figure's perimeter is {figureRectangrl.perimeterShape()}");
                    break;
                case Figure.Triangle:
                    Console.WriteLine("Введите размер a : ");
                    _a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите размер b : ");
                    _b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите размер c : ");
                    _c = Convert.ToDouble(Console.ReadLine());
                    Shape figureTriangl = new Triangle(_a, _b, _c);

                    Console.WriteLine($"Figure's type is {figureTriangl.GetType().Name}");
                    Console.WriteLine($"Figure's square is {figureTriangl.squareShape()}");
                    Console.WriteLine($"Figure's perimeter is {figureTriangl.perimeterShape()}");
                    break;
                case Figure.Rhombus:
                    Console.WriteLine("Введите размер a : ");
                    _a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите размер d1 : ");
                    _d1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите размер d2 : ");
                    _d2 = Convert.ToDouble(Console.ReadLine());
                    Shape figureRombus = new Rhombus(_a, _d1, _d2);

                    Console.WriteLine($"Figure's type is {figureRombus.GetType().Name}");
                    Console.WriteLine($"Figure's square is {figureRombus.squareShape()}");
                    Console.WriteLine($"Figure's perimeter is {figureRombus.perimeterShape()}");
                    break;
                case Figure.Circle:
                    Console.WriteLine("Введите размер r : ");
                    _r = Convert.ToDouble(Console.ReadLine());
                    Shape figureCircle = new Circle(_r);

                    Console.WriteLine($"Figure's type is {figureCircle.GetType().Name}");
                    Console.WriteLine($"Figure's square is {figureCircle.squareShape()}");
                    Console.WriteLine($"Figure's perimeter is {figureCircle.perimeterShape()}");
                    break;
                default:
                    break;
            }
           


            Console.ReadKey();
        }
    }
    abstract public class Shape
    {
        abstract public double squareShape();
        abstract public double perimeterShape();
    }
    public class Square : Shape
    {
        double a;
        public Square(double a)
        {
            this.a = a;
        }
        public override double squareShape()
        {
            return a * a;
        }
        public override double perimeterShape()
        {
            return 4 * a;
        }

    }
    public class Rectangle : Shape
    {
        double a, b;
       
        public Rectangle(double a, double b) 
        {
            this.a = a;
            this.b = b;
        }
        public override double squareShape()
        {
            return a * b;
        }
        public override double perimeterShape()
        {
            return (a + b) * 2; 
        }

    }
    public class Triangle : Shape
    {
        double a, b, c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double squareShape()
        {
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
        public override double perimeterShape()
        {
            return (a + b + c);
        }
    }
    public class Rhombus : Shape
    {
        double a;
        double d1, d2;
        public Rhombus(double a, double d1, double d2)
        {
            this.a = a;
            this.d1 = d1;
            this.d2 = d2;
        }
        public override double squareShape()
        {
            return (d1 * d2) / 2;
        }
        public override double perimeterShape()
        {
            return 4 * a;
        }

    }
    public class Circle : Shape
    {
        double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public override double squareShape()
        {
            return 3.14 * (r * r);
        }
        public override double perimeterShape()
        {
            return 2 * 3.14 * r;
        }
    }

}
