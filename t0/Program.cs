using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give numbers. If you want to stop, input 0.");
            List<int> numbers = new List<int>(); //Luodaan uusi "numbers" lista
            do
            {

                Console.WriteLine("Give number: ");
                int number = int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                else
                {
                    numbers.Add(number); //Lisaa annetun numeron listaan

                }

            } while (true);

            int size = numbers.Count; //count valitsee listan sisällön
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Sum is " + sum);
        }
    }
}
