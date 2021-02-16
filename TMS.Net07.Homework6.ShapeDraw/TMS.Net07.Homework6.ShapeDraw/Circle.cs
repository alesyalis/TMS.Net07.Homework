using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework6.ShapeDraw
{
    public class Circle : Shape
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Circle(Point a, Point b)
        {
            A = a ?? throw new ArgumentNullException(nameof(a));
            B = b ?? throw new ArgumentNullException(nameof(b));
        }
        public override double GetPerimeter()
        {
            double radius = GetRadius();
            return 2 * Math.PI * radius;
        }
        public override double GetSquare()
        {
            double radius = GetRadius();
            return Math.PI * (radius * radius);
        }
        public double GetRadius()
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }
        public override int[] GetPoints()
        {
            int[] points = { A.X, A.Y, B.X, B.Y };
            return points;
        }
    }
}
