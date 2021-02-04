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
                double secondValue;
                char oper;

                Console.WriteLine("Введите первое значение: ");
                firstValue = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите операцию: +, -, *, /,% ");
                oper = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Введите второе значение");
                secondValue = Convert.ToDouble(Console.ReadLine());

                switch (oper)
                {
                    case '+':
                        Console.WriteLine("{0} + {1} = {2}", firstValue, secondValue, firstValue + secondValue);
                        break;
                    case '-':
                        Console.WriteLine("{0} - {1} = {2}", firstValue, secondValue, firstValue - secondValue);
                        break;
                    case '*':
                        Console.WriteLine("{0} * {1} = {2}", firstValue, secondValue, firstValue * secondValue);
                        break;
                    case '/':
                        //check that the divisor is not 0
                        while (secondValue == 0)
                        {
                            Console.WriteLine("Enter a non-zero divisor: ");
                            secondValue = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine("{0} / {1} = {2}", firstValue, secondValue, firstValue / secondValue);
                        break;
                    case '%':
                        Console.WriteLine("{0} % {1} = {2}", firstValue, secondValue, firstValue % secondValue);
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
