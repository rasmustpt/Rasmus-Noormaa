/*
kolm sisendit (min aasta, max aasta, arvude hulk   nxjkm,mxcm)
genereerib timestampe 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta siia minimaalne aastaarv");
            string a = Console.ReadLine();
            int min = int.Parse(a);

            Console.WriteLine("Sisesta siia maksimaalne aastaarv");
            string b = Console.ReadLine();
            int max = int.Parse(b);

            Console.WriteLine("Sisesta siia genereeritavate andmete hulk");
            string c = Console.ReadLine();
            int quantity = int.Parse(c);
            
            int d = 0;
            
            while (d < quantity)
            {
                Random suva = new Random();
                int random_nr = suva.Next(min, max);

                Console.WriteLine(random_nr);
                d = d + 1;
            }

            Console.ReadLine();
        }
    }
}
