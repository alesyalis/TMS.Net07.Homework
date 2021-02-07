using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07._4Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entor some number to stop fibonacci sequence");
            int num = int.Parse(Console.ReadLine());

            int firstvalue = 1;
            Console.Write("{0}, ", firstvalue);
            int secondvalue = 1;
            Console.Write("{0}, ", secondvalue);
            int sum = 1;

            while(sum <= num)
            {
                sum = firstvalue + secondvalue;
                Console.Write("{0}, ", sum);
                firstvalue = secondvalue;
                secondvalue = sum;

            }
            Console.ReadKey();

        }
    }
}
