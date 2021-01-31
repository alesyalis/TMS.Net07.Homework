﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        public enum MyDayOfWeek
        {
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7
        }

        public static bool IsLeap(int year)
        {
            if (year % 400 == 0) return true;
            return (year % 4 == 0) && (year % 100 != 0);
        }
        public static string GetWeekDayName(int DayIndex)
        {
            MyDayOfWeek DayOfWeekName = (MyDayOfWeek)DayIndex;
            return DayOfWeekName.ToString();
        }
        static void Main(string[] args)
        {

            int d, m, y, weekday;
            byte[] monthTable = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            Console.WriteLine("Введите день");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц");
            m = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Введите год");
                y = Convert.ToInt32(Console.ReadLine());
            } while (y >= 2999);

            weekday = ((y + y / 4 - y / 100 + y / 400 + monthTable[m - 1] + d) % 7);

            Console.WriteLine(GetWeekDayName(weekday));

            switch (weekday)
            {
                case 2:
                    Console.WriteLine("Понедельник");
                    break;
                case 3:
                    Console.WriteLine("Вторник");
                    break;
                case 4:
                    Console.WriteLine("Среда");
                    break;
                case 5:
                    Console.WriteLine("Четвер");
                    break;
                case 6:
                    Console.WriteLine("Пятница");
                    break;
                case 7:
                    Console.WriteLine("Суббота");
                    break;
                case 1:
                    Console.WriteLine("Воскресенье");
                    break;

                default:
                    Console.WriteLine("ошибка");
                    break;

            }
            if (IsLeap(y))
            {
                Console.WriteLine("год високосный");
            }
            else
            {

                Console.WriteLine("год високосный");
            }

            Console.ReadKey();
        }
    }
}
