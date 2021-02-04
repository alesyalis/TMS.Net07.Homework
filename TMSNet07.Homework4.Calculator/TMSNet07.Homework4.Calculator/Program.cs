using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSNet07.Homework4.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char repiat = 'y';

            while (Char.ToUpper(repiat) == 'Y')  
            {
                double firstValue;
                double secondValue = 0;
                string oper;

                Console.WriteLine("Введите операцию: +, -, *, /, %, sqr, sqrt, pow");
                oper = Console.ReadLine();
                Console.WriteLine("Введите первое значение: ");
                firstValue = Convert.ToDouble(Console.ReadLine());
                
                if(oper != "sqr" & oper != "sqrt")
                {
                    Console.WriteLine("Введите второе значение");
                    secondValue = Convert.ToDouble(Console.ReadLine());
                }
                
                switch (oper)
                {
                    case "+":
                        Console.WriteLine("{0} + {1} = {2}", firstValue, secondValue, firstValue + secondValue);
                        break;
                    case "-":
                        Console.WriteLine("{0} - {1} = {2}", firstValue, secondValue, firstValue - secondValue);
                        break;
                    case "*":
                        Console.WriteLine("{0} * {1} = {2}", firstValue, secondValue, firstValue * secondValue);
                        break;
                    case "/":
                        //check that the divisor is not 0
                        while (secondValue == 0)
                        {
                            Console.WriteLine("Enter a non-zero divisor: ");
                            secondValue = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine("{0} / {1} = {2}", firstValue, secondValue, firstValue / secondValue);
                        break;
                    case "%":
                        Console.WriteLine("{0} % {1} = {2}", firstValue, secondValue, firstValue % secondValue);
                        break;
                    case "sqr":
                        Console.WriteLine("Результат возведения числа в степень = {0}", Math.Pow(firstValue, 2));
                        break;
                    case "sqrt":
                        Console.WriteLine("Результат возведения квадратного кореня числа sqrt = {0}", Math.Sqrt(firstValue));
                        break;
                    case "pow":
                        Console.WriteLine("Результат возведения числа в степень = {0}", Math.Pow(firstValue, secondValue));
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
                Console.WriteLine("Вы хотите продолжить операцию? Y/N ");
                repiat = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
