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
            do
            {
                string oper;
                Console.WriteLine("Выбор операции : n!,  n!2,  f(n), ");
                oper = Console.ReadLine();
                Console.WriteLine("Введите значение : ");

                var buffer = new int[fibo];

                switch (oper)
                {
                    case "n!":
                        int value = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Факториал числа {0} равен {1}", value, Factorial(value));
                        break;
                    case "n!2":
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Factorial2(num1);
                        break;
                    case "f(n)":
                        int fibo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0}", Fibonachi(fibo, buffer));
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                Console.Write("Press <Escape> to exit... ");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            
        }
        //рекурсивный рассчет факториала числа
        static int Factorial(int value)
        {
            if (value == 0)
            {
                return 1;
            }
            else if(value < 0)
            {
                return 1;
            }
            else
            {
                return value * Factorial(value - 1);
            }
        }
        //рассчет факториала числа в цикле
        static int Factorial2(int num)
        {
            int factorial = 1;
            if (num <= 0)
            {
                Console.Write("{0}", factorial);
                return factorial;
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                    if (i == num)
                    {
                        Console.Write("{0}", i);
                    }
                    else
                    {
                        Console.Write("{0} * ", i);
                    }
                }
                Console.Write(" = {0}", factorial);
                return factorial;
            }
            
        }
        //рассчет N-ого числа Фибоначчи
        static int Fibonachi(int fibo, int [] buffer)
        {
            

            if (fibo < 0)
            {
                throw new ArgumentException("Ведите положительное");
            }
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
