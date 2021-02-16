using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework6.ShapeDraw
{
    abstract public class Shape
    {
        abstract public double GetSquare();
        abstract public double GetPerimeter();
        abstract public int[] GetPoints();
    }
}
