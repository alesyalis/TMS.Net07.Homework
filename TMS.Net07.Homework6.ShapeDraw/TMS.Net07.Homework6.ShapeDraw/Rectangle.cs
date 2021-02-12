using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework6.ShapeDraw
{
    public class Rectangle : Shape
    {
        public Point A { get; }
        public Point B { get; }
        public Rectangle(Point a, Point b )
        {
            A = a ?? throw new ArgumentNullException(nameof(a));
            B = b ?? throw new ArgumentNullException(nameof(b));
            
        }
        public override double GetPerimeter()
        {
            var widht = GetWidht();
            var hight = GetHight();
            return (widht + hight) * 2;
        }
        public override double GetSquare()
        {
            var widht = GetWidht();
            var hight = GetHight();
            return widht * hight;
        }
        private int GetWidht()
        {
            return Math.Abs(A.X - B.X);
        }
        private int GetHight()
        {
            return Math.Abs(A.Y - B.Y);
        }
    }
}
