using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework6.ShapeDraw
{
    public class Triangle : Shape
    {
        public Point A { get; }
        public Point B { get; }
        public Point C { get; }

        public Triangle(Point a, Point b, Point c)
        {
            A = a ?? throw new ArgumentNullException(nameof(a));
            B = b ?? throw new ArgumentNullException(nameof(b));
            C = c ?? throw new ArgumentNullException(nameof(c));
        }
        public override double GetPerimeter()
        {
            return A.GetDistance(B) +
                   B.GetDistance(C) + 
                   C.GetDistance(A);
        }
        public override double GetSquare()
        {
            throw new NotImplementedException();
        }
    }
}
