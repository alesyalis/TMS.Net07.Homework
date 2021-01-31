using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework._2.DaysOfWeek
{
    class Program
    {
        
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter a date: ");
                DateTime userDateTime;

                DateTime max = new DateTime(2999, 12, 31);
                DateTime min = DateTime.MinValue;

                CultureInfo myCI = new CultureInfo("ru-RU");
                var data = Console.ReadLine();

                if (DateTime.TryParse(data, out userDateTime))
                {
                    if (!DateTime.IsLeapYear(userDateTime.Year))
                    {
                        Console.WriteLine("год не високосный");
                    }
                    else
                    {
                        Console.WriteLine("год високосный");
                    }
                    if (userDateTime >= min && userDateTime <= max)
                    {
                        Console.WriteLine("The day of the week is: " + myCI.DateTimeFormat.GetDayName(userDateTime.DayOfWeek));
                    }
                    else

                    {
                        Console.WriteLine("ошибка");
                    }

                }
                else
                {
                    if (data.ToUpper() == "EXIT")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("You have entered an incorrect value.");
                    }

                }
               
                Console.ReadKey();
            } while (true);


        }
    }
}
