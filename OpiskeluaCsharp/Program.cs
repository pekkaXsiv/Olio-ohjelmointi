using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpiskeluaCsharp
{
    class Program
    {
        public static void Main()
        {
            int yksi = 1;
            int kaksi = 2;
            int kolme = 3;
            //test
            Console.WriteLine("Anna luku 1-3");
            int numero = int.Parse(Console.ReadLine());

            if (numero == yksi) 
            {
                Console.WriteLine("Yksi");
                
            }
            if (numero == kaksi) 
            {
                Console.WriteLine("Kaksi");
            }
            if (numero == 3) 
            {
                Console.WriteLine("Kolme");
            }

            else if (numero <1 || numero >3)
            {
                Console.WriteLine("Joku muu luku");
            }
        }
    }
    
}
