using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);

            Console.WriteLine("Ma valin välja ühe suvalise numbri vahemikus [1 – 100]. Proovi see ära arvata");
            Console.Write("Tee oma pakkumine: ");

            string pakkumine = Console.ReadLine();
            int kasutaja_number = int.Parse(pakkumine);

            if (number == kasutaja_number)
            {
                Console.WriteLine("Tubli! Arvasid ära!");
            }
            if (number < kasutaja_number)
            {
                Console.WriteLine("Sinu valitud number on liiga suur!");
            }
            if (number > kasutaja_number)
            {
                Console.WriteLine("Sinu valitud number on liiga väike!");
            }
            Console.ReadLine();

        }
    }
}
