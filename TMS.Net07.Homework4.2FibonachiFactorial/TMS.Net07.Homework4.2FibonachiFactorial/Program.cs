using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework4._2FibonachiFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string oper;
            Console.WriteLine("Выбор операции : n!,  f(n), ");
            oper = Console.ReadLine();
            Console.WriteLine("Введите значение : ");

            switch (oper)
            {
                case "n!":
                    int value = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Факториал числа {0} равен {1}", value, Factorial(value));
                    break;
                case "f(n)":
                    int fibo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0}", Fibonachi(fibo));
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.ReadKey();
        }
        static int Factorial(int value)
        {
            if (value == 0)
            {
                return 1;
            }
            else
            {
                return value * Factorial(value - 1);
            }
        }
        static int Fibonachi(int fibo)
        {
            if (fibo == 0 || fibo == 1)
            {
                return fibo;
            }
            else
            {
                return Fibonachi(fibo - 1) + Fibonachi(fibo - 2);
            }
        }
    }
}
