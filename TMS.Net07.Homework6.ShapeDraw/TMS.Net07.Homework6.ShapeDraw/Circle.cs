using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework6.ShapeDraw
{
    public class Circle : Shape
    {
        Point A { get; }
        Point B { get; }
        
        public Circle(Point a, Point b)
        {
            A = a ?? throw new ArgumentNullException(nameof(a));
            B = b ?? throw new ArgumentNullException(nameof(b));
            
        }
        public override double GetPerimeter()
        {
            var radius = GetRadius();
            return 2 * Math.PI * radius;
        }
        public override double GetSquare()
        {
            var radius = GetRadius();
            return Math.PI*(radius * radius); ;
        }
        private int GetRadius()
        {
            return Convert.ToInt32(Math.Sqrt(Math.Pow((B.X-A.X) *(B.X - A.X) - (B.Y - A.Y) * (B.X - A.X), 0.5)));
        }
    }
}
