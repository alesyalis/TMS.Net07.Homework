using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework6.ShapeDraw
{
    abstract public class Drawer 
    {
        abstract public void Draw(Shape shape);

    }

    /* public void DrawTriangle()
     {
         Console.WriteLine("Введите высоту треугольника");
         int hight = int.Parse(Console.ReadLine());

         for (int i = 0; i < hight; i++)
         {
             for (int j = 0; j <= i; j++)
             {
                 Console.Write("*");
             }
             Console.WriteLine();
         }
     }
     public void DrawRectangle()
     {
         Console.WriteLine("Введите высоту прямоугольника");
         int hight = int.Parse(Console.ReadLine());
         Console.WriteLine("Введите ширину прямоугольника ");
         int width = int.Parse(Console.ReadLine());

         for (int i = 0; i < hight; i++)
         {
             for (int j = 0; j < width; j++)
             {
                 Console.Write("#");
             }
             Console.WriteLine();
         }
     }*/





}
