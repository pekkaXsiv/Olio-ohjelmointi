using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t7
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Give a year: \n");

            year = int.Parse(Console.ReadLine());

            if (year % 400 == 0)
            {
                Console.WriteLine("This year is a leap year.", year);
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("This is not a leap year", year);
            }
            else if (year % 4 == 0 )
            {
                Console.WriteLine("This year is a leap year.", year);
            }
            
            else
            {
                Console.WriteLine("This year is not a leap year.", year);
            }
        }
    }
}
