using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework6.ShapeDraw
{
    public class Square:Shape
    {
        public Point A { get; }
        public  Square(Point a)
        {
            A = a ?? throw new ArgumentNullException(nameof(a));
        }
        public override double GetPerimeter()
        {
            var hight = GetHight();
            return 4 * hight;
        }
        public override double GetSquare()
        {
            var hight = GetHight();
            return hight * hight;
        }
        private int GetHight()
        {
            return Math.Abs(A.X - A.Y);
        }


    }
}
