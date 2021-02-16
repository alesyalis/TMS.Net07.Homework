using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework6.ShapeDraw
{
    public class ConsoleRusDescriptionDrawer : Drawer
    {
        public override void Draw(Shape shape)
        {
            Console.WriteLine($"{shape.GetType()}");
            var points = shape.GetPoints();
            
            if (shape is Circle circle)  
            {
                circle.A.X = points[0];
                circle.A.Y = points[1];
                circle.B.X = points[2];
                circle.B.Y = points[3];
            }
            if (shape is Rectangle rectangle)
            {
                rectangle.A.X = points[0];
                rectangle.A.Y = points[1];
                rectangle.B.X = points[2];
                rectangle.B.Y = points[3];
            }
            if (shape is Rombus rombus)
            {
                rombus.A.X = points[0];
                rombus.A.Y = points[1];
                rombus.B.X = points[2];
                rombus.B.Y = points[3];
                rombus.C.X = points[4];
                rombus.C.Y = points[5];
                rombus.D.X = points[6];
                rombus.D.Y = points[7];
            }
            if (shape is Square square)
            {
                square.A.X = points[0];
                square.A.Y = points[1];
                
            }
            if (shape is Triangle triangle)
            {
                triangle.A.X = points[0];
                triangle.A.Y = points[1];

            }


        }
    }
}
