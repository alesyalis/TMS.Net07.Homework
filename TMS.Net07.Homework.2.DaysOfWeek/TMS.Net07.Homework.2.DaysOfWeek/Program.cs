using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework._2.DaysOfWeek
{
    class Program
    {
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 0,
            Exit = 10
        };
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Ведите день недели");
                DayOfWeek today;
                today = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());

                switch (today)
                {
                    case DayOfWeek.Monday:
                        Console.WriteLine("Понедельник");
                        break;
                    case DayOfWeek.Tuesday:
                        Console.WriteLine("Вторник");
                        break;
                    case DayOfWeek.Wednesday:
                        Console.WriteLine("Среда");
                        break;
                    case DayOfWeek.Thursday:
                        Console.WriteLine("Четвер");
                        break;
                    case DayOfWeek.Friday:
                        Console.WriteLine("Пятница");
                        break;
                    case DayOfWeek.Saturday:
                        Console.WriteLine("Суббота");
                        break;
                    case DayOfWeek.Sunday:
                        Console.WriteLine("Воскресенье");
                        break;
                    case DayOfWeek.Exit:
                        return;
                    default:
                        Console.WriteLine("ошибка");
                        break;


                }

                Console.ReadKey();
            } while (true);





        }
    }
}
