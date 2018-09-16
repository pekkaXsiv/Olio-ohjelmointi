using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How old are you?");

            int age = int.Parse(Console.ReadLine());

            if (age <= 17)
            {
                Console.WriteLine("Underage");
            }
            if (age >=18 && age <=65)
            {
                Console.WriteLine("Legit");
            }
            if (age >= 66)
            {
                Console.WriteLine("Senior");
            }
        }
    }
}
