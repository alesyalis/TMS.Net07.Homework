using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework6.ShapeDraw
{
    public class Rombus : Shape
    {
        public Point A { get; }
        public Point B { get; }
        public Point C { get; }
        public Point D { get; }
        public Rombus(Point a, Point b, Point c, Point d)
        {
            A = a ?? throw new ArgumentNullException(nameof(a));
            B = b ?? throw new ArgumentNullException(nameof(b));
            C = c ?? throw new ArgumentNullException(nameof(c));
            D = d ?? throw new ArgumentNullException(nameof(d));
        }
        public override double GetPerimeter()
        {
            return 4 * A.GetDistance(B);
        }
        public override double GetSquare()
        {
            return ((A.X - C.X) * (B.X - D.X)) / 2;
        }

    }
}
